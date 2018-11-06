using Model;
using Model.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VipCardInfoB
    {
        public DAL.VipCardInfoD dal = new DAL.VipCardInfoD();

        
        /// <summary>
        /// ����openid��ȡ��Ա����¼
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public VipCardInfoM GetVipCardByopenID(string openid)
        {
            return dal.GetVipCardByopenID(openid);
        }
        /// <summary>
        /// ����openid��storeid��ȡ��Ա����¼
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public VipCardInfoM GetVipCardByStoreid(string openid,int storeid)
        {
            return dal.GetVipCardByStoreid(openid, storeid);
        }

        /// <summary>
        /// ����unionid��ȡ
        /// </summary>
        /// <param name="unionid"></param>
        /// <returns></returns>
        public VipCardInfoM GetVipCardByunionID(string unionid)
        {
            return dal.GetVipCardByunionID(unionid);
        }

        /// <summary>
        /// �����Ա��Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateVip(VipCardInfoM model) 
        {
            return dal.SaveOrUpdate(model);
        }

        /// <summary>
        /// ��ȡһ����Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VipCardInfoM GetOne(int id)
        {
            return dal.GetM<VipCardInfoM>(id);
        }

        /// <summary>
        /// �󶨻���������Ա
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="cusname"></param>
        /// <param name="openid"></param>
        /// <param name="yzcode">�û��������֤��</param>
        /// <param name="yzcode1">ϵͳ���͵���֤��   �ֻ�-��֤��   ��md5����</param>
        /// <returns></returns>
        public BaseResponseModel BindOrAddWeChat(string mobile, string cusname, string openid,string yzcode,string yzcode1,int StoreID,string ident)
        {
            BaseResponseModel response = new BaseResponseModel();
           bool rev= dal.BindOrAddWeChat(mobile, cusname, openid,yzcode,yzcode1,StoreID,ident);

           //if (rev)
           //{
           //    ///΢������
           //    BindSuccessM m1 = new BindSuccessM();
           //    m1.Openid = openid;
           //    m1.keyword1 = cusname;
           //    m1.remark = string.Format("�󶨵����ֻ�:{0},��Ǳ��ˣ�����ϵϵͳ����Ա",mobile);
           //    DAL.WeChatD weD = new DAL.WeChatD();
           //    weD.BindSuccessNotice(m1);
           //}
           response.data = rev;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ��΢�ŵ�ʱ�򣬷�����֤��
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public String WechatBindVirifyCode(string mobile,int yzcode,int storeid)
        {
            return  dal.WechatBindVirifyCode(mobile, yzcode,storeid);
           
        }
        /// <summary>
        /// ��֤��ֵ֧������
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public BaseResponseModel VirifyPwd(string pwd,int vipcardid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.VirifyPwd(pwd,vipcardid);
           
            return response;
        }
        /// <summary>
        /// �޸Ĵ�ֵ֧������
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public BaseResponseModel ChangePwd(string pwd, int vipcardid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.ChangePwd(pwd, vipcardid);

            return response;
        }
        /// <summary>
        /// �޸Ļ�Ա����
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public BaseResponseModel ChangeVipPwd(string pwd, int vipcardid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.ChangeVipPwd(pwd, vipcardid);

            return response;
        }
        /// <summary>
        /// ��֤��Ա����
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public BaseResponseModel VirifyVipPwd(string pwd, int vipcardid)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.VirifyVipPwd(pwd, vipcardid);

            return response;
        }
        /// <summary>
        /// ��ֵ����ʹ�ã�������֤��
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public BaseResponseModel UsePayPwdVirifyCode(string mobile)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.UsePayPwdVirifyCode(mobile);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// �޸Ĵ�ֵ֧������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel UpdatePayPassword(UpdatePayPasswordM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            bool rev = dal.UpdatePayPassword(model);

            if (rev)
            {
                ///΢������
            }
            response.data = rev;
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// �޸��ֻ�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel UpdateMobile(MyInfoM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.UpdateMobile(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// �����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel UnBind(UnBindM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.UnBind(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }
        public Boolean CreateSHCoupon(int vipCardInfoId)
        {
            return dal.CreateSHCoupon(vipCardInfoId);
        }
        /// <summary>
        /// ���ֶһ�����ȯ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel IntegralExchangeCoupon(WechatCouponM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.IntegralExchangeCoupon(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ���΢��֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel CheckWXPay(ParaForCoponPayM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.CheckWXPay(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����Ա��ס֧��
        /// </summary>
        /// <param name="model"></param>
        /// <param name="masM"></param>
        /// <param name="cardM"></param>
        /// <returns></returns>
        public bool CheckFirst(ParaForCoponPayM model, MasterM masM = null, VipCardInfoM cardM = null) 
        {
            return dal.CheckFirst(model,masM,cardM);
        }

        /// <summary>
        /// ΢��֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel WXPay(ParaForCoponPayM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.WXPay(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ��ֵ֧��ʱ����֤��ֵ֧������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel VerifyPayPWD(VerifyPayPWDM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.VerifyPayPWD(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }


        /// <summary>
        /// ��ȡ�̳ǻ�Ա
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShopVipcardM GetShopVipCard(ShopVipcardM model)
        {
            return dal.GetShopVipCard(model);
        }

        /// <summary>
        /// �޸Ļ�Ա��Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool EditUserInfo(ShopVipcardM model) 
        {
            return dal.EditUserInfo(model);
        }

        /// <summary>
        /// ������Ա
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShopVipcardM Rigister(ShopVipcardM model)
        {
            return dal.Rigister(model);
        }

        /// <summary>
        /// �����Ż�ȯ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseShopM DiscountGet(CreateCoupon model)
        {
            return dal.DiscountGet(model);
        }

        /// <summary>
        /// ��ȡ��ֵ/Ǯ��/������ϸ��Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShopVipTotalM GetVipDetail(ShopVipDeatilM model) 
        {
            return dal.GetVipDetail(model);
        }

        /// <summary>
        /// ��ȡ��Ա�����ͽӿ�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public VipCardBackM GetVipCardType(ShopVipDeatilM model) 
        {
            VipCardBackM mm = new VipCardBackM();
            mm.list= dal.GetVipCardType(model);
            mm.code="1";
            return mm;
        }

        
    }
}
