using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WxPayResultD:BaseTable
    {
        public WxPayResultD()
            : base("T_WxPayResult", "Ing_ResultID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(WxPayResultM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ΢��֧�������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(WxPayResultM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<WxPayResultM>(model, model.Ing_ResultID);
            model.Ing_ResultID = this.lngKeyID;
            return rev;
        }


        
        /// <summary>
        /// ���ɾ��
        /// </summary>
        /// <param name="lnguserid"></param>
        /// <returns></returns>
        public bool CheckDelete(int id)
        {
            return true;
        }


        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="lnguserid"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {

            if (!CheckDelete(id))
            {
                return false;
            }

            return this.DeleteRecord(id);
        }
        #endregion

        /// <summary>
        /// �������ͺͶ�Ӧ������id��ѯ��¼   ֧���ɹ��ļ�¼
        /// </summary>
        /// <param name="Ing_type"></param>
        /// <param name="Ing_pkid"></param>
        /// <returns></returns>
        public WxPayResultM GetMoelBypid(int Ing_type, int Ing_pkid)
        {
            string strSql = "SELECT * FROM dbo.T_WxPayResult a WHERE a.Ing_type={0} AND a.Ing_pkid={1} AND a.Ing_Sta=1";
            strSql = string.Format(strSql,Ing_type,Ing_pkid);

            return this.GetQueryM<WxPayResultM>(strSql).FirstOrDefault();
        }

        /// <summary>
        /// ����out_trade_no���Ҽ�¼
        /// </summary>
        /// <param name="out_trade_no"></param>
        /// <returns></returns>
        public WxPayResultM GetModelbyouttradeno(string out_trade_no)
        {
            string strSql = "SELECT * FROM dbo.T_WxPayResult a WHERE a.out_trade_no=@out_trade_no";
            this.Sqlca.AddParameter("@out_trade_no", out_trade_no);

            WxPayResultM model = new WxPayResultM();
            model = this.GetQueryM<WxPayResultM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();
            return model;
        }


        /// <summary>
        /// ֧���ɹ���Ĳ���
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddPayResult(WxPayResultM model)
        {
            if (model == null)
            {
                this.LastError = "L����Ϊ��";
                return false;
            }
            if (string.IsNullOrEmpty(model.out_trade_no))
            {
                this.LastError = "L����out_trade_no����Ϊ��";
                return false;
            }
            WxPayResultM resM = GetModelbyouttradeno(model.out_trade_no);
            LogHelper.LogInfo("resM token:" + resM.str_Token);
            if (resM == null)
            {
                this.LastError = string.Format("Lû��out_trade_noΪ{0}��֧����¼",model.out_trade_no);
                return false;
            }

            if (resM.Ing_Sta == 1)
            {
                this.LastError =string.Format("L�Ѿ�֧��,���:{0}",resM.dec_fee/100);
                return false;
            }

            if (resM.Ing_pkid == 0)
            {
                this.LastError = "L����Ϊ0";
                return false;
            }
            MasterD masD = new MasterD();
            MasterM masterM = masD.GetM<MasterM>(resM.Ing_pkid, this.Sqlca);
            if (resM.Ing_type == 0) 
            {
                
                if (masterM == null)
                {
                    this.LastError = "L����û���ҵ�";
                    return false;
                }
            }
            
            if (resM.dec_fee != model.dec_fee / 100)
            {
                this.LastError = "L��һ��";
                return false;
            }

            resM.dt_Pay = model.dt_Pay;
            resM.dt_Modify = DateTime.Now;
            resM.transaction_id = model.transaction_id;
            resM.Ing_Sta = 1;

            ContinueInterD conD = new ContinueInterD();
            ContinueInterM conM = new ContinueInterM();
            if (resM.Ing_type == 0)
            {
                conM = conD.GetRecord(resM.Ing_pkid, 0);
                if (conM != null)
                {
                    conM.Ing_PayType = 1;
                }
            }

            ParaForVipCardChargeM chargeM = new ParaForVipCardChargeM();

            ///�����ߵķ�Ӷ����
            ShareRecordD shareD = new ShareRecordD();
            ShareRecordM shareM = new ShareRecordM();
            ParaForVipCardChargeM charge1M = new ParaForVipCardChargeM();
            bool share = false;
            
            if (resM.Ing_type == 1)
            {
                WxChargeMonD monD = new WxChargeMonD();
                WxChargeMonM monM = new WxChargeMonM();
                //monM = monD.GetM<WxChargeMonM>(resM.Ing_pkid1);
                LogHelper.LogInfo(resM.Ing_pkid1.ToString());
                monM = monD.GetByid(resM.Ing_pkid1);
                if (monM == null)
                {
                    this.LastError = "L��Ա����ֵ��ֵ����û�г�ֵ����";
                    return false;
                }

                if (monM.Ing_ChareMon == 0)
                {
                    this.LastError = "L��Ա����ֵ��ֵ����û�г�ֵ���";
                    return false;
                }

                chargeM.chargemon = monM.Ing_ChareMon;
                chargeM.SendMon = monM.Ing_SendMon;
                chargeM.Reamrk = monM.str_memo;
                chargeM.Ing_Pk_VipCardID = resM.Ing_pkid;
                chargeM.chargeType = 5;

                ///������
                shareM = shareD.GetRecordByvipcardid(resM.Ing_pkid);
                if (shareM == null)
                {
                    goto start;
                }
                share = true;

                shareM.Ing_sta = 1;
                shareM.dt_ChargeMon = DateTime.Now;

                int ReturnMon = monM.Ing_ChareMon * ConfigValue.ShareReturnMon / 1000;
                ///��Ӷ����
                charge1M.chargemon = ReturnMon;
                charge1M.SendMon = 0;
                charge1M.Reamrk = string.Format("�Ƽ��ɹ�,��Ӷ{0}", ReturnMon);
                charge1M.Ing_Pk_VipCardID = shareM.Ing_VipCardID;
                charge1M.chargeType = 5;
            }


           

        start:

            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }

            if (!this.UpdateRecord<WxPayResultM>(resM, resM.Ing_ResultID,this.Sqlca))
            {
                this.LastError = "L����֧���ɹ���Ϣʧ��";
                goto updateerr;
            }


            if (resM.Ing_type == 0)
            {
                VipCardInfoD CardInfoD = new VipCardInfoD();

                ///��������  APP_Web_Account_AddFee
                Public.LogHelper.LogInfo(string.Format("΢��֧��(�ص�����)����id:{0},��ֵ���:{1},΢��Ǯ��:{2},�Ż�ȯ:{3},΢��֧��:{4}", masterM.Ing_Pk_MasterID
                    , resM.dec_SurplusMoney, resM.dec_WechatPrice, resM.PagerIDs,resM.dec_fee));

                if (!CardInfoD.CheckFirst(new ParaForCoponPayM { MasterID = masterM.Ing_Pk_MasterID, PagerIDs = resM.PagerIDs }))
                {
                    resM.PagerIDs = "0";
                    LogHelper.LogInfo("��ס�Ż�,���Ż�ȯ����Ϊ0.��ֹ��ס���Ż�ȯʹ��,����id:" + masterM.Ing_Pk_MasterID);
                }

                int resultv = 1;
                if (!masD.WechatPayAddFeeExec(resM.Ing_pkid, resM.dec_fee, 1, out resultv, this.Sqlca))
                {
                    this.LastError = "L֧���ɹ��󣬲����������";
                    goto updateerr;
                }
                LogHelper.LogInfo("resultv:" + resultv.ToString());

                //΢��Ǯ��
                if (resM.dec_WechatPrice > 0) 
                {
                    if (!CardInfoD.ExecWeChatPaySurplusMoney(0, masterM.Ing_Pk_MasterID, "9906", resM.dec_WechatPrice, this.Sqlca))
                    {
                        this.LastError = "L΢��Ǯ��֧�������������";
                        goto updateerr;
                    }
                    WechatWalletD walletD = new WechatWalletD();
                    WechatWalletM walletM = new WechatWalletM
                    {
                        Ing_Fk_MasterId = masterM.Ing_Pk_MasterID,
                        Ing_Fk_VipcardId = masterM.Ing_Fk_VipCardID,
                        Ing_Type = 1,
                        dec_Price = resM.dec_WechatPrice,
                        str_Creator = "Wechat",
                        str_Memo = "΢��Ԥ��",
                        dt_Create = DateTime.Now
                    };
                    if (!walletD.UpdateRecord<WechatWalletM>(walletM, walletM.Ing_PKID, this.Sqlca))
                    {
                        this.LastError = "L΢��Ǯ��֧����¼�������";
                        goto updateerr;
                    }
                    string strSql1 = "UPDATE T_VipCard_Info SET dec_WechatPrice=dec_WechatPrice-{0} WHERE Ing_Pk_VipCardId={1}";
                    strSql1 = string.Format(strSql1, resM.dec_WechatPrice, masterM.Ing_Fk_VipCardID);
                    if (!this.Sqlca.ExecuteNonQuery(strSql1))
                    {
                        this.LastError = "L΢��Ǯ������ʧ��";
                        goto updateerr;
                    }
                
                } 

                //�Ż�ȯ
                if (!string.IsNullOrEmpty(resM.PagerIDs))
                {
                    ParaForCoponPayM coponPayM = new ParaForCoponPayM();
                    coponPayM.Ing_StoreID = masterM.Ing_StoreID??0;
                    coponPayM.Ing_Pk_VipCardId = masterM.Ing_Fk_VipCardID??0;
                    coponPayM.MasterID = masterM.Ing_Pk_MasterID;
                    CouponDetailsD couD = new CouponDetailsD();
                    foreach (string item in resM.PagerIDs.Split(',').ToList())
                    {
                        if (string.IsNullOrEmpty(item)) 
                        {
                            continue;
                        }
                        int pagerid=0;
                        int.TryParse(item,out pagerid);
                        if (pagerid == 0) 
                        {
                            continue;
                        }
                        coponPayM.PagerID = pagerid;
                        if (!couD.CouponDetailsUseIn(coponPayM, this.Sqlca))
                        {
                            this.LastError = "L����ȯ֧��ʧ��";
                            goto updateerr;
                        }
                    }
                   
                }

                //��ֵ
                if (resM.dec_SurplusMoney > 0) 
                {
                    ParaForVipCardChargeM model1 = new ParaForVipCardChargeM();
                    model1.Ing_Pk_VipCardID = masterM.Ing_Fk_VipCardID??0;
                    model1.Ing_Fk_MasterID = masterM.Ing_Pk_MasterID;
                    model1.chargemon = resM.dec_SurplusMoney;
                    model1.chargeType = 6;
                    model1.Reamrk = "΢��Ԥ����ֵ֧��";

                    if (!CardInfoD.VipCardChargeExec(model1, this.Sqlca))
                    {
                        this.LastError = "L��ֵ֧��ʧ��";
                        goto updateerr;
                    }
                    if (!CardInfoD.ExecWeChatPaySurplusMoney(0, masterM.Ing_Pk_MasterID, "9981",resM.dec_SurplusMoney, this.Sqlca))
                    {
                        this.LastError = "L��ֵ֧�������������";
                        goto updateerr;
                    }
                }

              
                ///�޸��ӵ㷿״̬ ��ʹ������ѡ88��,��ΪԤ��״̬
                string strSql = "UPDATE dbo.T_Master SET str_Sta='R' WHERE Ing_Pk_MasterID={0} AND str_Sta='X'";
                strSql = string.Format(strSql, resM.Ing_pkid);

                if (!this.Sqlca.ExecuteNonQuery(strSql))
                {
                    this.LastError = "L�޸��ӵ㷿״̬����";
                    goto updateerr;
                }

                if (conM != null)
                {
                    if (!conD.UpdateRecord<ContinueInterM>(conM, conM.Ing_pkid, this.Sqlca))
                    {
                        this.LastError = "L�޸���ס״̬����";
                        goto updateerr;
                    }
                }
            }
            else if (resM.Ing_type == 1)
            {
                VipCardInfoD cardD = new VipCardInfoD();
                if (!cardD.VipCardChargeExec(chargeM, this.Sqlca))
                {
                    this.LastError = "L��ֵ��ֵʱ����";
                    goto updateerr;
                }


                if (share)
                {
                    if (!shareD.UpdateRecord<ShareRecordM>(shareM,shareM.Ing_Pk_id, this.Sqlca))
                    {
                        this.LastError = "L���������Ϣʱ����";
                        goto updateerr;
                    }

                    if (!cardD.VipCardChargeExec(charge1M, this.Sqlca))
                    {
                        this.LastError = "L����Ӷʱ����";
                        goto updateerr;
                    }
                }
            }

            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();


            WeChatD weD = new WeChatD();
            ///����Ԥ��
            if (resM.Ing_type == 0)
            {
                ///΢������
                WeChatPaySuccessM m1 = new WeChatPaySuccessM();
                m1.Openid = model.openid;
                m1.masterid = resM.Ing_pkid;
                m1.token = resM.str_Token;
                weD.WeChatPaySuccess(m1);
            }
            else if (resM.Ing_type == 1)
            { 
                ///΢��֧���ɹ���֪ͨ
                WeChatChargeMon m2 = new WeChatChargeMon();
                m2.Openid = model.openid;
                m2.first = "��Ա��ֵ΢��֧���ɹ�����";
                m2.keyword1 = string.Format("��{0} Ԫ", chargeM.chargemon);
                m2.keyword2 = DateTime.Now.ToString("yyyy��MM��dd�� HH:mm");
                m2.remark = string.Format("�����ţ�{0}",model.out_trade_no);
                m2.token = resM.str_Token;
                weD.VipOrder(m2);

                VipCardInfoD cardD = new VipCardInfoD();
                VipCardInfoM cardM1 = new VipCardInfoM();
                cardM1 = cardD.GetM<VipCardInfoM>(resM.Ing_pkid);
                if (cardM1 != null)
                {
                    if (!string.IsNullOrEmpty(cardM1.str_wcopenid))
                    {
                        WeChatChargeMon m3 = new WeChatChargeMon();
                        m3.first = string.Format("��Ĵ�ֵ�����{0}�����仯����Ϣ���£�",DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                        m3.keyword1 = string.Format("���ţ�{0}", cardM1.str_VipCard);
                        m3.keyword2 = "��ֵ";
                        m3.keyword3 = string.Format("+ {0}", chargeM.chargemon + chargeM.SendMon);
                        m3.keyword4 = string.Format("{0} Ԫ", cardM1.dec_SurplusMoney);
                        m3.keyword5 = string.Format("{0}", model.out_trade_no);
                        m3.remark = string.Format("{0}", chargeM.Reamrk);
                        m3.Openid = cardM1.str_wcopenid;
                        m3.token = resM.str_Token;
                        weD.ChargeMon(m3);
                    }
                }

                if(share)
                {
                ///��Ա��ֵ�仯��֪ͨ
                    VipCardInfoM cardM2 = new VipCardInfoM();
                    cardM2 = cardD.GetM<VipCardInfoM>(charge1M.Ing_Pk_VipCardID);
                    //Public.LogHelper.LogInfo("������id:"+charge1M.Ing_Pk_VipCardID.ToString());
                    if (cardM2 != null)
                    {
                        if (!string.IsNullOrEmpty(cardM2.str_wcopenid))
                        {
                            WeChatChargeMon m4 = new WeChatChargeMon();
                            m4.first = string.Format("��Ĵ�ֵ�����{0}�����仯����Ϣ���£�", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                            m4.keyword1 = string.Format("���ţ�{0}", cardM2.str_VipCard);
                            m4.keyword2 = "��ֵ";
                            m4.keyword3 = string.Format("+ {0}", ConfigValue.ShareReturnMon);
                            m4.keyword4 = string.Format("{0} Ԫ", cardM2.dec_SurplusMoney);
                            m4.keyword5 = string.Format("{0}", "�Ƽ���Ӷ");
                            m4.remark = string.Format("{0}", "�Ƽ���Ӷ");
                            m4.Openid = cardM2.str_wcopenid;
                            m4.token = resM.str_Token;
                            weD.ChargeMon(m4);
                        }
                    }




                }
            }

            return true;

        updateerr:
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            return false;
        }


    }
}
