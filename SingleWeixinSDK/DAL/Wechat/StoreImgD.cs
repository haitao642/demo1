using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreImgD:BaseTable
    {
        public StoreImgD()
            : base("T_StoreImg", "Ing_PK_ImgID")
        {
            this.Sqlca = SqlcaWeChat();
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(StoreImgM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �ŵ�ͼƬ��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(StoreImgM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<StoreImgM>(model, model.Ing_PK_ImgID);
            model.Ing_PK_ImgID = this.lngKeyID;
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
        /// �õ��ŵ�ͼƬ
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public List<StoreImgM> GetStoreImgM(int Ing_StoreID)
        {
            string strSql = "SELECT * FROM T_StoreImg a WHERE a.Ing_StoreID=@Ing_StoreID";

            this.Sqlca.AddParameter("@Ing_StoreID",Ing_StoreID);

            List<StoreImgM> list = this.GetQueryM<StoreImgM>(strSql);
            this.Sqlca.ClearParameter();

            return list;
        }

        /// <summary>
        /// �������ͻ�ȡͼƬ
        /// </summary>
        /// <param name="storeids"></param>
        /// <param name="Ing_type">����1���Ƶ꣬2����,3����.4����</param>
        /// <returns></returns>
        public List<StoreImgM> GetStoreImgbytype(string storeids,int Ing_type)
        {
            string strSql = "SELECT * FROM dbo.T_StoreImg a WHERE a.Ing_StoreID IN ({0}) AND a.Ing_type={1}";

            strSql = string.Format(strSql,storeids,Ing_type);

            List<StoreImgM> list = this.GetQueryM<StoreImgM>(strSql);

            return list;
        }


        /// <summary>
        /// �������ͻ�ȡͼƬ
        /// </summary>
        /// <param name="storeids"></param>
        /// <param name="Ing_type">����1���Ƶ꣬2����,3����.4����</param>
        /// <returns></returns>
        public StoreImgM GetOneStoreImgbytype(int Ing_StoreID, int Ing_type)
        {
            string strSql = "SELECT * FROM dbo.T_StoreImg a WHERE a.Ing_StoreID ={0} AND a.Ing_type={1}";

            strSql = string.Format(strSql, Ing_StoreID, Ing_type);

            List<StoreImgM> list = this.GetQueryM<StoreImgM>(strSql);

            return list.FirstOrDefault();
        }

    }
}
