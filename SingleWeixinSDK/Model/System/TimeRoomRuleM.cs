using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_TimeRoomRule
    /// </summary>
    public class TimeRoomRuleM
    {
        ///<summary>
        ///Ing_PID
        /// </summary>
        public int Ing_PID {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///���ͣ��ձ�ʾȫ��
        /// </summary>
        public string str_RoomType {get;set;}

        ///<summary>
        ///��Ա�����ͣ��ձ�ʾȫ��
        /// </summary>
        public int Ing_VipCardType {get;set;}

        ///<summary>
        ///��Ч��ʼ����
        /// </summary>
        public DateTime? dt_BeginTime {get;set;}

        ///<summary>
        ///��Ч��������
        /// </summary>
        public DateTime? dt_EndTime {get;set;}

        ///<summary>
        ///�𲽼�
        /// </summary>
        public decimal dec_StepRate {get;set;}

        ///<summary>
        ///��ʱ��
        /// </summary>
        public int Ing_StepHoure {get;set;}

        ///<summary>
        ///��ʱ
        /// </summary>
        public int? Ing_DelayTime {get;set;}

        ///<summary>
        ///������ÿСʱ���ӵķ���
        /// </summary>
        public decimal dec_AddRateByHoure {get;set;}

        ///<summary>
        ///�ӵ㷿��סʱ����������תΪȫ�췿
        /// </summary>
        public int? Ing_MustChangeHoure {get;set;}

        ///<summary>
        ///״̬ 1Ϊ���� 0 Ϊ������
        /// </summary>
        public int Ing_Sta {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_Remark {get;set;}

        ///<summary>
        ///��ʼʱ��
        /// </summary>
        public string str_B_Time {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public string str_E_Time {get;set;}

        ///<summary>
        ///���ȼ�
        /// </summary>
        public int? Prior {get;set;}

        /// <summary>
        /// ��Դ����
        /// </summary>
        public string ClockGuestMarket { get; set; }

        /// <summary>
        /// ��Դ
        /// </summary>
        public string marketName { get; set; }

        /// <summary>
        /// ��Ա������
        /// </summary>
        public string CardTypeName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string TypeName { get; set; }

    }

    /// <summary>
    /// �ӵ㷿�ѹ�������ã���ѯʱ�õ��Ĳ���
    /// </summary>
    public class ParaForSearchTimeRuleM
    {
        ///<summary>
        ///���ͣ��ձ�ʾȫ��
        /// </summary>
        public string str_RoomType { get; set; }

        ///<summary>
        ///��Ա�����ͣ�0��ʾȫ��
        /// </summary>
        public int Ing_VipCardType { get; set; }

        ///<summary>
        ///״̬ 1Ϊ���� 0 Ϊ������
        /// </summary>
        public int Ing_Sta { get; set; }
    }
}