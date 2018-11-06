using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_ContinueInter
    /// </summary>
    public class ContinueInterM
    {
        ///<summary>
        ///��������
        /// </summary>
        public int Ing_pkid {get;set;}

        ///<summary>
        ///�ŵ�ID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///����ID
        /// </summary>
        public int Ing_MasterID {get;set;}

        ///<summary>
        ///ԭ��������
        /// </summary>
        public DateTime? dt_Odepdate {get;set;}

        ///<summary>
        ///�µ�����
        /// </summary>
        public DateTime? dt_depdate {get;set;}

        ///<summary>
        ///��ס����
        /// </summary>
        public int? Ing_days {get;set;}

        ///<summary>
        ///�˴���ס�����ļ۸�
        /// </summary>
        public decimal? dec_price {get;set;}

        ///<summary>
        ///0:��ס   1���˷�
        /// </summary>
        public int Ing_type {get;set;}

        ///<summary>
        ///�Ķ���־   0��δ�Ķ�    1�����Ķ�
        /// </summary>
        public int Ing_ReadFlag {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime dt_Create {get;set;}

        ///<summary>
        ///��ס�����ʶ  0��δ����   1���Ѹ���
        /// </summary>
        public int Ing_PayType {get;set;}



    }


    /// <summary>
    /// ��סҳ����ʾ�õ�model
    /// </summary>
    public class ContinueInterDisplay {

        /// <summary>
        /// ����ID
        /// </summary>
        public int Ing_MasterID { get; set; }


        /// <summary>
        /// openid
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// ��ס��
        /// </summary>
        public string str_cusname { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string str_mobile { get; set; }

        /// <summary>
        /// �ŵ�ID
        /// </summary>
        public int Ing_StoreID { get; set; }

        /// <summary>
        /// �ŵ�����
        /// </summary>
        public string str_StoreName { get; set; }

        /// <summary>
        /// һ��ļ۸�
        /// </summary>
        public decimal dec_priceOneNight { get; set; }

        /// <summary>
        /// �ܼ�
        /// </summary>
        public decimal dec_price { get; set; }

        /// <summary>
        /// ��ס������
        /// </summary>
        public int Ing_ContinueDays { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string str_Accnt { get; set; }


        /// <summary>
        /// �����
        /// </summary>
        public string str_RoomNo { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string str_roomtype1 { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public int Ing_RoomNum { get; set; }

        /// <summary>
        /// ԭ��������
        /// </summary>
        public DateTime dtArr { get; set; }


        /// <summary>
        /// ԭ��������
        /// </summary>
        public DateTime dtDep { get; set; }

        /// <summary>
        /// ԭ���ķ�����
        /// </summary>
        public int Ing_OldNight { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string message { get; set; }
    }



    /// <summary>
    /// ѡ��  �˷�  ����   ��ס
    /// </summary>
    public class SelectContinueM
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public int Ing_MasterID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string str_Cusname { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public string str_RoomNo { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string message { get; set; }
    }
}