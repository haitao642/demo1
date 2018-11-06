using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentsB
    {
        public DAL.CommentsD dal = new DAL.CommentsD();

        #region ��������
        public CommentsB() { }

        /// <summary>
        /// ��ѯ�����û�����
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetAll()
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetAllM<CommentsM>();
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����������ѯ�û�����
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetSearch(string strwhere)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetQueryM<CommentsM>(strwhere);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ѯһ��ָ���ļ�¼:�û�����
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Get(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetM<CommentsM>(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ӻ����޸ļ�¼:�û�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrUpdate(CommentsM model)
        {
            BaseResponseModel response =new BaseResponseModel();
            bool rev = dal.SaveOrUpdate(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;

        }


        /// <summary>
        /// ɾ����¼:�û�����
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Delete(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();
            bool rev = dal.Delete(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }       
        #endregion

        /// <summary>
        /// ����������ȡ���ۼ�¼
        /// </summary>
        /// <param name="MasterID"></param>
        /// <returns></returns>
        public CommentsM GetRecordByMasID(int MasterID)
        {
            return dal.GetRecordByMasID(MasterID);
        }

        /// <summary>
        /// ��ȡһ��������Ϣ
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CommentsM GetOne(int ID)
        {
            return dal.GetM<CommentsM>(ID);
        }


        /// <summary>
        /// �õ��ŵ��ܵ�������
        /// </summary>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public int GetTotalByStoreID(int StoreID)
        {
            return dal.GetTotalByStoreID(StoreID);
        }


        /// <summary>
        /// �õ��ŵ��ܵĺ�����
        /// </summary>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public int GetGoodByStoreID(int StoreID)
        {
            return dal.GetGoodByStoreID(StoreID);
        }
        /// <summary>
        /// ��ȡ�Ƶ��ܵĺ���
        /// </summary>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public List<CommentsM> GetGoodRecordByStoreID(int StoreID)
        {
            return dal.GetGoodRecordByStoreID(StoreID);
        }
        }
}
