using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_Master
    /// </summary>
    public class MasterM
    {
        ///<summary>
        ///Ing_Pk_MasterID
        /// </summary>
        public int Ing_Pk_MasterID {get;set;}

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int? Ing_StoreID {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_RoomNo {get;set;}

        ///<summary>
        ///�˺�
        /// </summary>
        public string str_Pk_Accnt {get;set;}

        ///<summary>
        ///�ͻ���
        /// </summary>
        public int? Ing_FK_CustID {get;set;}

        ///<summary>
        ///�Ŷ��˺�
        /// </summary>
        public string str_GroupNo {get;set;}

        /// <summary>
        /// �Ŷ�����
        /// </summary>
        public string str_GroupName { get; set; }

        ///<summary>
        ///����
        /// </summary>
        public string str_RoomType {get;set;}

        ///<summary>
        ///ԭ����
        /// </summary>
        public string str_ORoomType {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_UpRoomType {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_UpRoomTypeReson {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public int? Ing_RoomNum {get;set;}

        ///<summary>
        ///ԭ������
        /// </summary>
        public int? Ing_ORoomNum {get;set;}

        ///<summary>
        ///ԭ����
        /// </summary>
        public string str_ORoomNo {get;set;}

        ///<summary>
        ///Ӫҵʱ��
        /// </summary>
        public DateTime? dt_OperatDate {get;set;}

        ///<summary>
        ///��̬
        /// </summary>
        public string str_Sta {get;set;}

        ///<summary>
        ///ԭ��̬
        /// </summary>
        public string str_OSta {get;set;}

        ///<summary>
        ///������̬
        /// </summary>
        public string str_ResSta {get;set;}

        ///<summary>
        ///Ԥ��״̬
        /// </summary>
        public string str_ExpSta {get;set;}

        ///<summary>
        ///ҹ����
        /// </summary>
        public string str_StaTm {get;set;}

        ///<summary>
        ///���ʱ�־
        /// </summary>
        public string str_RmPostSta {get;set;}

        ///<summary>
        ///�Ƿ��뷿��
        /// </summary>
        public string str_RmPosted {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_ArrDate {get;set;}

        ///<summary>
        ///���ʱ��
        /// </summary>
        public DateTime? dt_DepDate {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public DateTime? dt_ResDep {get;set;}

        ///<summary>
        ///ԭ����ʱ��
        /// </summary>
        public DateTime? dt_OArrDate {get;set;}

        ///<summary>
        ///ԭ�뿪ʱ��
        /// </summary>
        public DateTime? dt_ODepDate {get;set;}

        ///<summary>
        ///���������
        /// </summary>
        public string str_AgentID {get;set;}

        ///<summary>
        ///Э�鹫˾����
        /// </summary>
        public string str_AgreeCompnyID {get;set;}

        /// <summary>
        /// Э�鵥λ����
        /// </summary>
        public string str_AgreeCompnyName { get; set; }

        ///<summary>
        ///��������
        /// </summary>
        public string str_RmResCentre {get;set;}

        ///<summary>
        ///�ʻ����
        /// </summary>
        public string str_AccntType {get;set;}

        ///<summary>
        ///��Դ
        /// </summary>
        public string str_Source {get;set;}

        ///<summary>
        ///�г���
        /// </summary>
        public string str_Markets {get;set;}

        ///<summary>
        ///Ԥ������
        /// </summary>
        public string str_ResType {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_Channel {get;set;}

        ///<summary>
        ///ar����1
        /// </summary>
        public string str_Artag1 {get;set;}

        ///<summary>
        ///ar����2
        /// </summary>
        public string str_Artag2 {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_Share {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public int? Ing_GstNum {get;set;}

        ///<summary>
        ///��ͯ
        /// </summary>
        public int? Ing_ChildrenNum {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_ExcRmReason {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_RateID {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_Packages {get;set;}

        ///<summary>
        ///�̶�����
        /// </summary>
        public decimal? dec_FixRate {get;set;}

        ///<summary>
        ///Э�鷿��
        /// </summary>
        public decimal? dec_AgreeRmRate {get;set;}

        ///<summary>
        ///���м�
        /// </summary>
        public decimal? dec_StandardRate {get;set;}

        ///<summary>
        ///ʵ�ʷ���
        /// </summary>
        public decimal? dec_ActualRate {get;set;}

        ///<summary>
        ///�Ż�����
        /// </summary>
        public string str_PreferentReason {get;set;}

        ///<summary>
        ///�ۿ�1
        /// </summary>
        public decimal? dec_discount {get;set;}

        ///<summary>
        ///�ۿ�2
        /// </summary>
        public decimal? dec_discount1 {get;set;}

        ///<summary>
        ///�Ӵ���
        /// </summary>
        public int? Ing_AddBedNum {get;set;}

        ///<summary>
        ///�Ӵ��۸�
        /// </summary>
        public decimal? dec_AddBedRate {get;set;}

        ///<summary>
        ///Ӥ������
        /// </summary>
        public int? Ing_crib {get;set;}

        ///<summary>
        ///Ӥ�����۸�
        /// </summary>
        public decimal? dec_CribRate {get;set;}

        ///<summary>
        ///���ʽ
        /// </summary>
        public string str_PayType {get;set;}

        ///<summary>
        ///�޶�
        /// </summary>
        public decimal? dec_limit {get;set;}

        ///<summary>
        ///���ÿ�
        /// </summary>
        public string str_CredID {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_CredMan {get;set;}

        ///<summary>
        ///������λ
        /// </summary>
        public string str_CredUnit {get;set;}

        ///<summary>
        ///str_idcls
        /// </summary>
        public string str_idcls {get;set;}

        ///<summary>
        ///str_ident
        /// </summary>
        public string str_ident {get;set;}

        ///<summary>
        ///str_street
        /// </summary>
        public string str_street {get;set;}

        ///<summary>
        ///str_nation
        /// </summary>
        public string str_nation {get;set;}

        ///<summary>
        ///str_cusname
        /// </summary>
        public string str_cusname {get;set;}

        ///<summary>
        ///str_gender
        /// </summary>
        public string str_gender {get;set;}

        ///<summary>
        ///dt_birth
        /// </summary>
        public DateTime? dt_birth {get;set;}

        ///<summary>
        ///Ԥ����
        /// </summary>
        public string str_ApplName {get;set;}

        ///<summary>
        ///Ԥ����λ
        /// </summary>
        public string str_Applicant {get;set;}

        ///<summary>
        ///ar�ʻ�
        /// </summary>
        public string str_ARAccnt {get;set;}

        ///<summary>
        ///�绰
        /// </summary>
        public string str_phone {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_fax {get;set;}

        ///<summary>
        ///�ʼ�
        /// </summary>
        public string str_email {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_WhereFrom {get;set;}

        ///<summary>
        ///ȥ��
        /// </summary>
        public string str_whereto {get;set;}

        ///<summary>
        ///Ŀ��
        /// </summary>
        public string str_purpose {get;set;}

        ///<summary>
        ///������Ϣ
        /// </summary>
        public string str_ArrInfo {get;set;}

        ///<summary>
        ///�ӻ�
        /// </summary>
        public string str_ArrCar {get;set;}

        ///<summary>
        ///�ӻ��۸�
        /// </summary>
        public decimal? dec_ArrRate {get;set;}

        ///<summary>
        ///�뿪��Ϣ
        /// </summary>
        public string str_DepInfo {get;set;}

        ///<summary>
        ///�ͻ�
        /// </summary>
        public string str_DepCar {get;set;}

        ///<summary>
        ///�ͻ��۸�
        /// </summary>
        public decimal? dec_DepRate {get;set;}

        ///<summary>
        ///�Ƿ��˷�  0 �˷� ����Ϊ��ס
        /// </summary>
        public string str_extra {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public decimal? dec_charge {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public decimal? dec_credit {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public decimal? dec_accredit {get;set;}

        ///<summary>
        ///����Ҫ��id
        /// </summary>
        public string str_srqs {get;set;}

        ///<summary>
        ///�ͷ�����
        /// </summary>
        public string str_amenities {get;set;}

        ///<summary>
        ///���˺�
        /// </summary>
        public string str_parentAccnt {get;set;}

        ///<summary>
        ///�ͷ���Դ���
        /// </summary>
        public string str_saccnt {get;set;}

        ///<summary>
        ///����(���˺�)
        /// </summary>
        public string str_pcrec {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_pcrec_pkg {get;set;}

        ///<summary>
        ///Ԥ����
        /// </summary>
        public string str_ResNo {get;set;}

        ///<summary>
        ///����Ԥ����
        /// </summary>
        public string str_Crsno {get;set;}

        ///<summary>
        ///��ע
        /// </summary>
        public string str_memo {get;set;}

        ///<summary>
        ///������ʾ
        /// </summary>
        public string str_comsg {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_CardID {get;set;}

        ///<summary>
        ///����Ա
        /// </summary>
        public string str_saleid {get;set;}

        ///<summary>
        ///Ӷ����
        /// </summary>
        public string str_cmscode {get;set;}

        ///<summary>
        ///Ing_Fk_VipID
        /// </summary>
        public int? Ing_Fk_VipID {get;set;}

        ///<summary>
        ///Ing_Fk_VipCardID
        /// </summary>
        public int? Ing_Fk_VipCardID {get;set;}

        ///<summary>
        ///str_VipCard
        /// </summary>
        public string str_VipCard {get;set;}

        ///<summary>
        ///Ԥ����
        /// </summary>
        public string str_resby {get;set;}

        ///<summary>
        ///Ԥ��ʱ��
        /// </summary>
        public DateTime? dt_restime {get;set;}

        ///<summary>
        ///�Ǽ���
        /// </summary>
        public string str_ciby {get;set;}

        ///<summary>
        ///�Ǽ�ʱ��
        /// </summary>
        public DateTime? dt_citime {get;set;}

        ///<summary>
        ///������
        /// </summary>
        public string str_coby {get;set;}

        ///<summary>
        ///����ʱ��
        /// </summary>
        public DateTime? dt_cotime {get;set;}

        ///<summary>
        ///��������
        /// </summary>
        public string str_depby {get;set;}

        ///<summary>
        ///������ʱ��
        /// </summary>
        public DateTime? dt_deptime {get;set;}

        ///<summary>
        ///�޸���
        /// </summary>
        public string str_Modify {get;set;}

        ///<summary>
        ///�޸�ʱ��
        /// </summary>
        public DateTime? dt_ModifyTime {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_feature {get;set;}

        ///<summary>
        ///��ס����
        /// </summary>
        public string str_InterType {get;set;}

        ///<summary>
        ///����
        /// </summary>
        public string str_secret {get;set;}

        ///<summary>
        ///���
        /// </summary>
        public string str_Cusclass {get;set;}

        ///<summary>
        ///str_pcrecaccnt
        /// </summary>
        public string str_pcrecaccnt {get;set;}

        ///<summary>
        ///�Ƿ��н��ã�Y��N���ǣ�
        /// </summary>
        public int? Borrowing {get;set;}

        ///<summary>
        ///ԭ����
        /// </summary>
        public string str_Oldrmtype {get;set;}

        ///<summary>
        ///�˷�Ӫҵ����
        /// </summary>
        public DateTime? dt_OutBdate {get;set;}

        ///<summary>
        ///���Ժ�
        /// </summary>
        public int? Ing_Fk_Policyid {get;set;}

        ///<summary>
        ///str_rsvno
        /// </summary>
        public string str_rsvno {get;set;}

        ///<summary>
        ///str_ptrv
        /// </summary>
        public string str_ptrv {get;set;}

        ///<summary>
        ///str_Owned
        /// </summary>
        public string str_Owned {get;set;}

        ///<summary>
        ///str_Owner
        /// </summary>
        public string str_Owner {get;set;}

        ///<summary>
        ///dt_CancelTime
        /// </summary>
        public DateTime? dt_CancelTime {get;set;}

        ///<summary>
        ///Ing_IsVflag
        /// </summary>
        public int? Ing_IsVflag {get;set;}

        ///<summary>
        ///79Ԫ��Ȩ
        /// </summary>
        public int? Ing_IsTq {get;set;}

        ///<summary>
        ///Ing_IsLock
        /// </summary>
        public int? Ing_IsLock {get;set;}

        ///<summary>
        ///str_FConFirm
        /// </summary>
        public string str_FConFirm {get;set;}

        ///<summary>
        ///dt_FConFirmTime
        /// </summary>
        public DateTime? dt_FConFirmTime {get;set;}

        ///<summary>
        ///Ing_IsHour
        /// </summary>
        public int? Ing_IsHour {get;set;}

        ///<summary>
        ///Ing_hideonWechat
        /// </summary>
        public int? Ing_hideonWechat {get;set;}

        /// <summary>
        /// ��ͷ���
        /// </summary>
        public int? Ing_breakfast { get; set; }


        /// <summary>
        /// ������
        /// </summary>
        public string str_CustomerNo { get; set; }

        /// <summary>
        /// �ֻ�
        /// </summary>
        public string str_mobile { get; set; }


        /// <summary>
        /// �Ƿ񿪾߷�Ʊ
        /// </summary>
        public int Ing_IsInvoice { get; set; }

        /// <summary>
        /// �Ƶ�����
        /// </summary>
        public string str_StoreName { get; set; }

    }
}