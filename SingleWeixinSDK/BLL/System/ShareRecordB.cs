using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShareRecordB
    {
        public DAL.ShareRecordD dal = new DAL.ShareRecordD();

        #region ��������
        public ShareRecordB() { }

        /// <summary>
        /// ��ѯ����΢�ŷ���
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetAll()
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetAllM<ShareRecordM>();
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����������ѯ΢�ŷ���
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetSearch(string strwhere)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetQueryM<ShareRecordM>(strwhere);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ѯһ��ָ���ļ�¼:΢�ŷ���
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Get(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetM<ShareRecordM>(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ӻ����޸ļ�¼:΢�ŷ���
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrUpdate(ShareRecordM model)
        {
            BaseResponseModel response =new BaseResponseModel();
            bool rev = dal.SaveOrUpdate(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;

        }


        /// <summary>
        /// ɾ����¼:΢�ŷ���
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


        #region ��ӷ����¼
        /// <summary>
        /// ��ӷ����¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddShare(ShareRecordM model)
        {
            return dal.AddShare(model);
        }

        #endregion
    }
}
