using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StoreDetailInfoB
    {
        public DAL.StoreDetailInfoD dal = new DAL.StoreDetailInfoD();

        public StoreDetailInfoB() { }


                /// <summary>
        /// �����ŵ�ID �����ŵ�����
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <returns></returns>
        public StoreDetailInfoM GetOne(int Ing_StoreID)
        {
            return dal.GetOne(Ing_StoreID);
        }


                /// <summary>
        /// ��ȡ�ڲ�ѯ�Ƶ��б��õ�����Ϣ
        /// </summary>
        /// <param name="storeids"></param>
        /// <returns></returns>
        public List<DetailInfoInListM> GetList(string storeids)
        {
            return dal.GetList(storeids);
        }
    }
}
