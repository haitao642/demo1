using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_News
    /// </summary>
    public class NewsM
    {
        ///<summary>
        ///�Զ�����
        /// </summary>
        public int Ing_NewsID {get;set;}

        ///<summary>
        ///���±���
        /// </summary>
        public string str_Title {get;set;}

        ///<summary>
        ///str_TitleImg
        /// </summary>
        public string str_TitleImg {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_NContent {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_Author {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_Createtime {get;set;}

        ///<summary>
        ///�޸���
        /// </summary>
        public string str_Modify {get;set;}

        ///<summary>
        ///�޸�ʱ��
        /// </summary>
        public DateTime? dt_ModifyDate {get;set;}

        ///<summary>
        ///�Ķ�����
        /// </summary>
        public int? Ing_ReadNum {get;set;}

        ///<summary>
        ///���´���
        /// </summary>
        public int? Ing_FCaption {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public int? Ing_ChildCaption {get;set;}

        ///<summary>
        ///Ing_Del
        /// </summary>
        public int? Ing_Del {get;set;}

        ///<summary>
        ///�Ƿ��ö���0 �� 1�ǣ�
        /// </summary>
        public int? Ing_IsTop {get;set;}

        ///<summary>
        ///0��δ��� 1������� 2:δͨ��
        /// </summary>
        public int? Ing_Checked {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public string str_audit {get;set;}

        ///<summary>
        ///���ʱ��
        /// </summary>
        public DateTime? dt_auditTime {get;set;}

        ///<summary>
        ///Ing_sort
        /// </summary>
        public int? Ing_sort {get;set;}

        ///<summary>
        ///str_summary
        /// </summary>
        public string str_summary {get;set;}



    }

    /// <summary>
    /// �Ż��б�ҳ��
    /// </summary>
    public class PromotionListM
    {
        /// <summary>
        ///  �Ż��б�
        /// </summary>
        public List<NewsM> list { get; set; }
    }
}