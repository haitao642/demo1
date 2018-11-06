using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_WechatHis
    /// </summary>
    public class WechatHisM
    {
        ///<summary>
        ///����ID
        /// </summary>
        public int Ing_WechatHisID {get;set;}

        ///<summary>
        ///openid
        /// </summary>
        public string str_openid {get;set;}

        ///<summary>
        ///�ǳ�
        /// </summary>
        public string str_nickname {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_Create {get;set;}

        ///<summary>
        ///�¼�����   0:��ע  1��ȡ����ע   2:�Ѿ���ע��ɨ���¼�
        /// </summary>
        public int? Ing_EventType {get;set;}

        ///<summary>
        ///����ֵ
        /// </summary>
        public int? Ing_Para {get;set;}

        ///<summary>
        ///��������  0����  1���ŵ�ID   2:����ԱID
        /// </summary>
        public int? Ing_ParaType {get;set;}



    }
}