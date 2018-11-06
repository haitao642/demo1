using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AwardGoodsB
    {
        public DAL.AwardGoodsD dal = new DAL.AwardGoodsD();
        #region ��������
        public AwardGoodsB() { }

        /// <summary>
        /// ��ѯ���г齱��Ʒ��ȡ����
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetAll()
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetAllM<AwardGoodsM>();
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����������ѯ�齱��Ʒ��ȡ����
        /// </summary>
        /// <returns></returns>
        public BaseResponseModel GetSearch(string strwhere)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetQueryM<AwardGoodsM>(strwhere);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ѯһ��ָ���ļ�¼:�齱��Ʒ��ȡ����
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public BaseResponseModel Get(int pid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.GetM<AwardGoodsM>(pid);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ӻ����޸ļ�¼:�齱��Ʒ��ȡ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel SaveOrUpdate(AwardGoodsM model)
        {
            BaseResponseModel response =new BaseResponseModel();
            bool rev = dal.SaveOrUpdate(model);
            response.data = model;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;

        }


        /// <summary>
        /// ɾ����¼:�齱��Ʒ��ȡ����
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
        /// ����ĳ�˵Ľ�Ʒ
        /// </summary>
        /// <param name="VipcardID"></param>
        /// <returns></returns>
        public List<AwGoodModel> GetGoods(int VipcardID)
        {
            return dal.GetGoods(VipcardID);
        }
    }
}
