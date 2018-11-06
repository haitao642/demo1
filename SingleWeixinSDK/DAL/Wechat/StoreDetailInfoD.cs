using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreDetailInfoD:BaseTable
    {
        public StoreDetailInfoD()
            : base("T_StoreDetailInfo", "Ing_StoreDetailInfoID")
        {
            this.Sqlca = SqlcaWeChat();
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(StoreDetailInfoM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �ŵ���ϸ��Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(StoreDetailInfoM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<StoreDetailInfoM>(model, model.Ing_StoreDetailInfoID);
            model.Ing_StoreDetailInfoID = this.lngKeyID;
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
        /// �����ŵ�ID �����ŵ�����
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public StoreDetailInfoM GetOne(int Ing_StoreID)
        {
            StoreDetailInfoM model = new StoreDetailInfoM();
            string strSql = "SELECT * from T_StoreDetailInfo a where a.Ing_StoreID=@Ing_StoreID";

            this.Sqlca.AddParameter("@Ing_StoreID",Ing_StoreID);

            model = this.GetQueryM<StoreDetailInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();

            return model;
        }

        /// <summary>
        /// ��ȡ�ڲ�ѯ�Ƶ��б��õ�����Ϣ
        /// </summary>
        /// <param name="storeids"></param>
        /// <returns></returns>
        public List<DetailInfoInListM> GetList(string storeids)
        {
            string strSql = "SELECT a.Ing_StoreID,a.str_Address,a.str_mapX,a.str_mapY FROM dbo.T_StoreDetailInfo a WHERE a.Ing_StoreID IN ({0})";
            strSql = string.Format(strSql,storeids);

            return this.GetQueryM<DetailInfoInListM>(strSql);
        }
    }
}
