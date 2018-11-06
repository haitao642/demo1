using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StoreImgB
    {
        public DAL.StoreImgD dal = new DAL.StoreImgD();

        public StoreImgB() { }


        /// <summary>
        /// �õ��ŵ�ͼƬ
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public List<StoreImgM> GetStoreImgM(int Ing_StoreID)
        {
            return dal.GetStoreImgM(Ing_StoreID);
        }


                /// <summary>
        /// �������ͻ�ȡͼƬ
        /// </summary>
        /// <param name="storeids"></param>
        /// <param name="Ing_type">����1���Ƶ꣬2����,3����.4����</param>
        /// <returns></returns>
        public List<StoreImgM> GetStoreImgbytype(string storeids, int Ing_type)
        {
            return dal.GetStoreImgbytype(storeids, Ing_type);
        }

         /// <summary>
        /// �������ͻ�ȡͼƬ
        /// </summary>
        /// <param name="storeids"></param>
        /// <param name="Ing_type">����1���Ƶ꣬2����,3����.4����</param>
        /// <returns></returns>
        public StoreImgM GetOneStoreImgbytype(int Ing_StoreID, int Ing_type)
        {
            return dal.GetOneStoreImgbytype(Ing_StoreID, Ing_type);
        }
    }
}
