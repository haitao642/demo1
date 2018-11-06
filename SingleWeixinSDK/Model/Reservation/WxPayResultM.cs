using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_WxPayResult
    /// </summary>
    public class WxPayResultM
    {
        ///<summary>
        ///����ID
        /// </summary>
        public int Ing_ResultID {get;set;}

        ///<summary>
        ///���ࣺ  0��Ԥ��֧��    1:��Ա��ֵ
        /// </summary>
        public int Ing_type {get;set;}

        ///<summary>
        ///��Ӧ������id,  �����Ԥ��֧���ģ���������id
        /// </summary>s
        public int Ing_pkid {get;set;}

        ///<summary>
        ///��������id1
        /// </summary>
        public int Ing_pkid1 {get;set;}

        ///<summary>
        ///��������id2
        /// </summary>
        public int? Ing_pkid2 {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_Create {get;set;}

        ///<summary>
        ///�̻�������
        /// </summary>
        public string out_trade_no {get;set;}

        ///<summary>
        ///΢��֧������
        /// </summary>
        public string transaction_id {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_Pay {get;set;}

        ///<summary>
        ///������ʱ��
        /// </summary>
        public DateTime? dt_Modify {get;set;}

        ///<summary>
        ///���
        /// </summary>
        public decimal dec_fee {get;set;}

        ///<summary>
        ///״̬   0��δ֧������֧��ʧ��    1��֧���ɹ�  2:���֧����������ֵ�����ȥ��
        /// </summary>
        public int Ing_Sta {get;set;}

        /// <summary>
        /// openid
        /// </summary>
        public string openid { get; set; }


        /// <summary>
        /// �Ż�ȯid  �Զ��ŷָ����ַ���
        /// </summary>
        public string PagerIDs { get; set; }

        /// <summary>
        /// ΢�Ž��
        /// </summary>
        public decimal dec_WechatPrice { get; set; }

        ///<summary>
        ///��ֵ���
        /// </summary>
        public decimal dec_SurplusMoney { get; set; }

        /// <summary>
        /// �ŵ�ID
        /// </summary>
        public int Ing_StoreID { get; set; }
        /// <summary>
        /// token
        /// </summary>
        public string str_Token { get; set; }
    }
}