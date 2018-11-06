using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Sys_BusnType
    /// </summary>
    public class SysBusnTypeM
    {
        ///<summary>
        ///Ing_pk_TypeID
        /// </summary>
        public int Ing_pk_TypeID {get;set;}

        ///<summary>
        ///������(ͬһ�ŵ겻�����ظ�����)
        /// </summary>
        public string str_TypeCode {get;set;}

        ///<summary>
        ///ϵͳ��������ID
        /// </summary>
        public string str_BusineTypeID {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public string str_TypeName {get;set;}

        ///<summary>
        ///Ӣ���������
        /// </summary>
        public string str_TypeNameEng {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public int? Ing_Seq {get;set;}

        ///<summary>
        ///�Ƿ���ã�1:���ã�0:�����ã�
        /// </summary>
        public int? Ing_sta {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Memo {get;set;}

        ///<summary>
        ///�޸���
        /// </summary>
        public string str_Modify {get;set;}

        ///<summary>
        ///�޸�ʱ��
        /// </summary>
        public DateTime? dt_ModifyTime {get;set;}

        ///<summary>
        ///str_ReferName
        /// </summary>
        public string str_ReferName {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}



    }

    /// <summary>
    /// ϵͳ����ļ���
    /// </summary>
    public class SysBusnTypeSimpleM
    {
        ///<summary>
        ///Ing_pk_TypeID
        /// </summary>
        public int Ing_pk_TypeID { get; set; }


        ///<summary>
        ///������(ͬһ�ŵ겻�����ظ�����)
        /// </summary>
        public string str_TypeCode { get; set; }

        ///<summary>
        ///ϵͳ��������ID
        /// </summary>
        public string str_BusineTypeID { get; set; }

        ///<summary>
        ///�������
        /// </summary>
        public string str_TypeName { get; set; }
    }
}