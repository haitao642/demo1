using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_ComDetail
    /// </summary>
    public class ComDetailM
    {
        ///<summary>
        ///����������ID
        /// </summary>
        public int Ing_DetailID {get;set;}

        ///<summary>
        ///���۱������
        /// </summary>
        public int? Ing_ComID {get;set;}

        ///<summary>
        ///���ۻ��߻ظ�������
        /// </summary>
        public string str_Result {get;set;}

        ///<summary>
        ///ʱ��
        /// </summary>
        public DateTime? dt_Com {get;set;}

        ///<summary>
        ///�����  0�����⣬  1��������
        /// </summary>
        public int? Ing_Result {get;set;}

        ///<summary>
        ///����ǵ곤�ظ��ģ���Ϊ�곤��id
        /// </summary>
        public int Ing_UserID {get;set;}

        /// <summary>
        /// Ҫ������Ա��΢��id����  �Զ��ŷָ�
        /// </summary>
        public string openids { get; set; }



    }
}