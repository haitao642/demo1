using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Acc
    /// </summary>
    public class AccM
    {
        ///<summary>
        ///Ing_Acc_Id
        /// </summary>
        public int Ing_Acc_Id {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///����id
        /// </summary>
        public int Ing_Fk_MasterID { get; set; }

        ///<summary>
        ///����
        /// </summary>
        public string str_RoomNo {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_Pk_Accnt {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public int Ing_Pk_number {get;set;}

        ///<summary>
        ///���ʺ�
        /// </summary>
        public int Ing_SubAccnt {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public int Ing_Serialnumber {get;set;}

        ///<summary>
        ///��������(ϵͳ��ǰ����)
        /// </summary>
        public DateTime dt_ModifyDate {get;set;}

        ///<summary>
        ///Ӫҵ����(��ҹ��Ϊ��׼�����ڣ�������ʱ��)
        /// </summary>
        public DateTime dt_BDate {get;set;}

        ///<summary>
        ///ҵ������(ϵͳʱ��,��ҹ��Ϊ��׼)
        /// </summary>
        public DateTime? dt_CreateDate {get;set;}

        ///<summary>
        ///Ӫҵ����
        /// </summary>
        public string str_PcCode {get;set;}

        ///<summary>
        ///�˵�����
        /// </summary>
        public string str_ArgCode {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int Ing_Qty {get;set;}

        ///<summary>
        ///ʵ�ս��
        /// </summary>
        public decimal? dec_TotalCharge {get;set;}

        ///<summary>
        ///���м�
        /// </summary>
        public decimal? dec_BaseCharge {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public decimal? dec_Preferential {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public decimal? dec_ServerCharge {get;set;}

        ///<summary>
        ///���ӷ�
        /// </summary>
        public decimal dec_AffixCharge {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public decimal? dec_OtherCharge {get;set;}

        ///<summary>
        ///ʵ��ʹ�ð�
        /// </summary>
        public decimal? dec_TrueUserPack {get;set;}

        ///<summary>
        ///����ʹ�ð�
        /// </summary>
        public decimal dec_AllowPackaged {get;set;}

        ///<summary>
        ///��ʵ�ʽ��
        /// </summary>
        public decimal? dec_TruePackaged {get;set;}

        ///<summary>
        ///Ѻ��
        /// </summary>
        public decimal? dec_Credit {get;set;}

        ///<summary>
        ///���
        /// </summary>
        public decimal? dec_Balance {get;set;}

        ///<summary>
        ///���
        /// </summary>
        public string str_Shift {get;set;}

        ///<summary>
        ///�û�
        /// </summary>
        public string str_Empno {get;set;}

        ///<summary>
        ///�����־
        /// </summary>
        public string str_Crradjt {get;set;}

        ///<summary>
        ///ˢ����
        /// </summary>
        public string str_Waiter {get;set;}

        ///<summary>
        ///�г���
        /// </summary>
        public string str_MarketID {get;set;}

        ///<summary>
        ///ԭ��
        /// </summary>
        public string str_Reason {get;set;}

        ///<summary>
        ///ת�˷���
        /// </summary>
        public string str_ToFrom {get;set;}

        ///<summary>
        ///ת����Դ
        /// </summary>
        public string str_AccnToF {get;set;}

        ///<summary>
        ///ת�˷��˻�
        /// </summary>
        public int Ing_SubAccnToF {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_desc {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_SingleNum {get;set;}

        ///<summary>
        ///ժҪ
        /// </summary>
        public string str_Abstract {get;set;}

        ///<summary>
        ///�ź�
        /// </summary>
        public string str_GroupNo {get;set;}

        ///<summary>
        ///����ģʽ
        /// </summary>
        public string str_Mode {get;set;}

        ///<summary>
        ///�˵���
        /// </summary>
        public int Ing_Billno {get;set;}

        ///<summary>
        ///�˵�����
        /// </summary>
        public int? Ing_AccTypeID {get;set;}

        ///<summary>
        ///�Ƿ���Ч 1Ϊ��Ч��0Ϊ��Ч
        /// </summary>
        public int? Ing_sta {get;set;}

        ///<summary>
        ///���ʵ���
        /// </summary>
        public string str_CheckoutNo {get;set;}

        ///<summary>
        ///���п���
        /// </summary>
        public int? Ing_bankCardNo {get;set;}

        ///<summary>
        ///���ֱ���
        /// </summary>
        public decimal? dec_IntegralSum {get;set;}

        ///<summary>
        ///��ӷ�������
        /// </summary>
        public string str_RateType {get;set;}

        ///<summary>
        ///str_OldAccnt
        /// </summary>
        public string str_OldAccnt {get;set;}

        ///<summary>
        ///str_rem
        /// </summary>
        public string str_rem {get;set;}

        ///<summary>
        ///str_intertype
        /// </summary>
        public string str_intertype {get;set;}

        ///<summary>
        ///str_SplitOldAccnt
        /// </summary>
        public string str_SplitOldAccnt {get;set;}

        ///<summary>
        ///str_VipCard
        /// </summary>
        public string str_VipCard {get;set;}

        /// <summary>
        /// ��Ա������
        /// </summary>
        public int Ing_Fk_VipCardID { get; set; }

        /// <summary>
        /// T_Item_Acc������
        /// </summary>
        public int Ing_ItemAccID { get; set; }

    }
}