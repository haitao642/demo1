using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserCommentsD:BaseTable
    {
        public UserCommentsD()
            : base("T_UserComments", "Ing_PK_comID")
        {
            this.Sqlca = SqlcaWeChat();        
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(UserCommentsM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �û�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(UserCommentsM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<UserCommentsM>(model, model.Ing_PK_comID);
            model.Ing_PK_comID = this.lngKeyID;
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
        /// �õ��ŵ������б�
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public List<UserCommentsM> GetCommentbyStoreID(int Ing_StoreID)
        {
            string strSql = "select * from T_UserComments a WHERE a.Ing_StoreID=@Ing_StoreID ORDER by a.Ing_PK_comID DESC";
            this.Sqlca.AddParameter("@Ing_StoreID",Ing_StoreID);
            List<UserCommentsM> list = this.GetQueryM<UserCommentsM>(strSql); 

            this.Sqlca.ClearParameter();


            return list;
        }
    }
}
