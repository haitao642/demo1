using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model
{
    /// <summary>
    /// ��Ա����Ϣ
    /// </summary>
    public class VipCardInfoM
    {
        ///<summary>
        ///Ing_Pk_VipCardId
        /// </summary>
        public int Ing_Pk_VipCardId {get;set;}

        ///<summary>
        ///��Ա����
        /// </summary>
        public string str_VipCard {get;set;}

        ///<summary>
        ///Ing_Fk_VipID
        /// </summary>
        public int Ing_Fk_VipID {get;set;}

        ///<summary>
        ///��Ա������
        /// </summary>
        public int Ing_VipCardType {get;set;}

        ///<summary>
        ///��Ա����������
        /// </summary>
        public string str_CardTypeName { get; set; }

        ///<summary>
        ///�ܹ�����
        /// </summary>
        public int Ing_TotalIntegral {get;set;}

        ///<summary>
        ///���ѻ���
        /// </summary>
        public int Ing_ExchangeIntegral {get;set;}

        ///<summary>
        ///�����û���
        /// </summary>
        public int Ing_SurplusIntegral {get;set;}

        ///<summary>
        ///���
        /// </summary>
        public decimal dec_SurplusMoney {get;set;}

        ///<summary>
        ///��ҹ����
        /// </summary>
        public decimal dec_RoomNightScore {get;set;}

        ///<summary>
        ///�ӵ㷿��ס����
        /// </summary>
        public int Ing_ClockRoomCount {get;set;}

        ///<summary>
        ///��Ч����
        /// </summary>
        public DateTime? dt_EffectiveDate {get;set;}

        ///<summary>
        ///ʧЧ����
        /// </summary>
        public DateTime? dt_ExpirationDate {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_SleepDate {get;set;}

        ///<summary>
        ///����Ա
        /// </summary>
        public string str_Seller {get;set;}

        ///<summary>
        ///���ŷ�ʽ
        /// </summary>
        public int Ing_SendType {get;set;}

        ///<summary>
        ///�����Ƶ�
        /// </summary>
        public string str_CardHotel {get;set;}

        ///<summary>
        ///��Ա��״̬ 1Ϊ��Ч ��-1 Ϊδ���0Ϊͣ�� ��2 Ϊ���ߡ�3Ϊע����4��ʧ
        /// </summary>
        public int Ing_VipCardSta {get;set;}

        /// <summary>
        /// ״̬����
        /// </summary>
        public string str_VipCardSta
        {
            get {
                string rev = "";
                switch (Ing_VipCardSta)
                { 
                    case -1:
                        rev = "δ����";
                        break;
                    case 0:
                        rev = "ͣ��";
                        break;
                    case 1:
                        rev = "��Ч";
                        break;
                    case 2:
                        rev = "����";
                        break;
                    case 3:
                        rev = "ע��";
                        break;
                    case 4:
                        rev = "��ʧ";
                        break;
                }
                return rev;
            }
        }

        ///<summary>
        ///��ͽ��
        /// </summary>
        public decimal dec_LimitMoney {get;set;}

        ///<summary>
        ///��֤��
        /// </summary>
        public decimal? dec_Margin {get;set;}

        ///<summary>
        ///�Ƿ��м����� 1��ʾ�� 0 ��ʾû��
        /// </summary>
        public int? Ing_HotelAccount {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_remark {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int? Ing_Seq {get;set;}

        ///<summary>
        ///�����ù�
        /// </summary>
        public string str_HotelID {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_CreateTime {get;set;}

        ///<summary>
        ///str_ptrv
        /// </summary>
        public string str_ptrv {get;set;}

        ///<summary>
        ///str_easyflag
        /// </summary>
        public string str_easyflag {get;set;}

        ///<summary>
        ///str_GroupNo
        /// </summary>
        public string str_GroupNo {get;set;}

        ///<summary>
        ///dec_SetParm
        /// </summary>
        public decimal? dec_SetParm {get;set;}

        ///<summary>
        ///str_VGroupNo
        /// </summary>
        public string str_VGroupNo {get;set;}

        ///<summary>
        ///dec_PayMoney
        /// </summary>
        public decimal? dec_PayMoney {get;set;}

        ///<summary>
        ///dt_PayTime
        /// </summary>
        public DateTime? dt_PayTime {get;set;}

        ///<summary>
        ///1
        /// </summary>
        public string str_SendCoupon {get;set;}

        ///<summary>
        ///str_OldSendCoupon
        /// </summary>
        public string str_OldSendCoupon {get;set;}

        ///<summary>
        ///dec_PersentMoney
        /// </summary>
        public decimal? dec_PersentMoney {get;set;}

        ///<summary>
        ///��¼����
        /// </summary>
        public string str_loginPwd {get;set;}

        ///<summary>
        ///str_wcopenid
        /// </summary>
        public string str_wcopenid {get;set;}

        /// <summary>
        /// ��΢��ʱ��
        /// </summary>
        public DateTime? dt_BindWeChat { get; set; }

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///����ԱID
        /// </summary>
        public int Ing_Pk_SaleUID { get; set; }



        /// <summary>
        /// ��Ա��һ����ס��������
        /// </summary>
        public int? Ing_FirstMaster { get; set; }


        /// <summary>
        /// �û�Ա�������Ƿ�μ���ס�
        /// </summary>
        public int Ing_FirstCheck { get; set; }

        /// <summary>
        /// �ܷ�μ���ס�ľ������
        /// </summary>
        public string str_First
        {
            get {
                string rev = string.Empty;
                if (Ing_FirstCheck == 0)
                {
                    rev = "��";
                    return rev;
                }

                int masid=0;
                if (Ing_FirstMaster.HasValue)
                {
                    masid = Ing_FirstMaster.Value;
                }

                if (masid == 0)
                {
                    rev = "��,δ����";
                }
                else if (masid == 1)
                {
                    rev = "��";
                }
                else if (masid > 1)
                {
                    rev = "��,�����ܣ�����idΪ��"+masid.ToString();
                }

               return rev;
            }
        }

        /// <summary>
        /// �ֻ�
        /// </summary>
        public string str_mobile{get;set;}

        /// <summary>
        /// ����
        /// </summary>
        public string str_CusName{get;set;}

        /// <summary>
        /// ���֤��
        /// </summary>
        public string str_ident{get;set;}

        /// <summary>
        /// ��ֵ֧������
        /// </summary>
        public string str_paypassword { get;set; }

        /// <summary>
        /// ΢��Ǯ�����
        /// </summary>
        public decimal dec_WechatPrice { get; set; }

        /// <summary>
        /// ΢��unionid
        /// </summary>
        public string str_Unionid { get; set; }

        /// <summary>
        /// ����id
        /// </summary>
        public int Ing_Pk_CustID { get; set; }
        /// <summary>
        /// �Ƿ���ȡ����ң�����Ż�ȯ
        /// </summary>
        public int Ing_SHActivity { get; set; }

    }

    /// <summary>
    /// ��ֵ֧��������֤
    /// </summary>
    public class VerifyPayPWDM
    {
        /// <summary>
        /// ��ֵ֧������,���ܹ���                                             
        /// </summary>
        public string str_paypassword { get; set; }


        /// <summary>
        /// �û�����Ĵ�ֵ֧������
        /// </summary>
        public string str_pwd { get; set; }
    }


    /// <summary>
    /// �󶨻���������Աʱ�����Ĳ���
    /// </summary>
    public class AddWeChatM
    {
        /// <summary>
        /// �ֻ���
        /// </summary>
        [Display(Name = "�ֻ���")]
        public string mobile { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Display(Name = "����")]
        public string cusname { get; set; }

        /// <summary>
        /// ���֤��
        /// </summary>
        public string ident { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// ��Ա��ID
        /// </summary>
        public int VipCardID { get; set; }

        /// <summary>
        /// ͷ���ַ
        /// </summary>
        public string headerimg { get; set; }

        /// <summary>
        /// ��˾ͷ���ַ
        /// </summary>
        public string companyimg { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// �ǳ�
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// �û��������֤��
        /// </summary>
        public string yzcode { get; set; }

        /// <summary>
        /// ϵͳ����֤��
        /// </summary>
        public string yzcode1 { get; set; }

        /// <summary>
        /// �ŵ�id
        /// </summary>
        public int StoreID { get; set; }

        /// <summary>
        /// �ŵ�����
        /// </summary>
        public string Str_StoreName { get; set; }

        /// <summary>
        /// �󶨳ɹ���ķ��ص�ַ
        /// </summary>
        public string rawurl { get; set; }

        /// <summary>
        /// unionid
        /// </summary>
        public string unionid { get; set; }
    }

    /// <summary>
    /// �޸Ĵ�ֵ�����õ��Ĳ���
    /// </summary>
    public class UpdatePayPasswordM
    {
        /// <summary>
        /// �ֻ���
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// ��Ա��ID
        /// </summary>
        public int VipCardID { get; set; }

        /// <summary>
        /// �û��������֤��
        /// </summary>
        public string yzcode { get; set; }

        /// <summary>
        /// ϵͳ����֤��
        /// </summary>
        public string yzcode1 { get; set; }

        /// <summary>
        /// 0��ֵ֧��,1��Ա��¼
        /// </summary>
        public int type { get; set; }
    }


    /// <summary>
    /// ��Ա����ֵ������  �����Ĳ���
    /// </summary>
    public class ParaForVipCardChargeM
    {
        /// <summary>
        /// ��id
        /// </summary>
        public int Ing_Pk_VipCardID { get; set; }

        /// <summary>
        /// ����id
        /// </summary>
        public int Ing_Fk_MasterID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int chargeType { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public decimal chargemon { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Reamrk { get; set; }

        /// <summary>
        /// ���ͽ��
        /// </summary>
        public int SendMon { get; set; }

        /// <summary>
        /// ֧����ʽ
        /// </summary>
        public int PayType { get; set; }

        /// <summary>
        /// ���˵���
        /// </summary>
        public string str_CheckOutNo { get; set; }
    }


}