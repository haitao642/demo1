using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_CouponLog
    /// </summary>
    public class CouponLogM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_LogID {get;set;}

        ///<summary>
        ///�Ż�ȯ����
        /// </summary>
        public int? Ing_PaperID {get;set;}

        ///<summary>
        ///�Ż�ȯ����
        /// </summary>
        public string str_PaperCode {get;set;}

        ///<summary>
        ///ʹ���ŵ�
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int? Ing_MasterID {get;set;}

        ///<summary>
        ///�����˺�
        /// </summary>
        public string str_PK_Accnt {get;set;}

        ///<summary>
        ///�����Ż�ȯʹ�ò���������id
        /// </summary>
        public int? Ing_AccID {get;set;}

        ///<summary>
        ///�Ƿ�ʹ��   1,δʹ��,2ʹ��
        /// </summary>
        public int? Ing_useSta {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public string str_RoomNo {get;set;}

        ///<summary>
        ///ʹ��ʱ��
        /// </summary>
        public DateTime? dt_useTime {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_remark {get;set;}

        ///<summary>
        ///ʹ����
        /// </summary>
        public string str_Empno {get;set;}


        /// <summary>
        /// �ŵ�����
        /// </summary>
        public string str_StoreName { get; set; }

        /// <summary>
        /// ״̬����
        /// </summary>
        public string StrStaName { get; set; }

    }
}