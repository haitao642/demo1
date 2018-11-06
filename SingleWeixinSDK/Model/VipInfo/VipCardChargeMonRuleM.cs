using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_VipCard_ChargeMonRule
    /// </summary>
    public class VipCardChargeMonRuleM
    {
        ///<summary>
        ///Ing_ChargeMonId
        /// </summary>
        public int Ing_ChargeMonId {get;set;}

        ///<summary>
        ///��Ա������
        /// </summary>
        public int? Ing_CardType {get;set;}

        ///<summary>
        ///��Ч����
        /// </summary>
        public DateTime? dt_BeginTime {get;set;}

        ///<summary>
        ///ʧЧ����
        /// </summary>
        public DateTime? dt_EndTime {get;set;}

        ///<summary>
        ///��ͳ�ֵ�������Ǵ��ڵ�����ͳ�ֵ���
        /// </summary>
        public decimal? dec_MinMon {get;set;}

        ///<summary>
        ///��߳�ֵ��������С����߳�ֵ���
        /// </summary>
        public decimal? dec_MaxMon {get;set;}

        ///<summary>
        ///����ֵ
        /// </summary>
        public decimal? dec_GiveMon {get;set;}

        ///<summary>
        ///��ֵ���� 3Ϊ���ֳ�ֵ���ͻ��ֱ���, 5Ϊ�����ֵ���ͽ�����
        /// </summary>
        public int? Ing_ChargeType {get;set;}

        ///<summary>
        ///���ͷ�ʽ��1��ʾ���̶�ֵ���ͣ�2��ʾ����������
        /// </summary>
        public int? SendType {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}



    }
}