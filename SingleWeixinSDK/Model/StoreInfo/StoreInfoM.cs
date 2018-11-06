using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Store_Info
    /// </summary>
    public class StoreInfoM
    {
        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///str_GroupCmpyID
        /// </summary>
        public string str_GroupCmpyID {get;set;}

        ///<summary>
        ///�Ƶ����
        /// </summary>
        public string str_StoreNo {get;set;}

        ///<summary>
        ///�ֵ��ӦNC�ӿ��˺�
        /// </summary>
        public string str_StoreNoForNC {get;set;}

        ///<summary>
        ///�ֵ���
        /// </summary>
        public string str_StoreName {get;set;}

        ///<summary>
        ///�ֵ�������ĸ
        /// </summary>
        public string str_StoreNameEng {get;set;}

        ///<summary>
        ///�ֵ�ȫ��
        /// </summary>
        public string str_StoreFullName {get;set;}

        ///<summary>
        ///�ֵ�Ӣ����
        /// </summary>
        public string str_StoreFullNameEng {get;set;}

        ///<summary>
        ///��ַ
        /// </summary>
        public string str_Address {get;set;}

        ///<summary>
        ///�ʱ�
        /// </summary>
        public string str_Zip {get;set;}

        ///<summary>
        ///��ַ
        /// </summary>
        public string str_Website {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_email {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_FAX {get;set;}

        ///<summary>
        ///�����ˣ��곤���꾭��
        /// </summary>
        public string str_chargeName {get;set;}

        ///<summary>
        ///�곤����
        /// </summary>
        public string str_chargePhone {get;set;}

        ///<summary>
        ///�곤�ֻ�
        /// </summary>
        public string str_chargeMobil {get;set;}

        ///<summary>
        ///����绰
        /// </summary>
        public string str_hotTel {get;set;}

        ///<summary>
        ///�������򣨻��������ϣ�
        /// </summary>
        public string str_Region {get;set;}

        ///<summary>
        ///ʡ��
        /// </summary>
        public string str_Provinces {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_city {get;set;}

        ///<summary>
        ///��/��
        /// </summary>
        public string str_district {get;set;}

        ///<summary>
        ///���еȼ�(A�࣬B��..)
        /// </summary>
        public string str_SLevel {get;set;}

        ///<summary>
        ///�ض�
        /// </summary>
        public string str_area {get;set;}

        ///<summary>
        ///Ʒ��
        /// </summary>
        public string str_brand {get;set;}

        ///<summary>
        ///��������(ֱӪ,����)
        /// </summary>
        public string str_InnType {get;set;}

        ///<summary>
        ///�������ʣ�ֱӪ�����˹�����ͬ����
        /// </summary>
        public string str_MangerType {get;set;}

        ///<summary>
        ///��Ȧ
        /// </summary>
        public string str_CBD {get;set;}

        ///<summary>
        ///�ŵ����
        /// </summary>
        public string str_squaremeter {get;set;}

        ///<summary>
        ///״̬�����ã�ע������1��0��
        /// </summary>
        public int? Ing_State {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_memo {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_FinancialNO {get;set;}

        ///<summary>
        ///ҵ��绰
        /// </summary>
        public string str_ServerTel {get;set;}

        ///<summary>
        ///ҵ����
        /// </summary>
        public string str_ServerFax {get;set;}

        ///<summary>
        ///ҵ����ϵ��
        /// </summary>
        public string str_ServerPerson {get;set;}

        ///<summary>
        ///�ͻ�����վ
        /// </summary>
        public string str_TrainStation {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_bank {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_bankAccount {get;set;}

        ///<summary>
        ///�����˺�
        /// </summary>
        public string str_bankNO {get;set;}

        ///<summary>
        ///˰��
        /// </summary>
        public string str_tariffline {get;set;}

        ///<summary>
        ///Ӫҵʱ��
        /// </summary>
        public string str_BusinessHours {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_CreatStore {get;set;}

        ///<summary>
        ///��Ӫҵ����
        /// </summary>
        public string str_SoftOpening {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_Acceptor {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_AccepTime {get;set;}

        ///<summary>
        ///��֤��
        /// </summary>
        public string str_Margin {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_legalperson {get;set;}

        ///<summary>
        ///��ҵ����
        /// </summary>
        public string str_Aptitudes {get;set;}

        ///<summary>
        ///��Լ����
        /// </summary>
        public string str_cancellation {get;set;}

        ///<summary>
        ///��Ʊ���
        /// </summary>
        public string str_invType {get;set;}

        ///<summary>
        ///���Ŀ�1
        /// </summary>
        public string str_CenterStorage {get;set;}

        ///<summary>
        ///���Ŀ�2
        /// </summary>
        public string str_CenterStorage1 {get;set;}

        ///<summary>
        ///���Ŀ�3
        /// </summary>
        public string str_CenterStorage2 {get;set;}

        ///<summary>
        ///�ŵ��Ӧ�Ĺ�Ӧ���б�
        /// </summary>
        public string str_FK_SupIdStr {get;set;}

        ///<summary>
        ///�����
        /// </summary>
        public decimal? Maintenance {get;set;}

        ///<summary>
        ///�������
        /// </summary>
        public decimal? tariff {get;set;}

        ///<summary>
        ///���������ʽ�
        /// </summary>
        public decimal? award {get;set;}

        ///<summary>
        ///���������ʽ�ٷֱ�
        /// </summary>
        public decimal? awardpcnt {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_tunedstageDate {get;set;}

        ///<summary>
        ///������ķ���
        /// </summary>
        public decimal? tunedstageFee {get;set;}

        ///<summary>
        ///������Ĺ������
        /// </summary>
        public decimal? tunedstagetariff {get;set;}

        ///<summary>
        ///�ŵ�ȼ�
        /// </summary>
        public string str_StoreGrade {get;set;}

        ///<summary>
        ///�ջ���ַ
        /// </summary>
        public string str_ReceiveAddr {get;set;}

        ///<summary>
        ///�ջ���λ
        /// </summary>
        public string str_ReceiveUnit {get;set;}

        ///<summary>
        ///�ջ��ʱ�
        /// </summary>
        public string str_ReceiveZip {get;set;}

        ///<summary>
        ///�ջ�����
        /// </summary>
        public string str_ReceiveFax {get;set;}

        ///<summary>
        ///�ջ���
        /// </summary>
        public string str_Receiver {get;set;}

        ///<summary>
        ///�ջ��˵����ʼ�
        /// </summary>
        public string str_ReceiverEmail {get;set;}

        ///<summary>
        ///�ջ�������
        /// </summary>
        public string str_ReceiverPhone {get;set;}

        ///<summary>
        ///�ջ����ֻ�
        /// </summary>
        public string str_ReceiverMobile {get;set;}

        ///<summary>
        ///��Ҫ���淿̬ͼ
        /// </summary>
        public int? Ing_fK_RSRID {get;set;}

        ///<summary>
        ///������סʱ�䣨����ʱ�䣩
        /// </summary>
        public string str_OpenTime {get;set;}

        ///<summary>
        ///Ĭ���˷�ʱ��
        /// </summary>
        public string str_CloseTime {get;set;}

        ///<summary>
        ///��ס��Сʱ�շ�
        /// </summary>
        public string str_HrFee {get;set;}

        ///<summary>
        ///Ѻ��Ĭ����
        /// </summary>
        public decimal? deposit {get;set;}

        ///<summary>
        ///������Ȩ���
        /// </summary>
        public decimal? DepositCredit {get;set;}

        ///<summary>
        ///�������ӵ㷿(0:û�� 1:��)
        /// </summary>
        public int? IsHrsRm {get;set;}

        ///<summary>
        ///�޸�˵��
        /// </summary>
        public string str_ModifyMark {get;set;}

        ///<summary>
        ///�޸���
        /// </summary>
        public string str_Modify {get;set;}

        ///<summary>
        ///�޸�ʱ��
        /// </summary>
        public DateTime? dt_ModifyTime {get;set;}

        ///<summary>
        ///str_StateExc
        /// </summary>
        public string str_StateExc {get;set;}

        ///<summary>
        ///str_Zcode
        /// </summary>
        public string str_Zcode {get;set;}

        /// <summary>
        /// �Ƿ��������ϴ�����
        /// </summary>
        public int Ing_policeSta { get; set; }

        /// <summary>
        /// �����ϴ��û���
        /// </summary>
        public string str_policeusername { get; set; }

        /// <summary>
        /// �����ϴ�����
        /// </summary>
        public string str_policepassword { get; set; }

        /// <summary>
        /// �����ϴ���ַ
        /// </summary>
        public string str_policeurl { get; set; }

        /// <summary>
        /// �����ϴ����ùݱ��
        /// </summary>
        public string str_policeno { get; set; }

        /// <summary>
        /// ��ʶ��Ҫ������ҹ���
        /// </summary>
        public int Ing_AuditHour { get; set; }


        /// <summary>
        /// ҹ����Ƿ�ִ���˽���,1��ʾδ���࣬0��ʾ�Ѿ�����
        /// </summary>
        public int Ing_AfterAuditChangeRank { get; set; }

        
    }


    /// <summary>
    /// �ŵ��б�
    /// </summary>
    public class StoreM
    {
        /// <summary>
        /// �ŵ�ID
        /// </summary>
        public int Ing_StoreID { get; set; }


        /// <summary>
        /// �ŵ����� 
        /// </summary>
        public string str_StoreName { get; set; }


        /// <summary>
        /// �ŵ�ȫ�� 
        /// </summary>
        public string str_StoreFullName { get; set; }

        /// <summary>
        /// �� 
        /// </summary>
        public string str_district { get; set; }

        /// <summary>
        ///����
        /// </summary>
        public string str_city { get; set; }


        /// <summary>
        /// ��ַ
        /// </summary>
        public string str_Address { get; set; }


        /// <summary>
        /// ��͵ļ۸�
        /// </summary>
        public decimal VipPrice { get; set; }


        ///<summary>
        /// γ��
        /// </summary>
        public string str_port_y { get; set; }

        ///<summary>
        ///����
        /// </summary>
        public string str_port_x { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public decimal distance { get; set; }

        /// <summary>
        /// �ŵ�ͼƬ
        /// </summary>
        public string headerimg { get; set; }

        /// <summary>
        /// ͣ�������
        /// </summary>
        public int Ing_Park { get; set; }


        /// <summary>
        /// wifi���
        /// </summary>
        public int Ing_wifi { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public int Ing_Restaurant { get; set; }


        ///<summary>
        ///Ԥ���绰
        /// </summary>
        public string str_hotTel { get; set; }


        public string str_LockStoreNo { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public int Ing_SmsNumber { get; set; }
    }


    /// <summary>
    /// �ŵ�
    /// </summary>
    public class StoreListM
    {
        /// <summary>
        /// ͳ��
        /// </summary>
        public StoreSumM sum { get; set; }

        /// <summary>
        /// �ŵ��б�
        /// </summary>
        public List<StoreM> list { get; set; }
    }


    /// <summary>
    /// �ŵ���Ϣ
    /// </summary>
    public class StoreDetailM
    {
        /// <summary>
        /// �ŵ�id
        /// </summary>
        public int Ing_SotreID { get; set; }

        /// <summary>
        /// ��վ����ַ
        /// </summary>
        public string Webroot { get; set; }

        /// <summary>
        /// ��Ա��ID
        /// </summary>
        public int lngvipcardid { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public DateTime dtArr { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public DateTime dtDept { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string strtour { get; set; }

        /// <summary>
        /// �̳�
        /// </summary>
        public string strmarket { get; set; }

        /// <summary>
        /// ҽ��
        /// </summary>
        public string strhospital { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string strbank { get; set; }


        /// <summary>
        /// ��ʳ
        /// </summary>
        public string strdiet { get; set; }

        /// <summary>
        /// ͷ�ϵĵ�һ��ͼƬ
        /// </summary>
        public string strtopImg { get; set; }


        /// <summary>
        /// ��ͨ
        /// </summary>
        public string strtraffic { get; set; }

        /// <summary>
        /// ��ϸ��Ϣ
        /// </summary>
        public StoreDetailInfoM detailM { get; set; }


        /// <summary>
        /// �ŵ���Ϣ
        /// </summary>
        public StoreInfoM infoM { get; set; }

        /// <summary>
        /// �����б�
        /// </summary>
        public List<FitReservationM> RoomtypeList { get; set; }

        /// <summary>
        /// �ŵ�ͼƬ
        /// </summary>
        public List<StoreImgM> StoreImgList { get; set; }


        /// <summary>
        /// �����б�
        /// </summary>
        public List<UserCommentsM> commentList { get; set; }


    
    }
    /// <summary>
    /// 
    /// </summary>
    public class OutStoreInfoM
    {
        ///<summary>
        ///Ing_SPkID
        /// </summary>
        public int Ing_SPkID { get; set; }

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID { get; set; }

        ///<summary>
        ///�Ƶ����
        /// </summary>
        public string str_StoreNo { get; set; }

        ///<summary>
        ///�ֵ���
        /// </summary>
        public string str_StoreName { get; set; }

        ///<summary>
        ///�ֵ�������ĸ
        /// </summary>
        public string str_StoreNameEng { get; set; }

        ///<summary>
        ///�ֵ�ȫ��
        /// </summary>
        public string str_StoreFullName { get; set; }

        ///<summary>
        ///�ֵ�Ӣ����
        /// </summary>
        public string str_StoreFullNameEng { get; set; }


        ///<summary>
        ///״̬�����ã�ע������1��0��
        /// </summary>
        public int? Ing_State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Ing_fk_DbID { get; set; }
        public virtual string DbName { get; set; }
        public virtual int Ing_Pk_ServerID { get; set; }
        public virtual string ServerName { get; set; }
        public virtual int Ing_Pk_SqlID { get; set; }
        public virtual string SqlName { get; set; }
        /// <summary>
        /// ���ݿ��½����
        /// </summary>
        public string SqlUid { get; set; }
        /// <summary>
        /// ���ݿ��½����
        /// </summary>
        public string SqlPwd { get; set; }
        /// <summary>
        /// ���ݿ�����(sql server;orcal...)
        /// </summary>
        public string SqlType { get; set; }

        /// <summary>
        /// ���ʷ�������ַ
        /// </summary>
        public string HttpUrl { get; set; }
    }
    public class RequestParamModel
    {
        /// <summary>
        /// ����������
        /// </summary>
        public string SqlName { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// ����ֵ
        /// </summary>
        public string ObjectKey { get; set; }
    }

}