using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_WxChargeMon
    /// </summary>
    public class WxChargeMonM
    {
        public WxChargeMonM(int Ing_Pk_id,int Ing_ChareMon)
        {
            this.Ing_ChareMon = Ing_ChareMon;
            this.Ing_Pk_id = Ing_Pk_id;
            this.str_order = "WxChargeMon10" + Ing_Pk_id.ToString();
            str_memo = "��ֵ��ֵ:" + Ing_ChareMon.ToString() + "Ԫ";
        }
        public WxChargeMonM()
        {

        }
        ///<summary>
        ///����
        /// </summary>
        public int Ing_Pk_id {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public int Ing_ChareMon {get;set;}

        ///<summary>
        ///�͵Ľ��
        /// </summary>
        public int Ing_SendMon {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_memo {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int Ing_order {get;set;}
        /// <summary>
        /// ����
        /// </summary>
        public string str_order { get; set; }


    }
}