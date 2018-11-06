using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_CouponDetails
    /// </summary>
    public class CouponDetailsM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_PaperID {get;set;}

        ///<summary>
        ///�Ż�ȯ����
        /// </summary>
        public int Ing_CouponTypeID {get;set;}

        ///<summary>
        ///�Ż�ȯ����
        /// </summary>
        public string str_PaperCode {get;set;}

        ///<summary>
        ///�Ż�ȯ����
        /// </summary>
        public string str_PaperName {get;set;}

        ///<summary>
        ///���
        /// </summary>
        public decimal? dec_Amount {get;set;}

        /// <summary>
        /// ����ַ���
        /// </summary>
        public string str_Amount { get {
            if (!dec_Amount.HasValue) return "0";
            return dec_Amount.Value.ToString("F0");
        } }

        ///<summary>
        ///��ʼʱ��
        /// </summary>
        public DateTime dt_StartTime {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime dt_EndTime {get;set;}

        ///<summary>
        ///ʹ���ŵ귶Χ
        /// </summary>
        public string str_UseArea {get;set;}

        ///<summary>
        ///�Ƿ�ʹ��
        /// </summary>
        public int? Ing_IsUse {get;set;}

        ///<summary>
        ///str_barcode
        /// </summary>
        public string str_barcode {get;set;}

        ///<summary>
        ///str_TDcode
        /// </summary>
        public string str_TDcode {get;set;}

        ///<summary>
        ///str_descript
        /// </summary>
        public string str_descript {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_remark {get;set;}

        ///<summary>
        ///״̬  1����Ч  0����Ч  2��ע��  3����ʧ
        /// </summary>
        public int? Ing_Sta {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_createtime {get;set;}

        /// <summary>
        /// ʹ��ʱ��
        /// </summary>
        public DateTime? dt_useTime{get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_creater {get;set;}

        ///<summary>
        ///�����ŵ�
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///��Ա��id
        /// </summary>
        public int? Ing_VipcardInfoID {get;set;}

        ///<summary>
        ///��ʹ�ô���
        /// </summary>
        public int? Ing_CanUseNum {get;set;}

        ///<summary>
        ///�Ѿ�ʹ�ô���
        /// </summary>
        public int? Ing_UseNum {get;set;}

        ///<summary>
        ///����ʹ�ô���
        /// </summary>
        public int? Ing_LastNum {get;set;}

        ///<summary>
        ///�ۿ�
        /// </summary>
        public decimal? dec_Discount {get;set;}

        ///<summary>
        ///pccode
        /// </summary>
        public string str_Pccode {get;set;}



    }

    /// <summary>
    /// ���۱��modle
    /// </summary>
    public class CouponPriceM 
    {
      /// <summary>
      /// ����id
      /// </summary>
      public  int masterid{get;set;}

      /// <summary>
      /// �Ż�ȯid
      /// </summary>
      public int couponid { get; set; }
    }


    /// <summary>
    /// ���ݻ�Ա���Ų��ҳ������Ż�ȯ��¼
    /// </summary>
    public class ResultCouponM
    {
        /// <summary>
        /// ��������
        /// </summary>
        public string str_PaperName { get; set; }


        /// <summary>
        /// ���ͱ�ʶ
        /// </summary>
        public string str_SendType { get; set; }

        /// <summary>
        /// �Ż�ȯ���ͣ�0��ͨ,1�䷿��
        /// </summary>
        public int Ing_type { get; set; }

        /// <summary>
        /// �Ż�ȯ����
        /// </summary>
        public int Ing_PaperID { get; set; }


        /// <summary>
        /// �Ż�ȯ����
        /// </summary>
        public string str_PaperCode { get; set; }


        /// <summary>
        /// �Żݽ��
        /// </summary>
        public decimal dec_Amount { get; set; }

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime dt_StartTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime dt_EndTime { get; set; }

        /// <summary>
        /// ����ʹ�õĴ���
        /// </summary>
        public int Ing_LastNum { get; set; }

        /// <summary>
        /// ����ַ���
        /// </summary>
        public string str_Amount
        {
            get
            {
                return dec_Amount.ToString("F0");
            }
        }
    }


    /// <summary>
    /// �ֿ�ȯ֧��Ҫ���Ĳ���
    /// </summary>
    public class ParaForCoponPayM
    {
        /// <summary>
        /// ����id
        /// </summary>
        public int MasterID { get; set; }


        /// <summary>
        /// �Ż�ȯid
        /// </summary>
        public int PagerID { get; set; }

        /// <summary>
        /// �Ż�ȯid  �Զ��ŷָ����ַ���
        /// </summary>
        public string PagerIDs { get; set; }

        /// <summary>
        /// �Ż�ȯid�б�
        /// </summary>
        public List<int> ListPagerID
        {
            get {                
                List<int> list = new List<int>();
                if (string.IsNullOrEmpty(PagerIDs))
                {
                    return list;
                }
                List<string> liststr = PagerIDs.Split(',').ToList();
                foreach (string str in liststr)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }
                    int id = 0;
                    if (!int.TryParse(str, out id))
                    {
                        continue;
                    }
                    if (id <= 0)
                    {
                        continue;
                    }
                    list.Add(id);
                }
                return list;
            }
        }

        /// <summary>
        /// �ŵ�id
        /// </summary>
        public int Ing_StoreID { get; set; }
        

        /// <summary>
        /// ��ע
        /// </summary>
        public string str_Remark { get; set; }


        ///<summary>
        ///��Ա��ID
        /// </summary>
        public int Ing_Pk_VipCardId { get; set; }

        /// <summary>
        /// ΢�Ž��
        /// </summary>
        public decimal dec_WechatPrice { get; set; }

        ///<summary>
        ///��ֵ���
        /// </summary>
        public decimal dec_SurplusMoney { get; set; }

        /// <summary>
        /// ���ֶһ��ܹ����˶��ٻ���
        /// </summary>
        public int Ing_IntegralExchangeTotal { get; set; }

        /// <summary>
        /// ���ֶһ��Ľ��
        /// </summary>
        public decimal dec_IntegralExchangeTotalMoney { get; set; }

        /// <summary>
        /// token
        /// </summary>
        public string token { get; set; }

    }


    /// <summary>
    /// �����ֿ�ȯ֧�����ص���
    /// </summary>
    public class ResultCoponCancelM
    {
        /// <summary>
        /// ������룬 0��ʾ��ȷ��
        /// </summary>
        public int ret { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string msg { get; set; }
    }
}