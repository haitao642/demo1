using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsD:BaseTable
    {
        public NewsD()
            : base("T_News", "Ing_NewsID")
        {
            this.Sqlca = this.SqlcaWeChat();
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(NewsM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �Զ�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(NewsM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<NewsM>(model, model.Ing_NewsID);
            model.Ing_NewsID = this.lngKeyID;
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
        /// ��ȡĳһ�������
        /// </summary>
        /// <param name="topnum">0:ȫ��  </param>
        /// <param name="Ing_FCaption">��������   31�� ������Ϣ</param>
        /// <returns></returns>
        public List<NewsM> GetNews(int topnum, int Ing_FCaption)
        {
            this.Sqlca = this.SqlcaWeChat();

            ///��ѯȫ�������Ǽ���
            string top = string.Empty;
            if (topnum > 0)
            {
                top = string.Format(" top {0}", topnum);
            }

            string strSql = @"SELECT {0} * from T_News a where a.Ing_FCaption=@Ing_FCaption and a.Ing_Del=1 AND a.Ing_Checked=1";
            strSql = string.Format(strSql, top);

            this.Sqlca.AddParameter("@Ing_FCaption", Ing_FCaption);

            List<NewsM> list = this.GetQueryM<NewsM>(strSql);
            this.Sqlca.ClearParameter();
            return list;
        }
    }
}
