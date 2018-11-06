using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CouponTypeD:BaseTable
    {
        public CouponTypeD()
            : base("T_CouponType", "Ing_CouponTypeID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(CouponTypeM model)
        {         
   
           //��ѯ�Ƿ��ظ�
            List<CouponTypeM> coupTypeModel = this.GetAllM<CouponTypeM>();
            CouponTypeM  c= coupTypeModel.Where(a => a.str_SendType.Equals(model.str_SendType) || a.str_PaperName.Equals(model.str_PaperName)).FirstOrDefault();
            if (c != null)
            {
                this.LastError="L�������߻�����ظ�";
                return false;
            }


            return true;
        }

        /// <summary>
        /// ���� �Ż�ȯ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(CouponTypeM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
          
            bool rev= this.UpdateRecord<CouponTypeM>(model, model.Ing_CouponTypeID);
            model.Ing_CouponTypeID = this.lngKeyID;
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
        /// ��ȡ΢�Ŷ�  ���ֶһ�����ȯ�Ļ
        /// </summary>
        /// <returns></returns>
        public CouponTypeM GetWechatType(string str="")
        {
            if (string.IsNullOrEmpty(str)) 
            {
                str = ConfigValue.WeChatCard;
            }
            string strSql = "SELECT top 1 * FROM dbo.T_CouponType a WHERE a.str_SendType='{0}' ORDER by a.Ing_CouponTypeID DESC";
            strSql = string.Format(strSql,str);

            return this.GetQueryM<CouponTypeM>(strSql).FirstOrDefault();
        }
    }
}
