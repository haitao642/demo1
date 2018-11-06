using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommentsD:BaseTable
    {
        public CommentsD()
            : base("T_Comments", "Ing_Pk_comID")
        {
            
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(CommentsM model)
        {
            CommentsM m = GetRecordByMasID(model.Ing_MasterID);
            if (m != null)
            {
                this.LastError = "L�Ѿ����۹��������ٴ�����";
                return false;
            }
            return true;
        }

        /// <summary>
        /// ���� �û�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(CommentsM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            model.dt_comDate=DateTime.Now;
            bool rev= this.UpdateRecord<CommentsM>(model, model.Ing_Pk_comID);
            model.Ing_Pk_comID = this.lngKeyID;
            ///�������ʧ�ܣ��Ͳ���������Ϣ��
            if (!rev)
            {
                return rev;
            }

            ParaForVipCardChargeM mod = new ParaForVipCardChargeM();
            mod.Ing_Pk_VipCardID = model.Ing_VipcardID;
            mod.chargemon = 50;
            mod.chargeType = 25;
            mod.Reamrk = "΢�������ͻ���";
            VipCardInfoD cardD = new VipCardInfoD();
            cardD.VipCardChargeExec(mod);


            ///����������⣬���� û����д����ģ��Ͳ���������Ϣ��
            if (model.Ing_total == 0 && string.IsNullOrEmpty(model.str_good) && string.IsNullOrEmpty(model.str_bad))
            {
                return rev;
            }

            UsersGrpD dal1 = new UsersGrpD();
            List<UsersGrpM> list = dal1.GetManagerByStoreID(model.Ing_StoreID);
            ///���û����Ϣ������Ա����ֱ�ӷ���
            if (list == null || list.Count == 0)
            {
                return rev;
            }

            WeChatQuestionM m1 = new WeChatQuestionM();
            WeChatD weD = new WeChatD();
            m1.serviceInfo = "����Ͻ���ŵ���һ���µ�����";
            m1.serviceType = "Ͷ�߽���";
            m1.serviceStatus = "���ύ";
            m1.CommentID = model.Ing_Pk_comID;
            string remark = string.Empty;
            remark = string.Format("{0}����",model.Ing_total==0?"":"��");
            if (!string.IsNullOrEmpty(model.str_good))
            {
                remark = string.Format("{0}\\r�ŵ㣺{1}", remark, model.str_good);
            }
            if (!string.IsNullOrEmpty(model.str_bad))
            {
                remark = string.Format("{0}\\r���飺{1}", remark, model.str_bad);
            }
            m1.remark = string.Format("{0}\\r������лظ�", remark);

            foreach (UsersGrpM m in list)
            {
                m1.Openid = m.str_openid;
                weD.OrderComment(m1);
            }
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
        /// ����������ȡ���ۼ�¼
        /// </summary>
        /// <param name="MasterID"></param>
        /// <returns></returns>
        public CommentsM GetRecordByMasID(int MasterID)
        {
            string strSql = "SELECT * FROM dbo.T_Comments a WHERE ISNULL(a.Ing_MasterID,0)={0}";
            strSql = string.Format(strSql,MasterID);

            return this.GetQueryM<CommentsM>(strSql).FirstOrDefault();
        }
        /// <summary>
        /// ��ȡ�Ƶ��ܵĺ���
        /// </summary>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public List<CommentsM> GetGoodRecordByStoreID(int StoreID)
        {
            //string strSql = "SELECT * FROM dbo.T_Comments a WHERE ISNULL(a.Ing_StoreID,0)={0} AND ISNULL(a.Ing_total,0)=0 AND ISNULL(a.Ing_del,0)=0 order by Ing_Pk_comID desc";
            string strSql = "SELECT * FROM dbo.T_Comments a WHERE ISNULL(a.Ing_StoreID,0)={0} AND ISNULL(a.Ing_del,0)=0 order by Ing_Pk_comID desc";
            strSql = string.Format(strSql, StoreID);
            return this.GetQueryM<CommentsM>(strSql);
        }
        /// <summary>
        /// �õ��ŵ��ܵ�������
        /// </summary>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public int GetTotalByStoreID(int StoreID)
        {
            string strSql = "SELECT COUNT(*) FROM dbo.T_Comments a WHERE ISNULL(a.Ing_StoreID,0)={0} AND ISNULL(a.Ing_del,0)=0";
            strSql = string.Format(strSql,StoreID);
            return this.Sqlca.GetInt32(strSql);
        }


        /// <summary>
        /// �õ��ŵ��ܵĺ�����
        /// </summary>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public int GetGoodByStoreID(int StoreID)
        {
            string strSql = "SELECT COUNT(*) FROM dbo.T_Comments a WHERE ISNULL(a.Ing_StoreID,0)={0} AND ISNULL(a.Ing_total,0)=0 AND ISNULL(a.Ing_del,0)=0";
            strSql = string.Format(strSql, StoreID);
            return this.Sqlca.GetInt32(strSql);
        }
    }
}
