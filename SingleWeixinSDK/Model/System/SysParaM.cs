using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Sys_Para
    /// </summary>
    public class SysParaM
    {
        ///<summary>
        ///Ing_pk_PID
        /// </summary>
        public int Ing_pk_PID {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public string str_ParaType {get;set;}

        ///<summary>
        ///�������루Ҫ��Ψһ��
        /// </summary>
        public string str_ParaCode {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_ParaName {get;set;}

        ///<summary>
        ///����ֵ
        /// </summary>
        public string str_ParaData {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Memo {get;set;}

        ///<summary>
        ///״̬��0���������ã�1��ֻ����2,����ʾ��
        /// </summary>
        public int? Ing_sta {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}



    }
}