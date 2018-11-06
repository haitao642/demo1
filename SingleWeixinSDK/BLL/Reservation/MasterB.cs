using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MasterB
    {
        public DAL.MasterD dal = new DAL.MasterD();


        /// <summary>
        /// ��ȡһ��
        /// </summary>
        /// <param name="masid"></param>
        /// <returns></returns>
        public MasterM GetOne(int masid)
        {
            return dal.GetM<MasterM>(masid);
        }

        /// <summary>
        /// ����openid��ȡ�����б�
        /// </summary>
        /// <param name="topnum"></param>
        /// <param name="openid"></param>
        /// <returns></returns>
        public List<OrderM> GetOrderListByOpenid(int topnum, string openid)
        {
            return dal.GetOrderListByOpenid(topnum, openid);
        }

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="vipcardid">vipcardid</param>
        /// <param name="type">1: ��ס Ԥ�� ����,΢��Ԥ�����ӵ㷿    0�����   2��ȡ��</param>
        /// <returns></returns>
        public List<OrderM> GetOrderbycardid(int vipcardid, int type)
        {
            return dal.GetOrderbycardid(vipcardid, type);
        }


        /// <summary>
        /// ��ȡ���۵�������¼
        /// </summary>
        /// <param name="MasterID"></param>
        /// <returns></returns>
        public OrderM GetCommentRecordByMasID(int MasterID)
        {
            return dal.GetCommentRecordByMasID(MasterID);
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="MasterID"></param>
        /// <returns></returns>
        public BaseResponseModel UpdateX(cancelOrderM model)
        {
            BaseResponseModel response = new BaseResponseModel();
            bool rev = dal.UpdateX(model);
            response.data = rev;            

            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// �õ�Ĭ�Ϸ�����
        /// </summary>
        /// <param name="time"></param>
        /// <param name="lngvipcardid"></param>
        /// <returns></returns>
        public RoomRateDefaultM GetRoomRateDefault(int Ing_StoreID, DateTime time, int lngvipcardid)
        {
            return dal.GetRoomRateDefault(Ing_StoreID, time, lngvipcardid);
        }


        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="time"></param>
        /// <param name="lngvipcardid"></param>
        /// <returns></returns>
        public RoomRateM GetRoomRate(int Ing_StoreID, DateTime time, string roomtype, string roomrate, int lngvipcardid)
        {
            return dal.GetRoomRate(Ing_StoreID, time, roomtype, roomrate, lngvipcardid);
        }


                /// <summary>
        /// ɢ��Ԥ����Ŀ��÷��������С����
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="typecode"></param>
        /// <returns></returns>
        public List<RoomCanUseM> GetRoomCanUse(int Ing_StoreID, DateTime date1, DateTime date2, string typecode)
        {
            return dal.GetRoomCanUse(Ing_StoreID, date1, date2, typecode);
        }


        /// <summary>
        /// ����Ԥ��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrder(WriteOrderM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.SaveOrder(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

         /// <summary>
        /// ����openid����ȡ����Ա��Ӧ�Ĳ���ԱID
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public int GetSaleIDbyopenid(string openid)
        {
            return dal.GetSaleIDbyopenid(openid);
        }


        /// <summary>
        /// ��ס����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel ContinueInter(ContinueInterDisplay model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.ContinueInter(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ѡ���˷�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveTuiFang(SelectContinueM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.SaveTuiFang(model.Ing_MasterID);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ��ס��ȡ���跿��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public decimal GetRoomPriceById(ContinueInterDisplay model) 
        {
            return dal.GetRoomPriceById(model);
        }
    }
}
