using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_WechatPosition
    /// </summary>
    public class WechatPositionM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_PositionID {get;set;}

        ///<summary>
        ///openid
        /// </summary>
        public string openid {get;set;}

        ///<summary>
        /// γ��
        /// </summary>
        public string latitude {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string longitude {get;set;}

        ///<summary>
        ///ʡ
        /// </summary>
        public string province {get;set;}

        ///<summary>
        ///��
        /// </summary>
        public string cityname {get;set;}

        ///<summary>
        ///��
        /// </summary>
        public string district {get;set;}

        ///<summary>
        ///�ֵ�
        /// </summary>
        public string street {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string street_number {get;set;}

        ///<summary>
        ///������ַ
        /// </summary>
        public string formatted_address {get;set;}

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime dt_Create { get; set; }
    }
}