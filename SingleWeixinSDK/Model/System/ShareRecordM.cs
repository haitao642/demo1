using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_ShareRecord
    /// </summary>
    public class ShareRecordM
    {
        ///<summary>
        ///����
        /// </summary>
        public int Ing_Pk_id {get;set;}

        ///<summary>
        ///�����ߵĻ�Ա��ID
        /// </summary>
        public int Ing_VipCardID {get;set;}

        ///<summary>
        ///���Ƽ��˵�openid
        /// </summary>
        public string str_openid {get;set;}

        ///<summary>
        ///���Ƽ��˵Ĵ�ֵ״̬   0����δ��ֵ   1���Ѿ���ֵ
        /// </summary>
        public int Ing_sta {get;set;}

        ///<summary>
        ///��ֵʱ��
        /// </summary>
        public DateTime? dt_ChargeMon {get;set;}



    }
}