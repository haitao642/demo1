using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_VipCard_ChargeIntegral
    /// </summary>
    public class VipCardChargeIntegralM
    {
        ///<summary>
        ///Ing_pk_CintID
        /// </summary>
        public int Ing_pk_CintID {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///Ing_Fk_VipCardID
        /// </summary>
        public int? Ing_Fk_VipCardID {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_VipCard {get;set;}

        ///<summary>
        ///��ֵ��� ���ں�Ӧ���ʹ���
        /// </summary>
        public string str_Pk_Accnt {get;set;}

        ///<summary>
        ///���ѻ���
        /// </summary>
        public int Ing_ChargeIntegral {get;set;}

        ///<summary>
        ///��ֵ����
        /// </summary>
        public int Ing_CreditIntegral {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public int? Ing_Balance {get;set;}

        ///<summary>
        ///��ֵ����
        /// </summary>
        public int? Ing_ChargeResone {get;set;}

        ///<summary>
        ///��ֵ����
        /// </summary>
        public int? Ing_ChargeType {get;set;}

        ///<summary>
        ///�Ƿ���Ч 1Ϊ��Ч 0 Ϊ��Ч
        /// </summary>
        public int? Ing_halt {get;set;}

        ///<summary>
        ///��ֵ����
        /// </summary>
        public DateTime? dt_ChargeDate {get;set;}

        ///<summary>
        ///��ֵ�� webAdminΪ���ϳ�ֵ ����Ϊ�ŵ�Ա�����
        /// </summary>
        public string str_ChargeEmp {get;set;}

        ///<summary>
        ///dt_Bdate
        /// </summary>
        public DateTime? dt_Bdate {get;set;}

        ///<summary>
        ///PayType
        /// </summary>
        public int? PayType {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_remark {get;set;}

        ///<summary>
        ///str_easyflag
        /// </summary>
        public string str_easyflag {get;set;}

        ///<summary>
        ///str_OldCardID
        /// </summary>
        public string str_OldCardID {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public DateTime? dt_ExpiredDate {get;set;}



    }

    /// <summary>
    /// �����б����
    /// </summary>
    public class ChargeIntegralResultM : BaseMyAccountM
    {
        /// <summary>
        /// ��Ա��
        /// </summary>
        public VipCardInfoM cardM { get; set; }

        /// <summary>
        /// ����ʹ�����
        /// </summary>
        public List<VipCardChargeIntegralM> list { get; set; }
    }
}