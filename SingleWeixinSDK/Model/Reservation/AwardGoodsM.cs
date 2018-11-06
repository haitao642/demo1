using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_AwardGoods
    /// </summary>
    public class AwardGoodsM
    {
        ///<summary>
        ///����ID
        /// </summary>
        public int Ing_AwardGoodsID {get;set;}

        ///<summary>
        ///��Ա��ID
        /// </summary>
        public int? Ing_VipcardID {get;set;}

        ///<summary>
        ///��Ӧ�Ľ���
        /// </summary>
        public int? Ing_AwardID {get;set;}

        ///<summary>
        ///����ID
        /// </summary>
        public int? Ing_MasterID {get;set;}

        ///<summary>
        ///�齱ʱ��
        /// </summary>
        public DateTime? dt_Create {get;set;}

        ///<summary>
        ///��ȡʱ��
        /// </summary>
        public DateTime? dt_Modify {get;set;}

        ///<summary>
        ///��ȡ��
        /// </summary>
        public string str_Modify {get;set;}

        ///<summary>
        ///��ȡ�ŵ�
        /// </summary>
        public int? Ing_StoreID {get;set;}

        /// <summary>
        /// ��ȡ״̬��0��δ��ȡ  1������ȡ
        /// </summary>
        public int Ing_Sta { get; set; }



    }

    /// <summary>
    /// ��ȡ�Ľ�Ʒ
    /// </summary>
    public class ListAwGoodsM
    {
        /// <summary>
        /// ��Ʒ
        /// </summary>
        public List<AwGoodModel> list { get; set; }
    }


    /// <summary>
    /// V_AwardGoods
    /// </summary>
    public class AwGoodModel : AwardGoodsM
    {
        /// <summary>
        /// ����
        /// </summary>
        public int Ing_RealGoods { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string str_Goods { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string str_level { get; set; }

        /// <summary>
        /// �ֻ���
        /// </summary>
        public string str_mobile { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string str_CusName { get; set; }

        /// <summary>
        /// ֤����
        /// </summary>
        public string str_ident { get; set; }

        /// <summary>
        /// �ŵ�����
        /// </summary>
        public string str_StoreName { get; set; }

        /// <summary>
        /// ��Ա����
        /// </summary>
        public string str_VipCard { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string str_Query { get; set; }

        /// <summary>
        /// ����״̬
        /// </summary>
        public string str_Sta
        {
            get
            {
                if (Ing_Sta == 1)
                {
                    return "����ȡ";
                }
                else
                {
                    return "δ��ȡ";
                }
            }

        }
    }
}