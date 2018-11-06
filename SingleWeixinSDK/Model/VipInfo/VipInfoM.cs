using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Vip_Info
    /// </summary>
    public class VipInfoM
    {
        ///<summary>
        ///Ing_Pk_VipID
        /// </summary>
        public int Ing_Pk_VipID {get;set;}

        ///<summary>
        ///��Ա��
        /// </summary>
        public string str_VipID {get;set;}

        ///<summary>
        ///Ing_Fk_CustID
        /// </summary>
        public int? Ing_Fk_CustID {get;set;}

        ///<summary>
        ///��Ա����
        /// </summary>
        public int? Ing_VipType {get;set;}

        ///<summary>
        ///��Ա�ȼ�
        /// </summary>
        public int? Ing_VipLevel {get;set;}

        ///<summary>
        ///�ܹ�����
        /// </summary>
        public int? Ing_TotalIntegral {get;set;}

        ///<summary>
        ///���ѻ���
        /// </summary>
        public int? Ing_ExchangeIntegral {get;set;}

        ///<summary>
        ///ʣ�����
        /// </summary>
        public int? Ing_SurplusIntegral {get;set;}

        ///<summary>
        ///ʣ����
        /// </summary>
        public decimal? dec_SurplusMoney {get;set;}

        ///<summary>
        ///dec_PersentMoney
        /// </summary>
        public decimal? dec_PersentMoney {get;set;}

        ///<summary>
        ///��ҹ����
        /// </summary>
        public decimal? dec_RoomNightScore {get;set;}

        ///<summary>
        ///�ӵ㷿��ס����
        /// </summary>
        public int? Ing_ClockRoomCount {get;set;}

        ///<summary>
        ///�Ƿ�ͣ�� 1Ϊ��ͣ�� 0 Ϊͣ��
        /// </summary>
        public int? Ing_halt {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Remark {get;set;}

        ///<summary>
        ///�����루���룩���16λ
        /// </summary>
        public string str_pwd {get;set;}

        ///<summary>
        ///��Ա��¼��
        /// </summary>
        public string str_loginName {get;set;}

        ///<summary>
        ///��Ա��¼����
        /// </summary>
        public string str_loginPwd {get;set;}

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
        ///Ing_IsGroup
        /// </summary>
        public int? Ing_IsGroup {get;set;}

        ///<summary>
        ///79Ԫ��Ȩ
        /// </summary>
        public int? Ing_IsTq {get;set;}

        ///<summary>
        ///ATC�õ�
        /// </summary>
        public int? Ing_IsVflag {get;set;}

        ///<summary>
        ///str_RegisterChannel
        /// </summary>
        public string str_RegisterChannel {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}


    }
}