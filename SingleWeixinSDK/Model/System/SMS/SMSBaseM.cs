using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_SMSBase
    /// </summary>
    public class SMSBaseM
    {
        ///<summary>
        ///Ing_pk_sd
        /// </summary>
        public int Ing_pk_sd {get;set;}

        ///<summary>
        ///�������Ψһ��
        /// </summary>
        public string str_SMSType {get;set;}

        ///<summary>
        ///�����������
        /// </summary>
        public string str_SMSName {get;set;}

        ///<summary>
        ///״̬��0:ͣ�ã�1:���ã�
        /// </summary>
        public int? Ing_sta {get;set;}

        ///<summary>
        ///���Ͷ��ŵĽӿ�ƽ̨url
        /// </summary>
        public string str_SMSURL {get;set;}

        ///<summary>
        ///str_SMSContent
        /// </summary>
        public string str_SMSContent {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Memo {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}



    }
}