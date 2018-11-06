using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_VipCard_Type
    /// </summary>
    public class VipCardTypeM
    {
        ///<summary>
        ///�����ͱ��
        /// </summary>
        public int Ing_CardTypeID {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_CardTypeName {get;set;}

        ///<summary>
        ///�Ƿ���Ч 0 Ϊ��Ч��1 Ϊ��Ч
        /// </summary>
        public int Ing_Halt {get;set;}


        ///<summary>
        ///�Ƿ���Ч
        /// </summary>
        public string str_Halt { get {
            return Ing_Halt == 1 ? "��Ч" : "��Ч";
        
        } }

        ///<summary>
        ///���Ա��
        /// </summary>
        public int Ing_PolicyNumber {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_remark {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int? Ing_Seq {get;set;}

        ///<summary>
        ///�ϼ������ͱ��
        /// </summary>
        public int? Ing_UpLevlvID {get;set;}

        ///<summary>
        ///�¼������ͱ��
        /// </summary>
        public int? Ing_DowmLevlvID {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_UpStrWhere {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_DowmWhere {get;set;}

        ///<summary>
        ///str_RateCode
        /// </summary>
        public string str_RateCode {get;set;}

        ///<summary>
        ///dec_PriceFee
        /// </summary>
        public decimal? dec_PriceFee {get;set;}

        ///<summary>
        ///��ʼ����
        /// </summary>
        public string str_VipCardStart {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_VipCardEnd {get;set;}

        ///<summary>
        ///�˿����Ǵ�ֵ��,0��ʾ��,1��ʾ��
        /// </summary>
        public int? IsDepositable {get;set;}

        ///<summary>
        ///��ʼ����
        /// </summary>
        public int? Ing_InitScore {get;set;}

        ///<summary>
        ///���հ��췿���˷�ʱ��
        /// </summary>
        public string str_HalfCheckoutTime {get;set;}

        ///<summary>
        ///����ȫ�췿���˷�ʱ��
        /// </summary>
        public string str_FullCheckoutTime {get;set;}

        ///<summary>
        ///ÿ�ֶ�Ӧ���������
        /// </summary>
        public decimal? dec_RmbPerScore {get;set;}

        ///<summary>
        ///��Դ�г�����
        /// </summary>
        public string str_Mcode {get;set;}

        ///<summary>
        ///OpenContent
        /// </summary>
        public int? OpenContent {get;set;}

        ///<summary>
        ///���ۼ۸�
        /// </summary>
        public decimal? dec_SalePrice {get;set;}

        ///<summary>
        ///���Ѽ۸�
        /// </summary>
        public decimal? dec_ContinuePrice {get;set;}

        ///<summary>
        ///��Ч����
        /// </summary>
        public int? ValidMonthLength {get;set;}

        ///<summary>
        ///�˿���Ϊ����ע��ʱ��Ĭ�Ͽ�
        /// </summary>
        public int? IsForRegister {get;set;}

        ///<summary>
        ///��ֵ������ʱ��ʹ������
        /// </summary>
        public int? UsingConsumePwd {get;set;}

        ///<summary>
        ///����ʹ�ö�������ȡ����
        /// </summary>
        public int? UsingCardReader {get;set;}

        ///<summary>
        ///�˿�����Ҫ�ȿ������ټ���
        /// </summary>
        public int? NeedInitCard {get;set;}

        ///<summary>
        ///��ֹ��Ա����ſ����������ڣ�
        /// </summary>
        public int? CardUserUnique {get;set;}

        ///<summary>
        ///��ֹǰ̨�޸����ۼ۸�
        /// </summary>
        public int? FixPrice {get;set;}

        ///<summary>
        ///����֧��ֻ������ʹ��,0��ʾ��,1��ʾ��
        /// </summary>
        public int? SelfScore {get;set;}

        ///<summary>
        ///��ֵ֧��ֻ������ʹ��,0��ʾ��,1��ʾ��
        /// </summary>
        public int? SelfDeposit {get;set;}

        ///<summary>
        ///�Ƿ��ǹ�˾��
        /// </summary>
        public int? IsForCompany {get;set;}

        ///<summary>
        ///�Ƽ��������û��Ľ�������
        /// </summary>
        public int? IntroScore {get;set;}

        ///<summary>
        ///�����ֹ����뿨��
        /// </summary>
        public int? ManualInput {get;set;}

        ///<summary>
        ///��Ա�������ӡ��ע
        /// </summary>
        public string PrintNote {get;set;}

        ///<summary>
        ///Noshow�۳���������
        /// </summary>
        public int? NoshowScore {get;set;}

        ///<summary>
        ///�ֻ��ű���
        /// </summary>
        public int? RequireMobile {get;set;}

        ///<summary>
        ///�������Ѷ���Ԫ�ŷ��ͻ���֧������
        /// </summary>
        public decimal? dec_SmsScoreFactor {get;set;}

        ///<summary>
        ///�������Ѷ���Ԫ�ŷ��ʹ�ֵ����
        /// </summary>
        public decimal? dec_SmsDepositFactor {get;set;}

        ///<summary>
        ///����ף��Ҫ�󣬻������ٶ���
        /// </summary>
        public decimal? dec_BirSmsScoreTop {get;set;}

        ///<summary>
        ///����ף��Ҫ����ס�������ٶ���
        /// </summary>
        public int? BirSmsNumTop {get;set;}

        ///<summary>
        ///����ף��Ҫ��������ס�������ٶ���
        /// </summary>
        public int? BirSmsMonthNumTop {get;set;}

        ///<summary>
        ///����ף����������
        /// </summary>
        public string BirSmsContent {get;set;}

        ///<summary>
        ///����ף����ǰ����
        /// </summary>
        public int? BirSmsAdvDays {get;set;}

        ///<summary>
        ///��ֵ��ֵʱ���ͽ������,1��ʾ���,2��ʾ����
        /// </summary>
        public int? DepositSendType {get;set;}

        ///<summary>
        ///Ԥ�����ޣ�0��ʾ������
        /// </summary>
        public int? OrderMaxNum {get;set;}

        ///<summary>
        ///Ԥ��������ʱ��
        /// </summary>
        public int? OrderReserveHour {get;set;}

        ///<summary>
        ///��ֵ�������Ƿ��������,0��ʾ������,1��ʾ����
        /// </summary>
        public int? DepositCreateScore {get;set;}

        ///<summary>
        ///�û�����������������
        /// </summary>
        public int? Ing_CommentScore {get;set;}

        ///<summary>
        ///��ֹ��Ա����ſ���ȫ�����ࣩ
        /// </summary>
        public int? CardUserUniqueAll {get;set;}

        ///<summary>
        ///str_PayPcode
        /// </summary>
        public string str_PayPcode {get;set;}

        ///<summary>
        ///str_IncomePcode
        /// </summary>
        public string str_IncomePcode {get;set;}

        ///<summary>
        ///dec_PresentCost
        /// </summary>
        public decimal? dec_PresentCost {get;set;}

        ///<summary>
        ///Ing_WXScore
        /// </summary>
        public int? Ing_WXScore {get;set;}

        ///<summary>
        ///Ing_PayScore
        /// </summary>
        public int? Ing_PayScore {get;set;}

        ///<summary>
        ///Ing_Fk_RateID
        /// </summary>
        public int? Ing_Fk_RateID {get;set;}

        /// <summary>
        /// ����
        /// </summary>
        public int? Ing_jifen { get; set; }

        /// <summary>
        /// �Ż�ȯ����id
        /// </summary>
        public int? Ing_CouponTypeID { get; set; }

        
        /// <summary>
        /// �Ƿ�֧����ס�Ż�
        /// </summary>
        public int Ing_FirstCheck { get; set; }
    }
}