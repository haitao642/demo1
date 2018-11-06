using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WxPayResultB
    {
        public DAL.WxPayResultD dal = new DAL.WxPayResultD();

        #region ��������
        public WxPayResultB() { }

        /// <summary>
        /// ��ѯ����΢��֧�������
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetAll()
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetAllM<WxPayResultM>();
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����������ѯ΢��֧�������
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetSearch(string strwhere)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetQueryM<WxPayResultM>(strwhere);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ѯһ��ָ���ļ�¼:΢��֧�������
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Get(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetM<WxPayResultM>(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ӻ����޸ļ�¼:΢��֧�������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrUpdate(WxPayResultM model)
        {
            BaseResponseModel response =new BaseResponseModel();
            bool rev = dal.SaveOrUpdate(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;

        }


        /// <summary>
        /// ɾ����¼:΢��֧�������
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
        /// �������ͺͶ�Ӧ������id��ѯ��¼   ֧���ɹ��ļ�¼
        /// </summary>
        /// <param name="Ing_type"></param>
        /// <param name="Ing_pkid"></param>
        /// <returns></returns>
        public WxPayResultM GetMoelBypid(int Ing_type, int Ing_pkid)
        {
            return dal.GetMoelBypid(Ing_type, Ing_pkid);
        }


        /// <summary>
        /// ֧���ɹ���Ĳ���
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel AddPayResult(WxPayResultM model)
        {
            BaseResponseModel response = new BaseResponseModel();
            bool rev = dal.AddPayResult(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }
    }
}
