using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Comments
    /// </summary>
    public class CommentsM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_Pk_comID {get;set;}

        ///<summary>
        ///�ŵ�ID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///��Ա��ID
        /// </summary>
        public int Ing_VipcardID {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime dt_comDate {get;set;}


        ///<summary>
        ///�ܵ�����   0:����  1��������
        /// </summary>
        public int Ing_total {get;set;}

        ///<summary>
        ///�ŵ�
        /// </summary>
        public string str_good {get;set;}

        ///<summary>
        ///str_bad
        /// </summary>
        public string str_bad {get;set;}

        ///<summary>
        ///�Ƶ����   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col1 {get;set;}

        ///<summary>
        ///�ɾ�����   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col2 {get;set;}

        ///<summary>
        ///������Ϣ����(�ռ�/����/��ζ��)   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col3 {get;set;}

        ///<summary>
        ///˯�����ʶ�   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col4 {get;set;}

        ///<summary>
        ///������Ʒ   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col5 {get;set;}

        ///<summary>
        ///��ԡ   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col6 {get;set;}

        ///<summary>
        ///���ԡ��   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col7 {get;set;}

        ///<summary>
        ///WIFI����   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col8 {get;set;}

        ///<summary>
        ///������ʩ��װ��   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col9 {get;set;}

        ///<summary>
        ///�Ƶ�����   �Ӻõ�����0 1 2
        /// </summary>
        public int Ing_col10 {get;set;}

        ///<summary>
        ///ɾ����־
        /// </summary>
        public int Ing_del {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_memo {get;set;}

        /// <summary>
        /// ����id
        /// </summary>
        public int Ing_MasterID {get;set;}


        /// <summary>
        /// ����
        /// </summary>
        public string str_RoomType { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public string str_RoomNo { get; set; }



    }
}