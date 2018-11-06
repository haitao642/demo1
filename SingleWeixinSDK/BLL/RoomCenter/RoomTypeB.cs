using Model;
using Model.RoomCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoomTypeB
    {
        public DAL.RoomTypeD dal = new DAL.RoomTypeD();

        /// <summary>
        /// ��ȡһ��
        /// </summary>
        /// <param name="RoomTypeID"></param>
        /// <returns></returns>
        public RoomTypeM GetOne(int RoomTypeID)
        {
            return dal.GetM<RoomTypeM>(RoomTypeID);
        }

        /// <summary>
        /// ��ȡ��Ч������
        /// </summary>
        /// <returns></returns>
        public List<RoomTypeM> GetUseFulList(int Ing_StoreID)
        {
            return dal.GetUseFulList(Ing_StoreID);
        }

        /// <summary>
        /// ��ȡ���ͺͼ۸�
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="dtarr"></param>
        /// <returns></returns>
        public List<RoomType1M> GetUseFulList(int Ing_StoreID, DateTime dtarr)
        {
            return dal.GetUseFulList(Ing_StoreID, dtarr);
        }
        /// <summary>
        /// ��ȡ����ͼƬ
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="strRoomTypeCode"></param>
        /// <returns></returns>
        public List<StoreImgM> GetRoomTypeImg(int Ing_StoreID, string strRoomTypeCode)
        {
            return dal.GetRoomTypeImg(Ing_StoreID,strRoomTypeCode);
        }

        /// <summary>
        /// ��ȡ�ӵ㷿�ͺͼ۸�
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="dtarr"></param>
        /// <returns></returns>
        public List<RoomType1M> GetUseFulHourList(int Ing_StoreID, DateTime dtarr)
        {
            return dal.GetUseFulHourList(Ing_StoreID, dtarr);
        }


        /// <summary>
        /// �����ŵ�ͷ����Ҽ�¼
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="typecode"></param>
        /// <returns></returns>
        public RoomTypeM GetRoomType(int Ing_StoreID, string typecode)
        {
            return dal.GetRoomType(Ing_StoreID, typecode);
        }
        /// <summary>
        /// ����������ȡ����
        /// </summary>
        /// <param name="masterid"></param>
        /// <returns></returns>
        public RoomTypeM GetRoomType(int masterid)
        {
            DAL.MasterD masD = new DAL.MasterD();
            MasterM masM = masD.GetM<MasterM>(masterid);
            if (masM == null || string.IsNullOrEmpty(masM.str_RoomType))
            {
                return null;
            }
            return dal.GetRoomType(masM.Ing_StoreID ?? 0, masM.str_RoomType);
        }
    }
}
