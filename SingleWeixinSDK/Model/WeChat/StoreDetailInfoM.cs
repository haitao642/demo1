using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_StoreDetailInfo
    /// </summary>
    public class StoreDetailInfoM
    {
        ///<summary>
        ///Ing_StoreDetailInfoID
        /// </summary>
        public int Ing_StoreDetailInfoID {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///�ŵ���
        /// </summary>
        public string str_StoreBrief {get;set;}

        ///<summary>
        ///��ַ
        /// </summary>
        public string str_Address {get;set;}

        ///<summary>
        ///Ԥ���绰
        /// </summary>
        public string str_ReseCall {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_FAX {get;set;}

        ///<summary>
        ///400Ԥ��
        /// </summary>
        public string str_ReseFourCall {get;set;}

        ///<summary>
        ///WAPԤ��
        /// </summary>
        public string str_WAPRese {get;set;}

        ///<summary>
        ///��վԤ��
        /// </summary>
        public string str_WWWRese {get;set;}

        ///<summary>
        ///����Ԥ��
        /// </summary>
        public string str_ScheSMS {get;set;}

        ///<summary>
        ///Ͷ�ߵ绰
        /// </summary>
        public string str_ComplaintsTel {get;set;}

        ///<summary>
        ///������Ϣ
        /// </summary>
        public string str_RoomType {get;set;}

        ///<summary>
        ///�ͷ�����
        /// </summary>
        public string str_RoomService {get;set;}

        ///<summary>
        ///�Ƶ����
        /// </summary>
        public string str_HotelService {get;set;}

        ///<summary>
        ///�ܱ߻�������ҵ��ʩ
        /// </summary>
        public string str_EnvAndFa {get;set;}

        ///<summary>
        ///��ͨ��Ϣ
        /// </summary>
        public string str_TrafficInfo {get;set;}

        ///<summary>
        ///��ͼ����
        /// </summary>
        public string str_mapX {get;set;}

        ///<summary>
        ///��ͼγ��
        /// </summary>
        public string str_mapY {get;set;}

        ///<summary>
        ///��ܰ��ʾ
        /// </summary>
        public string str_KindlyRem {get;set;}



    }

    /// <summary>
    /// �ŵ��б��õ��Ĳ���
    /// </summary>
    public class DetailInfoInListM
    {
        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID { get; set; }


        ///<summary>
        ///��ͼ����
        /// </summary>
        public string str_mapX { get; set; }

        ///<summary>
        ///��ͼγ��
        /// </summary>
        public string str_mapY { get; set; }

        ///<summary>
        ///��ַ
        /// </summary>
        public string str_Address { get; set; }
    }
}