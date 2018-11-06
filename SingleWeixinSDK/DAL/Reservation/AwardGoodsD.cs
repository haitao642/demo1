using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AwardGoodsD:BaseTable
    {
        public AwardGoodsD()
            : base("T_AwardGoods", "Ing_AwardGoodsID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(AwardGoodsM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �齱��Ʒ��ȡ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(AwardGoodsM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<AwardGoodsM>(model, model.Ing_AwardGoodsID);
            model.Ing_AwardGoodsID = this.lngKeyID;
            return rev;
        }


        
        /// <summary>
        /// ���ɾ��
        /// </summary>
        /// <param name="lnguserid"></param>
        /// <returns></returns>
        public bool CheckDelete(int id)
        {
            return true;
        }


        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="lnguserid"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {

            if (!CheckDelete(id))
            {
                return false;
            }

            return this.DeleteRecord(id);
        }
        #endregion

        /// <summary>
        /// �жϸ��û��Ƿ��Ѿ��齱����
        /// </summary>
        /// <param name="VipcardID"></param>
        /// <returns></returns>
        public bool AlreadyAward(int VipcardID)
        {
            string strSql = "SELECT count(1) FROM dbo.T_AwardGoods a WHERE ISNULL(a.Ing_VipcardID,0)={0}";
            strSql = string.Format(strSql,VipcardID);

            return this.Sqlca.GetInt32(strSql) > 0;
        }

        /// <summary>
        /// ����ĳ�˵Ľ�Ʒ
        /// </summary>
        /// <param name="VipcardID"></param>
        /// <returns></returns>
        public List<AwGoodModel> GetGoods(int VipcardID)
        {
            string strSql = "SELECT * FROM dbo.V_AwardGoods a WHERE a.Ing_VipcardID={0}";
            strSql = string.Format(strSql,VipcardID);

            return this.GetQueryM<AwGoodModel>(strSql);
        }
    }
}
