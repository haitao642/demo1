using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WxChargeMonB
    {
        public DAL.WxChargeMonD dal = new DAL.WxChargeMonD();

        #region ��������
        public WxChargeMonB() { }
        

        /// <summary>
        /// ��ѯ����΢�Ŵ�ֵ��ֵ���ͱ�
        /// </summary>
        /// <returns></returns>
        public List<WxChargeMonM> GetAll()
        {
            return dal.GetAll();
        }
        public WxChargeMonM GetByid(int Ing_Pk_id)
        {
            return dal.GetByid(Ing_Pk_id);
        }
        /// <summary>
        /// ȫ����¼
        /// </summary>
        /// <returns></returns>
        public List<WxChargeMonM> GetAllM()
        {
            List<WxChargeMonM> list = dal.GetAllM<WxChargeMonM>().OrderBy(x=>x.Ing_order).ToList();
            return list;
        }

        /// <summary>
        /// ����������ѯ΢�Ŵ�ֵ��ֵ���ͱ�
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetSearch(string strwhere)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetQueryM<WxChargeMonM>(strwhere);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ѯһ��ָ���ļ�¼:΢�Ŵ�ֵ��ֵ���ͱ�
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Get(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetM<WxChargeMonM>(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ӻ����޸ļ�¼:΢�Ŵ�ֵ��ֵ���ͱ�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrUpdate(WxChargeMonM model)
        {
            BaseResponseModel response =new BaseResponseModel();
            bool rev = dal.SaveOrUpdate(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;

        }


        /// <summary>
        /// ɾ����¼:΢�Ŵ�ֵ��ֵ���ͱ�
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
