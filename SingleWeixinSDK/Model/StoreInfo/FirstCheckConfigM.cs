using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_FirstCheck_Config
    /// </summary>
    public class FirstCheckConfigM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_ID {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public DateTime? dt_Date {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int Ing_TotalNum {get;set;}

        ///<summary>
        ///ʹ�ô���
        /// </summary>
        public int Ing_UserNum {get;set;}


        ///<summary>
        ///����   0��΢�Ŷ˵Ŀ���
        /// </summary>
        public int Ing_Type { get; set; }

        ///<summary>
        ///�ŵ�id
        /// </summary>
        public int Ing_StoreID {get;set;}



    }    
}