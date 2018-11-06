using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WechatHisB
    {
        public DAL.WechatHisD dal = new DAL.WechatHisD();

        #region ��������
        public WechatHisB() { }

        /// <summary>
        /// ��ѯ����΢���¼���¼��
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetAll()
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetAllM<WechatHisM>();
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����������ѯ΢���¼���¼��
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetSearch(string strwhere)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetQueryM<WechatHisM>(strwhere);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ѯһ��ָ���ļ�¼:΢���¼���¼��
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Get(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetM<WechatHisM>(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ӻ����޸ļ�¼:΢���¼���¼��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrUpdate(WechatHisM model)
        {
            BaseResponseModel response =new BaseResponseModel();
            bool rev = dal.SaveOrUpdate(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;

        }


        /// <summary>
        /// ɾ����¼:΢���¼���¼��
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
    }
}
