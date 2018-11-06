using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_VipCard_Log
    /// </summary>
    public class VipCardLogM
    {
        ///<summary>
        ///Ing_LogID
        /// </summary>
        public int Ing_LogID {get;set;}

        ///<summary>
        ///�ŵ��
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///��ԱID
        /// </summary>
        public int? Ing_Fk_VipCardId {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public string str_LogType {get;set;}

        ///<summary>
        ///IP��ַ
        /// </summary>
        public string str_LogIP {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_LogDate {get;set;}

        ///<summary>
        ///��־����
        /// </summary>
        public string str_LogDesc {get;set;}

        ///<summary>
        ///����Ա
        /// </summary>
        public string str_UserNo {get;set;}

        ///<summary>
        ///�Ͽ���
        /// </summary>
        public string str_OldVipCard {get;set;}

        ///<summary>
        ///�¿���
        /// </summary>
        public string str_NewVipCard {get;set;}



    }

    /// <summary>
    /// RecordLogM
    /// </summary>
    public class RecordLogM 
    {
        /// <summary>
        /// �ֶ�
        /// </summary>
        public string str_Code { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string str_Name { get; set; }
    }
}