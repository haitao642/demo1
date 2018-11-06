using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WechatPositionD:BaseTable
    {
        public WechatPositionD()
            : base("T_WechatPosition", "Ing_PositionID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(WechatPositionM model)
        {
            if (model == null)
            {
                this.LastError = "L����Ϊ��";
                return false;
            }
            if (string.IsNullOrEmpty(model.openid))
            {
                //this.LastError = "LopenidΪ����";
                return false;
            }
            return true;
        }

        /// <summary>
        /// ���� ΢������λ�ñ�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(WechatPositionM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }

            WechatPositionM res = GetPositionByopenid(model.openid);
            if (res != null)
            {
                model.Ing_PositionID = res.Ing_PositionID;
            }
            model.dt_Create = DateTime.Now;

            bool rev= this.UpdateRecord<WechatPositionM>(model, model.Ing_PositionID);
            model.Ing_PositionID = this.lngKeyID;
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
        /// ����openid��ȡλ����Ϣ
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public WechatPositionM GetPositionByopenid(string openid)
        {
            string strSql = "select top 1 * from T_WechatPosition a where a.openid=@openid";
            this.Sqlca.AddParameter("@openid",openid);

            WechatPositionM model = new WechatPositionM();
            model = this.GetQueryM<WechatPositionM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();

            return model;
        }
    }
}
