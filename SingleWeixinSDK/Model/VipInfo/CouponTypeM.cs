using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_CouponType
    /// </summary>
    public class CouponTypeM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_CouponTypeID {get;set;}

        ///<summary>
        ///�ܵĽ��
        /// </summary>
        public decimal? dec_Amount {get;set;}

        ///<summary>
        ///�Ż�ȯ��10|20 ��ʾ����һ��10�� һ��20�ģ�  ����գ����ʾһ������
        /// </summary>
        public string str_AmountType {get;set;}

        ///<summary>
        ///��ֹʱ��
        /// </summary>
        public DateTime? dt_CanUseTime {get;set;}

        ///<summary>
        ///����ʹ�ô���
        /// </summary>
        public int? Ing_CanUseNum {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public string str_SendType {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public string str_PaperName {get;set;}

        ///<summary>
        ///״̬  1����Ч   0����Ч
        /// </summary>
        public int? Ing_Sta {get;set;}

        ///<summary>
        ///�����ŵ�
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///����̧ͷ
        /// </summary>
        public string str_SendContent {get;set;}

        ///<summary>
        ///�ŵ�ʹ�÷�Χ
        /// </summary>
        public string str_UseArea {get;set;}

        ///<summary>
        ///�Ƿ���Բ���  1����   0����
        /// </summary>
        public int? Ing_IsReSend {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Remark {get;set;}

        ///<summary>
        ///�Ż�ȯ����ǰ׺
        /// </summary>
        public string str_Prefix {get;set;}

        ///<summary>
        ///��ʼ����
        /// </summary>
        public int? Ing_StartNo {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public int? Ing_EndNo {get;set;}

        ///<summary>
        ///�ۿ���
        /// </summary>
        public decimal? dec_Discount {get;set;}

        ///<summary>
        ///���۽��
        /// </summary>
        public decimal? dec_SalePrice {get;set;}

        ///<summary>
        ///�����ظ�ʹ�ô���
        /// </summary>
        public int? Ing_RepeatUse {get;set;}

        ///<summary>
        ///�ŵ��Ƿ��������
        /// </summary>
        public int? Ing_CanSale {get;set;}

        ///<summary>
        ///��ʼʱ��
        /// </summary>
        public DateTime? dt_CanUseCTime {get;set;}

        ///<summary>
        ///pccode
        /// </summary>
        public string str_Pccode {get;set;}

        ///<summary>
        ///ʹ�ù���
        /// </summary>
        public string str_rule {get;set;}


        /// <summary>
        /// ���ٻ��ֲ��ܹ���ǰ�Ż�ȯ
        /// </summary>
        public int Ing_IntegralBuy { get; set; }


        /// <summary>
        /// ��������Ҳ��ܹ���
        /// </summary>
        public decimal dec_CashBuy { get; set; }
    }

    /// <summary>
    /// �����Ż�ȯ�Ĳ���
    /// </summary>
    public class CreateCoupponM
    {
        /// <summary>
        /// ��Ա��id
        /// </summary>
        public int vipCardInfoId { get; set; }

        /// <summary>
        /// �Ż�ȯid  (���Ϊ0�������Ż�ȯ)
        /// </summary>
        public int coupontypeId { get; set; }

        /// <summary>
        /// �Ż�ȯ��Ч��
        /// </summary>
        public int ingmonth { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public string str_Activity { get; set; }
    }

    /// <summary>
    /// ΢�Ż��ֶһ�����ȯ
    /// </summary>
    public class WechatCouponM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_CouponTypeID { get; set; }

        /// <summary>
        /// �
        /// </summary>
        public CouponTypeM typeM { get; set; }

        /// <summary>
        /// ��Ա��ID
        /// </summary>
        public int VipcardID { get; set; }

        /// <summary>
        /// �һ�������
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// �����Ի�����
        /// </summary>
        public int TotalNumber { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string message { get; set; }
    }
}