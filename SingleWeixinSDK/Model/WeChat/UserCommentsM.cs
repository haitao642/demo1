using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// ��Ա���۱�
    /// </summary>
    public class UserCommentsM
    {
        ///<summary>
        ///Ing_PK_comID
        /// </summary>
        public int Ing_PK_comID {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///�ŵ�����
        /// </summary>
        public string strStoreName {get;set;}

        ///<summary>
        ///��Ա��id
        /// </summary>
        public int? Ing_VipCardID {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string strUserName {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dtcomDate {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string strcomCon {get;set;}

        ///<summary>
        ///����Ч��
        /// </summary>
        public int? IngserviceEff {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public int? IngserviceAtt {get;set;}

        ///<summary>
        ///��ԡ���ʶ�
        /// </summary>
        public int? IngShowerCom {get;set;}

        ///<summary>
        ///�ͷ�����
        /// </summary>
        public int? IngroomHea {get;set;}

        ///<summary>
        ///˯�����ʶ�
        /// </summary>
        public int? IngSleepCom {get;set;}

        ///<summary>
        ///״̬
        /// </summary>
        public int Ingsta {get;set;}

        ///<summary>
        ///ɾ����ʶ
        /// </summary>
        public int Ingdel {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public int? IngMasterID {get;set;}

        ///<summary>
        ///IngReSta
        /// </summary>
        public int? IngReSta {get;set;}

        ///<summary>
        ///��סʱ��
        /// </summary>
        public DateTime? dtCheckInTime {get;set;}



    }
}