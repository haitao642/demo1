using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_WeChat_User
    /// </summary>
    public class WeChatUserM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_WeChat_UserID {get;set;}

        ///<summary>
        ///�ŵ�ID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///΢��id
        /// </summary>
        public string OpenID {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_memo {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public int Ing_type {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_type {get;set;}


        /// <summary>
        /// ״̬   0������  1������  2����ȷ��
        /// </summary>
        public int Ing_sta { get; set; }


        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime dt_Create { get; set; }


        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime dt_Modify { get; set; }

    }
}