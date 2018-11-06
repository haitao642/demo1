using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SMSBaseD:BaseTable
    {
        public SMSBaseD()
            : base("T_SMSBase", "Ing_pk_sd")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(SMSBaseM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(SMSBaseM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<SMSBaseM>(model, model.Ing_pk_sd);
            model.Ing_pk_sd = this.lngKeyID;
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
        /// ȡһ����������
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="str_SMSType"></param>
        /// <returns></returns>
        public SMSBaseM GetSMSBaseOneM(int Ing_StoreID, string str_SMSType)
        {
            string strSql = @"SELECT * from T_SMSBase a where ISNULL(a.Ing_StoreID,0)={0} AND a.str_SMSType='{1}'";
            strSql = string.Format(strSql, Ing_StoreID, str_SMSType);

            return this.GetQueryM<SMSBaseM>(strSql).FirstOrDefault();
        }

        /// <summary>
        /// ȡ���ŷ���ģ��
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="str_SMSType"></param>
        /// <returns></returns>
        public string GetUserFulContent(int Ing_StoreID, string str_SMSType)
        {
            SMSBaseM BaseM = new SMSBaseM();
            BaseM = this.GetSMSBaseOneM(Ing_StoreID, str_SMSType);
            if (BaseM == null)
            {
                return string.Empty;
            }

            if (!BaseM.Ing_sta.HasValue)
            {
                return string.Empty;
            }

            if (BaseM.Ing_sta.Value != 1)
            {
                return string.Empty;
            }
            return BaseM.str_SMSContent;
        }
    }
}
