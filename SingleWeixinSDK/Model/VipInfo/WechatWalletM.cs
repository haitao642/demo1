using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WechatWalletViewM:BaseMyAccountM
    {
        public List<WechatWalletM> list { get; set; }
    }
    /// <summary>
    /// T_Wechat_Wallet
    /// </summary>
    public class WechatWalletM
    {
        ///<summary>
        ///Ing_PKID
        /// </summary>
        public int Ing_PKID {get;set;}

        ///<summary>
        ///��Ա��id
        /// </summary>
        public int? Ing_Fk_VipcardId {get;set;}

        ///<summary>
        ///����id
        /// </summary>
        public int? Ing_Fk_MasterId {get;set;}

        ///<summary>
        ///���ͣ�0��ֵ,1֧����
        /// </summary>
        public int Ing_Type {get;set;}

        /// <summary>
        /// ��������
        /// </summary>
        public string str_Type 
        {
            get 
            {
                if (Ing_Type == 0)
                {
                    return "΢��֧��--����";
                }
                else 
                {
                    return "΢��Ǯ��֧��";
                }
            }
        }

        ///<summary>
        ///�۸�
        /// </summary>
        public decimal? dec_Price {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_Create {get;set;}

        ///<summary>
        ///����Ա
        /// </summary>
        public string str_Creator {get;set;}

        /// <summary>
        /// ��ע
        /// </summary>
        public string str_Memo { get; set; }
    }
}