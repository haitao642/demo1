using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_VipCard_ChargeMon
    /// </summary>
    public class VipCardChargeMonM
    {
        ///<summary>
        ///Ing_pk_VCMID
        /// </summary>
        public int Ing_pk_VCMID { get; set; }

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID { get; set; }

        ///<summary>
        ///Ing_Fk_VipCardID
        /// </summary>
        public int? Ing_Fk_VipCardID { get; set; }

        ///<summary>
        ///��Ա����
        /// </summary>
        public string str_VipCard { get; set; }

        ///<summary>
        ///str_pk_accnt
        /// </summary>
        public string str_pk_accnt { get; set; }

        ///<summary>
        ///���ѽ��
        /// </summary>
        public decimal? dec_ChargeMon { get; set; }

        ///<summary>
        ///��ֵ���
        /// </summary>
        public decimal? dec_CreditMon { get; set; }

        ///<summary>
        ///�������
        /// </summary>
        public decimal? dec_Balance { get; set; }

        ///<summary>
        ///��ֵ����
        /// </summary>
        public int? Ing_ChargeType { get; set; }

        ///<summary>
        ///�Ƿ���Ч 1Ϊ��Ч 0Ϊ��Ч
        /// </summary>
        public int? Ing_halt { get; set; }

        ///<summary>
        ///��ֵ����
        /// </summary>
        public DateTime? dt_ChargeDate { get; set; }

        ///<summary>
        ///��ֵ����Ա
        /// </summary>
        public string str_ChargeEmp { get; set; }

        ///<summary>
        ///���ͻ��ֶ�
        /// </summary>
        public int? Ing_SendIntegral { get; set; }

        ///<summary>
        ///dt_Bdate
        /// </summary>
        public DateTime? dt_Bdate { get; set; }

        ///<summary>
        ///���ͽ���������
        /// </summary>
        public int? PayType { get; set; }

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Remark { get; set; }

        ///<summary>
        ///dt_ExpiredDate
        /// </summary>
        public DateTime? dt_ExpiredDate { get; set; }

        /// <summary>
        /// �ɿ���Ʊ���
        /// </summary>
        public int Ing_Receipt { get; set; }

        /// <summary>
        /// ���͵ĸ�id
        /// </summary>
        public int Ing_Pid { get; set; }



    }


    /// <summary>
    /// ��ֵ�б����
    /// </summary>
    public class ChargeMonResultM:BaseMyAccountM
    {
        /// <summary>
        /// ��Ա��
        /// </summary>
        public VipCardInfoM cardM { get; set; }

        /// <summary>
        /// ��ֵʹ�����
        /// </summary>
        public List<VipCardChargeMonM> list { get; set; }
    }
}