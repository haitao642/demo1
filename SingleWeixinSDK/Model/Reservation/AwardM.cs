using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Award
    /// </summary>
    public class AwardM
    {
        ///<summary>
        ///����ID
        /// </summary>
        public int Ing_AwardID {get;set;}

        ///<summary>
        ///�ȼ�
        /// </summary>
        public int Ing_level {get;set;}

        ///<summary>
        ///���ĵȼ�
        /// </summary>
        public string str_level {get;set;}

        ///<summary>
        ///��Ʒ����
        /// </summary>
        public string str_Goods {get;set;}

        ///<summary>
        ///Ӧ��ת�ĽǶ�
        /// </summary>
        public int Ing_angles {get;set;}

        ///<summary>
        ///���������������
        /// </summary>
        public int Ing_Amount {get;set;}

        ///<summary>
        ///1:ʵ����Ʒ��   0��������Ʒ
        /// </summary>
        public int Ing_RealGoods {get;set;}



        ///<summary>
        ///��ʼʱ��
        /// </summary>
        public DateTime dt_Start { get; set; }

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime dt_End { get; set; }

        ///<summary>
        ///������Ż�ȯ����Ӧ�Ļid
        /// </summary>
        public int Ing_CouponTypeID { get; set; }



    }


    /// <summary>
    /// �齱�õ��Ĳ���
    /// </summary>
    public class ParaForAwardM
    {
        /// <summary>
        /// ��Ա��ID
        /// </summary>
        public int Ing_VipcardID { get; set; }
    }
}