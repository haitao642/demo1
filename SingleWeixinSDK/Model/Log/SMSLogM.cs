using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Log
{
    /// <summary>
    /// T_SMSLog
    /// </summary>
    public class SMSLogM
    {
        ///<summary>
        ///Ing_pk_sd
        /// </summary>
        public int Ing_pk_sd { get; set; }

        ///<summary>
        ///短信类型
        /// </summary>
        public string str_SMSType { get; set; }

        ///<summary>
        ///短信名称
        /// </summary>
        public string str_SMSName { get; set; }

        ///<summary>
        ///发送状态（1:成功；0:失败）
        /// </summary>
        public int? Ing_sta { get; set; }

        ///<summary>
        ///发送的平台的url
        /// </summary>
        public string str_SMSURL { get; set; }

        ///<summary>
        ///发送时间
        /// </summary>
        public DateTime? dt_SendTime { get; set; }

        ///<summary>
        ///接受手机号
        /// </summary>
        public string str_Mobile { get; set; }

        ///<summary>
        ///发送内容
        /// </summary>
        public string str_SMSContent { get; set; }

        ///<summary>
        ///发送者
        /// </summary>
        public string str_Sender { get; set; }

        ///<summary>
        ///发送后反馈信息
        /// </summary>
        public string str_ReturnMsg { get; set; }

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID { get; set; }



    }
}
