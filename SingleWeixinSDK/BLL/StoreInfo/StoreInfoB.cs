using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StoreInfoB
    {
        public DAL.StoreInfoD dal = new DAL.StoreInfoD();


        /// <summary>
        /// �õ�һ���ŵ�
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public StoreInfoM GetOne(int Ing_StoreID)
        {
            return dal.GetM<StoreInfoM>(Ing_StoreID);
        }

         /// <summary>
        /// ���ݳ��л�ȡ�ŵ�
        /// </summary>
        /// <param name="strcity"></param>
        /// <returns></returns>
        public List<StoreM> GetStoreListbycity(string strcity)
        {
            return dal.GetStoreListbycity(strcity);
        }

        /// <summary>
        /// ���ݾƵ�id�ͷ��������ͻ�ȡ�ܺ��id
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public OutStoreInfoM ConvertStoreID(RequestParamModel param)
        {
            return dal.ConvertStoreID(param);
        }
        /// <summary>
        /// ���ݳ��л�ȡ�ӵ㷿Ԥ�����ŵ�
        /// </summary>
        /// <param name="strcity"></param>
        /// <returns></returns>
        public List<StoreM> GetStoreListHourbycity(string strcity)
        {
            return dal.GetStoreListHourbycity(strcity);
        }

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <returns></returns>
        public List<string> GetCityList()
        {
            return dal.GetCityList();
        }

                /// <summary>
        /// ��ȡ�����ŵ���Ϣ
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public StoreM GetStore(int Ing_StoreID)
        {
            return dal.GetStore(Ing_StoreID);
        }
        public String GetStoreHeaderImg(int Ing_StoreID)
        {
            return dal.GetStoreHeaderImg(Ing_StoreID);
        }
        public List<StoreImgM> GetStoreImg(int Ing_StoreID)
        {
            return dal.GetStoreImg(Ing_StoreID);
        }
         
    }
}
