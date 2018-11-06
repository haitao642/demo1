using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComDetailD:BaseTable
    {
        public ComDetailD()
            : base("T_ComDetail", "Ing_DetailID")
        {
            this.Sqlca = this.SqlcaWeChat();
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(ComDetailM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �ͻ��Ľ��ȸ��ٱ�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(ComDetailM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<ComDetailM>(model, model.Ing_DetailID);
            model.Ing_DetailID = this.lngKeyID;
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
        /// ��������id��ȡ�����б�
        /// </summary>
        /// <param name="comid"></param>
        /// <returns></returns>
        public List<ComDetailM> GetList(int comid)
        {
            string strSql = "SELECT * FROM T_ComDetail a WHERE a.Ing_ComID={0} ORDER BY a.dt_com desc";
            strSql = string.Format(strSql,comid);

            return this.GetQueryM<ComDetailM>(strSql);
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveDetail(ComDetailM model)
        {
            if (model == null)
            {
                this.LastError = "L��������";
                return false;
            }            
            model.dt_Com = DateTime.Now;
            if (model.Ing_UserID > 0)
            {
                model.Ing_Result = null;
                if (string.IsNullOrEmpty(model.str_Result))
                {
                    this.LastError = "L����д���ݣ��ٽ��лظ�";
                    return false;
                }
            }
            if (!this.UpdateRecord<ComDetailM>(model, model.Ing_DetailID))
            {
                this.LastError = "L��������";
                return false;
            }

            if (string.IsNullOrEmpty(model.openids))
            {
                return true;
            }

            List<string> list = model.openids.Split(',').ToList();
            if (list.Count == 0)
            {
                return true;
            }

            WeChatQuestionM m1 = new WeChatQuestionM();
            WeChatD weD = new WeChatD();
            string remark = string.Empty;
            if (model.Ing_UserID == 0)
            {
                if ((model.Ing_Result.HasValue && model.Ing_Result.Value == 0) && string.IsNullOrEmpty(model.str_Result))
                {
                    return true;
                }
                m1.serviceInfo = "����Ͻ���ŵ���һ���µĿ�������";
                m1.serviceType = "Ͷ�߽���";
                m1.serviceStatus = "�ٴ��ύ";
                m1.CommentID = model.Ing_ComID ?? 0;
                remark = string.Format("{0}����", (model.Ing_Result.HasValue && model.Ing_Result.Value == 0) ? "" : "��");
                if (!string.IsNullOrEmpty(model.str_Result))
                {
                    remark = string.Format("{0}\\r���ݣ�{1}", remark, model.str_Result);
                }
                m1.remark = string.Format("{0}\\r������лظ�", remark);
            }
            else
            {
                m1.serviceInfo = "����һ���µĵ곤�ظ�";
                m1.serviceType = "����ظ�";
                m1.serviceStatus = "�ظ�";
                m1.CommentID = model.Ing_ComID ?? 0;
                if (!string.IsNullOrEmpty(model.str_Result))
                {
                    remark = string.Format("{0}���ݣ�{1}", remark, model.str_Result);
                }
                m1.remark = string.Format("{0}\\r������лظ�", remark);
            }

            foreach (string m in list)
            {
                m1.Openid = m;
                weD.OrderComment(m1);
            }

            return true;
        }
    }
}
