using Bee.Web;
using Model;
using Model.Cust;
using Model.Log;
using Model.RoomCenter;
using Model.Shop;
using Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VipCardInfoD : BaseTable
    {
        public VipCardInfoD()
            : base("T_VipCard_Info", "Ing_Pk_VipCardId")
        {
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ��ȡһ����¼
        /// </summary>
        /// <param name="Ing_Pk_VipCardId"></param>
        /// <returns></returns>
        public VipCardInfoM GetOne(int Ing_Pk_VipCardId)
        {
            string strSql = @"SELECT a.*,b.str_CardTypeName FROM T_VipCard_Info a LEFT JOIN T_VipCard_Type b ON a.Ing_VipCardType=b.Ing_CardTypeID
                                    WHERE a.Ing_Pk_VipCardId={0}";
            strSql = string.Format(strSql,Ing_Pk_VipCardId);

            return this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
        }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(VipCardInfoM model)
        {
            return true;
        }

        /// <summary>
        /// ���� ��Ա����Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(VipCardInfoM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev = this.UpdateRecord<VipCardInfoM>(model, model.Ing_Pk_VipCardId);
            model.Ing_Pk_VipCardId = this.lngKeyID;
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
        /// ����openid��ȡ��Ա����¼
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public VipCardInfoM GetVipCardByopenID(string openid)
        {
            if (string.IsNullOrEmpty(openid))
            {
                return null;
            }
            string strSql = "SELECT * FROM T_VipCard_Info a WITH (NOLOCK) WHERE a.Ing_VipCardSta=1 AND a.str_wcopenid=@openid AND isnull(a.str_wcopenid,'')<>''";

            this.Sqlca.AddParameter("@openid",openid);

            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            if (model == null) { }
            this.Sqlca.ClearParameter();

            return model;
        }
        /// <summary>
        /// ����openid��storeid��ȡ��Ա����¼
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public VipCardInfoM GetVipCardByStoreid(string openid,int storeid)
        {
            if (string.IsNullOrEmpty(openid))
            {
                return null;
            }
            string strSql = "SELECT * FROM T_VipCard_Info a WITH (NOLOCK) WHERE a.Ing_VipCardSta=1 AND a.Ing_StoreID=@storeid AND a.str_wcopenid=@openid AND isnull(a.str_wcopenid,'')<>''";

            this.Sqlca.AddParameter("@openid", openid);
            this.Sqlca.AddParameter("@storeid", storeid);

            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            if (model == null) { }
            this.Sqlca.ClearParameter();

            return model;
        }

        /// <summary>
        /// ����unionid��ȡ��Ա
        /// </summary>
        /// <param name="unionid"></param>
        /// <returns></returns>
        public VipCardInfoM GetVipCardByunionID(string unionid)
        {
            if (string.IsNullOrEmpty(unionid))
            {
                return null;
            }
            string strSql = "SELECT * FROM T_VipCard_Info a WITH (NOLOCK) WHERE a.Ing_VipCardSta=1 AND a.str_Unionid=@unionid AND isnull(a.str_Unionid,'')<>''";

            this.Sqlca.AddParameter("@unionid", unionid);

            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            if (model == null) { }
            this.Sqlca.ClearParameter();

            return model;
        }


        /// <summary>
        /// �����ֻ��Ż�ȡ��Ա����¼
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public VipCardInfoM GetCardByMobile(string mobile)
        {
            if (string.IsNullOrEmpty(mobile)) return null;
            string strSql = @"SELECT a.*,c.Ing_Pk_CustID,c.str_mobile,c.str_CusName,c.str_ident FROM T_VipCard_Info a WITH (NOLOCK) INNER JOIN T_Vip_Info b WITH (NOLOCK) ON a.Ing_Fk_VipID=b.Ing_Pk_VipID
                                INNER JOIN T_Cust c WITH (NOLOCK) ON b.Ing_Fk_CustID=c.Ing_Pk_CustID
                                WHERE ISNULL(a.Ing_VipCardSta,0)=1 AND c.str_mobile=@mobile";

            this.Sqlca.AddParameter("@mobile", mobile);

            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();

            return model;
        }
        /// <summary>
        /// �����ֻ��Ż�ȡ��Ա����¼
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public VipCardInfoM GetCardByMobile(string mobile,int storeid)
        {
            if (string.IsNullOrEmpty(mobile)) return null;
            string strSql = @"SELECT a.*,c.Ing_Pk_CustID,c.str_mobile,c.str_CusName,c.str_ident FROM T_VipCard_Info a WITH (NOLOCK) INNER JOIN T_Vip_Info b WITH (NOLOCK) ON a.Ing_Fk_VipID=b.Ing_Pk_VipID
                                INNER JOIN T_Cust c WITH (NOLOCK) ON b.Ing_Fk_CustID=c.Ing_Pk_CustID
                                WHERE ISNULL(a.Ing_VipCardSta,0)=1 AND c.str_mobile=@mobile AND a.Ing_StoreID=@storeid";

            this.Sqlca.AddParameter("@mobile", mobile);
            this.Sqlca.AddParameter("@storeid", storeid);

            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();

            return model;
        }
        /// <summary>
        /// ����֤���Ų��һ�Ա����¼
        /// </summary>
        /// <param name="ident"></param>
        /// <returns></returns>
        public VipCardInfoM GetCardByIdent(string ident)
        {
            string strSql = @"SELECT a.*,c.Ing_Pk_CustID,c.str_mobile,c.str_CusName,c.str_ident FROM T_VipCard_Info a WITH (NOLOCK) INNER JOIN T_Vip_Info b WITH (NOLOCK) ON a.Ing_Fk_VipID=b.Ing_Pk_VipID
                                INNER JOIN T_Cust c WITH (NOLOCK) ON b.Ing_Fk_CustID=c.Ing_Pk_CustID
                                WHERE ISNULL(a.Ing_VipCardSta,0)=1 AND c.str_ident=@ident";

            this.Sqlca.AddParameter("@ident", ident);

            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();

            return model;
        }
        /// <summary>
        /// ����֤���Ų��һ�Ա����¼
        /// </summary>
        /// <param name="ident"></param>
        /// <returns></returns>
        public VipCardInfoM GetCardByIdent(string ident,int storeid)
        {
            string strSql = @"SELECT a.*,c.Ing_Pk_CustID,c.str_mobile,c.str_CusName,c.str_ident FROM T_VipCard_Info a WITH (NOLOCK) INNER JOIN T_Vip_Info b WITH (NOLOCK) ON a.Ing_Fk_VipID=b.Ing_Pk_VipID
                                INNER JOIN T_Cust c WITH (NOLOCK) ON b.Ing_Fk_CustID=c.Ing_Pk_CustID
                                WHERE ISNULL(a.Ing_VipCardSta,0)=1 AND c.str_ident=@ident AND a.Ing_StoreID=@storeid";

            this.Sqlca.AddParameter("@ident", ident);
            this.Sqlca.AddParameter("@storeid", storeid);
            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();

            return model;
        }

        /// <summary>
        /// �󶨻�Ա��
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="cusname"></param>
        /// <param name="openid"></param>
        /// <returns></returns>
        public int BindWeChatExec(string mobile, string cusname, string openid, string ident, int StoreID = 0, string remark = "΢��ע��", string eml = "WeChat")
        {
            string strSql = "EXEC U_WeChat_AddVipInfo @vipName,@pwd,@sex,@zjType,@zjNo,@tel,@fax,@mt,@eml,@addr,@zip,@remark,@StoreID,@openid";

            this.Sqlca.AddParameter("@vipName", cusname);
            this.Sqlca.AddParameter("@pwd", ConfigValue.GetMD5_32("123456"));
            this.Sqlca.AddParameter("@sex", "");
            this.Sqlca.AddParameter("@zjType", "01");
            this.Sqlca.AddParameter("@zjNo", ident);
            this.Sqlca.AddParameter("@tel", mobile);
            this.Sqlca.AddParameter("@fax", "");
            this.Sqlca.AddParameter("@mt", mobile);
            this.Sqlca.AddParameter("@eml", eml);
            this.Sqlca.AddParameter("@addr", "");
            this.Sqlca.AddParameter("@zip", "");
            this.Sqlca.AddParameter("@remark", remark);
            this.Sqlca.AddParameter("@StoreID", StoreID);
            this.Sqlca.AddParameter("@openid", openid);

            int rev = this.Sqlca.GetInt32(strSql);

            this.Sqlca.ClearParameter();
            return rev;
        }


        /// <summary>
        /// ���ݻ�Ա���������Ż�ȯ
        /// </summary>
        /// <param name="vipCardId"></param>
        /// <returns></returns>
        public bool CreateCoupponDetail(CreateCoupponM model, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }

            string strSql = "EXEC U_CreateCouponDetail @StoreId,@VipCardInfoId,@UserName,@CouponTypeId,@ingmonth,@price,@str_Activity";
            this.Sqlca.AddParameter("@StoreId", 0);
            this.Sqlca.AddParameter("@VipCardInfoId", model.vipCardInfoId);
            this.Sqlca.AddParameter("@UserName", "Wechat");
            this.Sqlca.AddParameter("@CouponTypeId", model.coupontypeId);
            this.Sqlca.AddParameter("@ingmonth", model.ingmonth);
            this.Sqlca.AddParameter("@price", model.price);
            this.Sqlca.AddParameter("@str_Activity", model.str_Activity);
            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            this.Sqlca.ClearParameter();
            return rev;
        }


        /// <summary>
        /// �󶨻�Ա��
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="cusname"></param>
        /// <param name="openid"></param>
        /// <returns></returns>
        public bool BindWeChat(string mobile, string cusname, string openid, int StoreID,string ident)
        {
            int rev = BindWeChatExec(mobile, cusname, openid, ident, StoreID,"","");
            //if (rev > 0)
            //{
            //    this.LastError = "Lϵͳ�������Ժ�����";
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// ���ݻ�Ա���Ҽ�¼
        /// </summary>
        /// <param name="vipcard"></param>
        /// <returns></returns>
        public VipCardInfoM GetRecordByVipcard(string vipcard)
        {
            if (string.IsNullOrEmpty(vipcard)) return null;
            string strSql = "SELECT * FROM dbo.T_VipCard_Info a WHERE a.str_VipCard=@vipcard AND  ISNULL(a.Ing_VipCardSta,0)=1 ";
            this.Sqlca.AddParameter("@vipcard", vipcard);
            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();
            return model;
        }
        /// <summary>
        /// ���ݻ�Ա���Ҽ�¼
        /// </summary>
        /// <param name="vipcard"></param>
        /// <returns></returns>
        public VipCardInfoM GetRecordByVipcard(string vipcard,int storeid)
        {
            if (string.IsNullOrEmpty(vipcard)) return null;
            string strSql = "SELECT * FROM dbo.T_VipCard_Info a WHERE a.str_VipCard=@vipcard AND  ISNULL(a.Ing_VipCardSta,0)=1 AND a.Ing_StoreID=@storeid";
            this.Sqlca.AddParameter("@vipcard", vipcard);
            this.Sqlca.AddParameter("@storeid", storeid);
            VipCardInfoM model = this.GetQueryM<VipCardInfoM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();
            return model;
        }
        /// <summary>
        /// �󶨻���������Ա
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="cusname"></param>
        /// <param name="openid"></param>
        /// <param name="yzcode">�û��������֤��</param>
        /// <param name="yzcode1">ϵͳ���͵���֤��   �ֻ�-��֤��   ��md5����</param>
        /// <returns></returns>
        public bool BindOrAddWeChat(string mobile, string cusname, string openid, string yzcode, string yzcode1,int StoreID,string ident)
        {
            if (string.IsNullOrEmpty(mobile))
            {
                this.LastError = "L�ֻ��Ų���Ϊ��";
                return false;
            }
            if (string.IsNullOrEmpty(yzcode))
            {
                this.LastError = "L��֤�벻��Ϊ��";
                return false;
            }

            Public.CommonFunc func = new CommonFunc();
            if (!func.CheckIDCard(ident))
            {
                this.LastError = "L���֤��������";
                return false;
            }
            

            if (string.IsNullOrEmpty(yzcode1))
            {
                yzcode1 = string.Empty;
            }

            ///���Ϊ1�� ��ʾ�����ж���֤��
            if (ConfigValue.VerifyCodeDebug != 1)
            {
                ///��֤��
                string yzstr = string.Format("{0}-{1}", mobile.Trim(), yzcode.Trim());
                yzstr = ConfigValue.GetMD5_32(yzstr);
                if (!yzstr.Trim().Equals(yzcode1.Trim()))
                {
                    this.LastError = "L��֤�����";
                    return false;
                }
            }

          

            VipCardInfoM cardM = GetCardByIdent(ident, StoreID);

            if (cardM == null)
            {
                VipCardInfoM tempmobileM = GetCardByMobile(mobile, StoreID);
                if (tempmobileM != null)
                {
                    this.LastError = "L�ֻ����ѱ�ע��";
                    return false;
                }

                VipCardInfoM m = GetRecordByVipcard(ident,StoreID);
                if (m != null)
                {
                    this.LastError = "L������֤��ע��ɻ�Ա�����ˣ�����ǰ̨����";
                    return false;
                }
                ///������Ա
                return BindWeChat(mobile, cusname, openid, StoreID,ident);
            }

            if (!string.IsNullOrEmpty(cardM.str_wcopenid))
            {
                this.LastError = "L���û��Ѿ��󶨣��뻻һ������";
                return false;
            }

            if (string.IsNullOrEmpty(cardM.str_CusName) || !cardM.str_CusName.Trim().Equals(cusname.Trim()))
            {
                this.LastError = "L���Ѿ������ǵĻ�Ա����������ƥ�䣬�������ǾƵ�ǰ̨�������ϣ��ٽ��а�";
                return false;
            }

            if (string.IsNullOrEmpty(cardM.str_mobile) || !cardM.str_mobile.Trim().Equals(mobile.Trim()))
            {
                this.LastError = "L���Ѿ������ǵĻ�Ա�����ֻ���ƥ�䣬�������ǾƵ�ǰ̨�������ϣ��ٽ��а�";
                return false;
            }
            //cardM.str_Unionid = unionid;
            cardM.str_wcopenid = openid;
            cardM.dt_BindWeChat = DateTime.Now;
            cardM.Ing_FirstMaster = 0;
            cardM.str_paypassword = ConfigValue.GetMD5_32("123456");
            cardM.str_loginPwd = ConfigValue.GetMD5_32("123456");
            if (!this.UpdateRecord<VipCardInfoM>(cardM, cardM.Ing_Pk_VipCardId))
            {
                this.LastError = "L�󶨳ɹ�";
                return false;
            }

            VipCardLogD logD = new VipCardLogD();
            VipCardLogM logM = new VipCardLogM();
            logM.Ing_Fk_VipCardId = cardM.Ing_Pk_VipCardId;
            logM.dt_LogDate = DateTime.Now;
            logM.str_LogDesc = string.Format("��΢��:{0}",openid);
            logM.str_LogType = "��΢��";
            logM.str_UserNo = "Wechat";
            logD.SaveOrUpdate(logM);

            ///�����Ż�ȯ
            //CreateCoupponM mm = new CreateCoupponM();
            //mm.vipCardInfoId = cardM.Ing_Pk_VipCardId;
            //mm.str_Activity = "V��Ա";

            //this.CreateCoupponDetail(mm);

            return true;
        }

        /// <summary>
        /// ��΢�ŵ�ʱ�򣬷�����֤��
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public string WechatBindVirifyCode(string mobile,int yzcode,int storeid)
        {
            SMSSendM sendM = new SMSSendM();
            sendM.Ing_StoreID = 0;
            sendM.Mobile =mobile;
            sendM.SMSContent = "";
            sendM.SMSType = "WechatBind";
            sendM.Sendman = "wechat";
            sendM.Ing_StoreID = storeid;
            WechatBindM model1 = new WechatBindM();
            model1.yzcode = yzcode.ToString().Trim();
           
            SMSSendD sendD = new SMSSendD();
            //string rev = ConfigValue.GetMD5_32(string.Format("{0}-{1}",mobile.Trim(),yzcode.ToString().Trim()));
            //if (ConfigValue.VerifyCodeDebug == 1)
            //{
            //    ///����ģʽ
            //    return rev;
            //}
            //if (sendD.GetSendContent<WechatBindM>(sendM, model1))
            //{
                
            //}
            //else
            //{
            //    this.LastError = sendD.LastError;
            //    rev = string.Empty;
            //}


            return sendD.GetSendContent<WechatBindM>(sendM, model1);
        }
        public Boolean VirifyPwd(string pwd, int vipcardid)
        {
            VipCardInfoM cardInfoM = new VipCardInfoM();
            cardInfoM = GetOne(vipcardid);
            pwd = ConfigValue.GetMD5_32(pwd);
            if (pwd.Equals(cardInfoM.str_paypassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean VirifyVipPwd(string pwd, int vipcardid)
        {
            VipCardInfoM cardInfoM = new VipCardInfoM();
            cardInfoM = GetOne(vipcardid);
            pwd = ConfigValue.GetMD5_32(pwd);
            if (pwd.Equals(cardInfoM.str_loginPwd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ChangePwd(string pwd, int vipcardid)
        {
            VipCardInfoM cardInfoM = new VipCardInfoM();
            cardInfoM = GetOne(vipcardid);
            pwd = ConfigValue.GetMD5_32(pwd);
            string strSql = "UPDATE dbo.T_VipCard_Info SET str_paypassword='{1}' WHERE Ing_Pk_VipCardId={0}";
            strSql = string.Format(strSql, vipcardid, pwd);

            if (!this.Sqlca.ExecuteNonQuery(strSql))
            {
                this.LastError = "L�޸Ĵ�ֵ֧���������";
                return false;
            }
            return true;
        }
        public Boolean ChangeVipPwd(string pwd, int vipcardid)
        {
            VipCardInfoM cardInfoM = new VipCardInfoM();
            cardInfoM = GetOne(vipcardid);
            pwd = ConfigValue.GetMD5_32(pwd);
            string strSql = "UPDATE dbo.T_VipCard_Info SET str_loginPwd='{1}' WHERE Ing_Pk_VipCardId={0}";
            strSql = string.Format(strSql, vipcardid, pwd);

            if (!this.Sqlca.ExecuteNonQuery(strSql))
            {
                this.LastError = "L�޸Ļ�Ա�������";
                return false;
            }
            return true;
        }
        /// <summary>
        /// ��ֵ����ʹ�ã�������֤��
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public string UsePayPwdVirifyCode(string mobile)
        {
            SMSSendM sendM = new SMSSendM();
            sendM.Ing_StoreID = 0;
            sendM.Mobile = mobile;
            sendM.SMSContent = "";
            sendM.SMSType = "WechatBind";
            sendM.Sendman = "wechat0";

            ///�����
            Random rd = new Random();
            int yzcode = rd.Next(1000, 9999);


            WechatBindM model1 = new WechatBindM();
            model1.yzcode = yzcode.ToString().Trim();

            SMSSendD sendD = new SMSSendD();

            string rev = ConfigValue.GetMD5_32(string.Format("{0}-{1}", mobile.Trim(), yzcode.ToString().Trim()));
            if (ConfigValue.VerifyCodeDebug == 1)
            {
                ///����ģʽ
                return rev;
            }
            if (sendD.SendMsg<WechatBindM>(sendM, model1))
            {

            }
            else
            {
                this.LastError = sendD.LastError;
                rev = string.Empty;
            }


            return rev;
        }

        /// <summary>
        /// �޸Ĵ�ֵ֧������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdatePayPassword(UpdatePayPasswordM model)
        {
            if (model == null)
            {
                this.LastError = "L����Ϊ��";
                return false;
            }
            string mobile = model.mobile;
            if (string.IsNullOrEmpty(mobile))
            {
                this.LastError = "L�ֻ��Ų���Ϊ��";
                return false;
            }
            string yzcode = model.yzcode;
            if (string.IsNullOrEmpty(yzcode))
            {
                this.LastError = "L��֤�벻��Ϊ��";
                return false;
            }

            string yzcode1 = model.yzcode1;
            if (string.IsNullOrEmpty(yzcode1))
            {
                yzcode1 = string.Empty;
            }

            ///���Ϊ1�� ��ʾ�����ж���֤��
            if (ConfigValue.VerifyCodeDebug != 1)
            {
                ///��֤��
                string yzstr = string.Format("{0}-{1}", mobile.Trim(), yzcode.Trim());
                yzstr = ConfigValue.GetMD5_32(yzstr);
                if (!yzstr.Trim().Equals(yzcode1.Trim()))
                {
                    this.LastError = "L��֤�����";
                    return false;
                }
            }

            string pwd = model.password;
            if (string.IsNullOrEmpty(pwd))
            {
                this.LastError = "L���벻��Ϊ��";
                return false;
            }
            pwd = ConfigValue.GetMD5_32(pwd);

            string strSql = "UPDATE dbo.T_VipCard_Info SET str_paypassword='{1}' WHERE Ing_Pk_VipCardId={0}";
            if (model.type == 1) strSql = "UPDATE dbo.T_VipCard_Info SET str_loginPwd='{1}' WHERE Ing_Pk_VipCardId={0}";
            strSql = string.Format(strSql,model.VipCardID,pwd);

            if (!this.Sqlca.ExecuteNonQuery(strSql))
            {
                this.LastError = "L�޸Ĵ�ֵ֧���������";
                return false;
            }

            return true;
        }


        /// <summary>
        /// �޸��ֻ�����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateMobile(MyInfoM model)
        {
            if (model == null)
            {
                this.LastError = "L��������";
                return false;
            }
            if (string.IsNullOrEmpty(model.mobile))
            {
                this.LastError = "L�ֻ��Ų���Ϊ��";
                return false;
            }
            if (string.IsNullOrEmpty(model.yzcode))
            {
                this.LastError = "L��֤�벻��Ϊ��";
                return false;
            }            

            if (string.IsNullOrEmpty(model.yzcode1))
            {
                model.yzcode1 = string.Empty;
            }

            ///���Ϊ1�� ��ʾ�����ж���֤��
            if (ConfigValue.VerifyCodeDebug != 1)
            {
                ///��֤��
                string yzstr = string.Format("{0}-{1}", model.mobile.Trim(), model.yzcode.Trim());
                yzstr = ConfigValue.GetMD5_32(yzstr);
                if (!yzstr.Trim().Equals(model.yzcode1.Trim()))
                {
                    this.LastError = "L��֤�����";
                    return false;
                }
            }


            string strSql = @"SELECT TOP 1 a.Ing_Fk_CustID FROM dbo.T_Vip_Info a INNER JOIN dbo.T_VipCard_Info b ON a.Ing_Pk_VipID=b.Ing_Fk_VipID 
                                WHERE b.str_wcopenid='{0}'";
            strSql = string.Format(strSql,model.openid);

            int custid = this.Sqlca.GetInt32(strSql);
            if (custid != model.custid)
            {
                this.LastError = "L�������ڳ����޸ı��˵��ֻ�Ŷ�����Ժ�����";
                return false;
            }
            

            strSql = "UPDATE dbo.T_Cust SET str_mobile='{1}' WHERE Ing_Pk_CustID={0}";
            strSql = string.Format(strSql,model.custid,model.mobile);
            if (!this.Sqlca.ExecuteNonQuery(strSql))
            {
                this.LastError = "L�޸��ֻ�����ʱ����";
                return false;
            }

            

            return true;
        }

        /// <summary>
        /// �����
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public bool UnBind(UnBindM model)
        {
            if (model == null)
            {
                this.LastError = "L��������";
                return false;
            }
            if (string.IsNullOrEmpty(model.mobile))
            {
                this.LastError = "L�ֻ��Ų���Ϊ��";
                return false;
            }
            if (string.IsNullOrEmpty(model.yzcode))
            {
                this.LastError = "L��֤�벻��Ϊ��";
                return false;
            }

            if (string.IsNullOrEmpty(model.yzcode1))
            {
                model.yzcode1 = string.Empty;
            }

            ///���Ϊ1�� ��ʾ�����ж���֤��
            if (ConfigValue.VerifyCodeDebug != 1)
            {
                ///��֤��
                string yzstr = string.Format("{0}-{1}", model.mobile.Trim(), model.yzcode.Trim());
                yzstr = ConfigValue.GetMD5_32(yzstr);
                if (!yzstr.Trim().Equals(model.yzcode1.Trim()))
                {
                    this.LastError = "L��֤�����";
                    return false;
                }
            }

            string strSql = "update T_VipCard_Info set str_wcopenid='' where str_wcopenid='{0}'";
            strSql = string.Format(strSql,model.openid);
            if (!this.Sqlca.ExecuteNonQuery(strSql))
            {
                this.LastError = "L�����ʱ����";
                return false;
            }

            return true;
        }


        /// <summary>
        /// ��Ա��ֵ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool VipCardChargeExec(ParaForVipCardChargeM model, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }
            string strSql = "EXEC U_T_VipCard_Charge @Ing_StoreID,@Ing_Pk_VipCardID,@Ing_Fk_MasterID,@chargeType,@chargemon,@username,@Reamrk,@SendMon,@PayType,@Bdate,@pk_VCMID  output";

            this.Sqlca.AddParameter("@Ing_StoreID", 0);
            this.Sqlca.AddParameter("@Ing_Pk_VipCardID", model.Ing_Pk_VipCardID);
            this.Sqlca.AddParameter("@Ing_Fk_MasterID", model.Ing_Fk_MasterID);
            this.Sqlca.AddParameter("@chargeType", model.chargeType);
            this.Sqlca.AddParameter("@chargemon", model.chargemon);
            this.Sqlca.AddParameter("@username", "WeChat");
            this.Sqlca.AddParameter("@Reamrk", model.Reamrk);
            this.Sqlca.AddParameter("@SendMon", model.SendMon);
            this.Sqlca.AddParameter("@PayType", model.PayType);
            this.Sqlca.AddParameter("@Bdate", DateTime.Now.Date);
            //this.Sqlca.AddParameter("@str_CheckOutNo", model.str_CheckOutNo);
            this.Sqlca.AddParameter("@pk_VCMID", "", ParameterDirection.Output);

            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            int pk_VCMID = this.Sqlca.GetParameterIntValue("@pk_VCMID");

            this.Sqlca.ClearParameter();
            return rev;
        }
        /// <summary>
        /// ��ȡ����ң�����Ż�ȯ
        /// </summary>
        /// <param name="vipCardInfoId"></param>
        /// <returns></returns>

        public bool CreateSHCoupon(int vipCardInfoId)
        {
            //���ݻ�Ա��id��
            VipCardInfoD cardInfoD = new VipCardInfoD();
            CouponDetailsD couponDetailD = new CouponDetailsD();
            VipCardInfoM cardInfoM = new VipCardInfoM();
            cardInfoM = cardInfoD.GetM<VipCardInfoM>(vipCardInfoId);
            if (cardInfoM == null)
            {
                this.LastError = "L��ǰ��Ա��������";
                return false;
            }
            if (cardInfoM.Ing_SHActivity == 1)
            {
                this.LastError = "L������ȡ���Ż�ȯ";
                return false;
            }
            //��������
            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }
            CreateCoupponM model = new CreateCoupponM();
            model.coupontypeId = 0;
            model.ingmonth = 12;
            model.price = 40;
            model.str_Activity = ConfigValue.SHActivity;
            model.vipCardInfoId = vipCardInfoId;
            if (!couponDetailD.CreateCoupponDetail(model, this.Sqlca))
            {
                this.LastError = "L�Ż�ȯ����ʧ��";
                goto updateerr;
            }
            cardInfoM.Ing_SHActivity = 1;
            if (!cardInfoD.UpdateRecord<VipCardInfoM>(cardInfoM, cardInfoM.Ing_Pk_VipCardId, this.Sqlca)){
                this.LastError = "L���»�Ա��Ϣʧ��";
                goto updateerr;
            }
            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();
            return true;
            updateerr:
            if (string.IsNullOrEmpty(this.LastError))
            {
                this.LastError = this.Sqlca.LastError;
            }
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            return false;
        }
        /// <summary>
        /// ���ֶһ��Ż�ȯ
        /// </summary>
        /// <param name="vipCardInfoId"></param>
        /// <param name="couponTypeId"></param>
        /// <returns></returns>
        public bool IntegralExchangeCoupon(WechatCouponM model1)
        {
            #region ���
            if(model1==null)
            {
               this.LastError="L����Ϊ��";
                return false;
            }
            int vipCardInfoId = model1.VipcardID;
            int couponTypeId = model1.Ing_CouponTypeID;
            int Number = model1.Number;

            if (Number == 0)
            {
                this.LastError = "L�����������0";
                return false;
            }

            //����id����Ż�ȯ����
            CouponTypeD typeD = new CouponTypeD();
            CouponTypeM typeM = new CouponTypeM();
            typeM = typeD.GetM<CouponTypeM>(couponTypeId);
            if (typeM == null)
            {
                this.LastError = "L��ǰ�Ż�ȯ������";
                return false;
            }

            if (typeM.Ing_IntegralBuy == 0)
            {
                this.LastError = "L��ǰ�Ż�ȯ��֧�֣����ֶһ�";
                return false;
            }

            //���ݻ�Ա��id���������
            VipCardInfoD cardInfoD = new VipCardInfoD();
            VipCardInfoM cardInfoM = new VipCardInfoM();
            cardInfoM = cardInfoD.GetM<VipCardInfoM>(vipCardInfoId);
            if (cardInfoM == null)
            {
                this.LastError = "L��ǰ��Ա��������";
                return false;
            }
            if (cardInfoM.Ing_SurplusIntegral == 0)
            {
                this.LastError = "L����ǰû�л���";
            }

            if (cardInfoM.Ing_SurplusIntegral < typeM.Ing_IntegralBuy)
            {
                this.LastError = string.Format("L���Ļ��ֲ���!��ǰ���Ҫ{0}���֣���ֻ��{1}����", typeM.Ing_IntegralBuy, cardInfoM.Ing_SurplusIntegral);
                return false;
            }

            //���ݻ�Աid���������id
            VipInfoD infoD = new VipInfoD();
            VipInfoM infoM = new VipInfoM();
            infoM = infoD.GetM<VipInfoM>(cardInfoM.Ing_Fk_VipID);
            if (infoM == null)
            {
                this.LastError = "L��ǰ��Ա��Ϣ������";
                return false;
            }

            //����id��ѯ����
            CustD custD = new CustD();
            CustM custM = new CustM();
            custM = custD.GetM<CustM>(infoM.Ing_Fk_CustID);
            if (custM == null)
            {
                this.LastError = "L��ǰ����������";
                return false;
            }
            #endregion


            //�����ֶһ�������ֵ
            ParaForVipCardChargeM model = new ParaForVipCardChargeM();
            model.Ing_Pk_VipCardID = cardInfoM.Ing_Pk_VipCardId;
            model.chargemon = typeM.Ing_IntegralBuy;
            model.chargeType = 98;
            model.Reamrk = "���ֶһ��Ż�ȯ";

            //��������
            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }

            for (int num = 0; num < Number; num++)
            {

                //���ֶһ�
                if (!VipCardChargeExec(model, this.Sqlca))
                {
                    this.LastError = "L���ֶһ�ʧ��";
                    goto updateerr;
                }

                //�����Ż�ȯ
                CouponDetailsD _CoupDeatilD = new CouponDetailsD();
                CreateCoupponM coupponM = new CreateCoupponM();
                coupponM.vipCardInfoId = vipCardInfoId;
                coupponM.coupontypeId = couponTypeId;
                coupponM.ingmonth = 6;
                if (!_CoupDeatilD.CreateCoupponDetail(coupponM, this.Sqlca))
                {
                    this.LastError = "L�Ż�ȯ����ʧ��";
                    goto updateerr;
                }

                //������־
                MasterLogM logM = new MasterLogM();
                MasterLogD logD = new MasterLogD();
                logM.dt_LogDate = DateTime.Now;
                logM.Ing_Fk_MasterID = 0;
                logM.Ing_Fk_CustID = 0;
                logM.Ing_StoreID = 0;
                logM.str_FunC = "���ֶһ��Ż�ȯ";
                logM.str_LogMessage = string.Format("����{0}���֣��һ���{1}", typeM.Ing_IntegralBuy, typeM.str_PaperName);
                logM.str_LogException = "�ɹ�";
                logM.str_Logger = "WeChat";
                logM.str_RoomNo = string.Empty;
                logM.str_LogPageClass = "���ֶһ��Ż�ȯ";
                logM.str_LogThread = "�ɹ�";
                logM.str_LogLevel = "���ֶһ��Ż�ȯ";
                logM.str_CusName = custM.str_CusName;
                logM.str_Pk_Accnt = string.Empty;
                if (!logD.UpdateRecord<MasterLogM>(logM, 0, this.Sqlca))
                {
                    this.LastError = "L����������־ʧ��";
                    goto updateerr;
                }
            }



            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();
            return true;

        updateerr:
            if (string.IsNullOrEmpty(this.LastError))
            {
                this.LastError = this.Sqlca.LastError;
            }
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            return false;
        }

        /// <summary>
        /// ΢��֧����鴢ֵ֧�� �� �ֿ�ȯ֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckWXPay(ParaForCoponPayM model)
        {

            MasterD masD = new MasterD();
            MasterM masM = new MasterM();
            masM = masD.GetM<MasterM>(model.MasterID);
            if (masM == null)
            {
                this.LastError = "L����������";
                return false;
            }
            VipCardInfoM cardM = this.GetM<VipCardInfoM>(masM.Ing_Fk_VipCardID ?? 0);
            if (cardM == null)
            {
                this.LastError = "L��Ա������";
                return false;
            }

            //if (!CheckFirst(model, masM, cardM))
            //{
            //    this.LastError = "L��ס����ʹ���Ż�ȯ";
            //    return false;
            //}

            ///�ȼ��ֿ�ȯ֧��
            if (model.ListPagerID.Count > 0)
            {
                CouponDetailsD couD = new CouponDetailsD();
                if (!couD.CheckCouponPay(model))
                {
                    this.LastError = couD.LastError;
                    return false;
                }
            }

            ///��������һЩ�ӵ㷿���ж�
            if (!masM.str_InterType.ToUpper().Trim().Equals("HOUR"))
            {
                goto Common;
            }

            if (!masM.str_Channel.ToUpper().Trim().Equals("WEC"))
            {
                this.LastError = "ֻ����΢����Ԥ�����ӵ㷿����ʹ������֧��";
                return false;
            }

            if (!masM.str_Sta.ToUpper().Equals("X"))
            {
                this.LastError = "��״̬���ӵ㷿�Ѿ�����������֧��";
                return false;
            }

            if (!masM.dt_restime.HasValue)
            {
                this.LastError = "û��Ԥ��ʱ����ӵ㷿�Ѿ�����������֧��";
                return false;
            }

            if (masM.dt_restime.Value.AddMinutes(30) < DateTime.Now)
            {
                this.LastError = "������Сʱ���ӵ㷿�Ѿ�����������֧��";
                return false;
            }

            Common:
            if (model.dec_SurplusMoney == 0 && model.dec_IntegralExchangeTotalMoney == 0)
            {
                goto success;
            }
   
            VipCardInfoM m = this.GetM<VipCardInfoM>(model.Ing_Pk_VipCardId);
            if (m == null)
            {
                this.LastError = "L�����ڸû�Ա";
                return false;
            }

            ///��ֵ֧��
            if (model.dec_SurplusMoney > 0)
            {                
                if (m.dec_SurplusMoney < model.dec_SurplusMoney)
                {
                    this.LastError = "L��ֵ����";
                    return false;
                }
            }

            //΢��Ǯ��
            if (model.dec_WechatPrice > 0) 
            {
                if (m.dec_WechatPrice < model.dec_WechatPrice) {
                    this.LastError = "L΢��Ǯ������";
                    return false;
                }
            }

            ///���ֶһ�
            if (model.Ing_IntegralExchangeTotal > 0)
            {
                if (m.Ing_SurplusIntegral < model.Ing_IntegralExchangeTotal)
                {
                    this.LastError = "L���û��ֲ���";
                    return false;
                }
            }


         success:
            return true;
        }

        /// <summary>
        /// ����Ƿ�������ס�Ż�����
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckFirst(ParaForCoponPayM model, MasterM masM = null, VipCardInfoM cardM=null) 
        {
            MasterD masD = new MasterD();
            if (masM == null) 
            {
                masM = masD.GetM<MasterM>(model.MasterID);
            }
            if(masM==null)
            {
              this.LastError="L����������,֧��ʧ��";
              return false;
            }
            if (cardM == null) 
            {
                cardM = this.GetM<VipCardInfoM>(masM.Ing_Fk_VipCardID ?? 0);
            }
            if (cardM == null)
            {
                this.LastError = "L��Ա������,֧��ʧ��";
                return false;
            }
            bool isFirst = false;
            RoomTypeD roomD = new RoomTypeD();
            RoomTypeM roomM = roomD.GetRoomType(masM.Ing_StoreID ?? 0, masM.str_RoomType);
            if ((!cardM.Ing_FirstMaster.HasValue || cardM.Ing_FirstMaster.Value == 0 || cardM.Ing_FirstMaster.Value == masM.Ing_Pk_MasterID)
               && roomM != null && roomM.dec_FirstLivePrice.HasValue &&
                roomM.dec_FirstLivePrice.Value > 0 && (((masM.dt_ArrDate ?? DateTime.Now).Date - DateTime.Now.Date).Days == 0 && "I".Equals(masM.str_Sta) || "R".Equals(masM.str_Sta))
                &&roomM.dec_FirstLivePrice==masM.dec_ActualRate)
            {
                isFirst = true;//502484,��ס����id:502484,��ǰ����:DBR,��ǰ���ͼ۸�:88
            }
            if (!isFirst) //���û����ס�Ż�,�ж��Ƿ�ʹ������ѡ88
            {
                CouponDetailsD coupondD = new CouponDetailsD();
                CouponDetailsM coupondM = coupondD.GetCouponDetail(model.MasterID);
                if (coupondM != null && coupondM.dt_useTime.HasValue &&
                    (coupondM.dt_useTime.Value.Date - DateTime.Now.Date).Days == 0) //˵����������ѡ88
                {
                    isFirst = true;
                }

            }
            if (isFirst)
            {
                if (!string.IsNullOrEmpty(model.PagerIDs)&&model.PagerIDs.Contains("0,"))
                {
                    this.LastError = "L��ס����ʹ���Ż�ȯ";
                    return false;
                }
                if (model.Ing_IntegralExchangeTotal > 0)
                {
                    this.LastError = "L��ס����ʹ�û���";
                    return false;
                }
            }
            Public.LogHelper.LogInfo(string.Format("֧����֤�ɹ�,��ǰ����id:{0},��ֵ���:{1},΢��Ǯ�����:{2},�Ż�ȯid:{3}({4}),�Ƿ�����ס�Ż�:{5},��Ա��id:{6}",
                masM.Ing_Pk_MasterID, model.dec_SurplusMoney, model.dec_WechatPrice, model.PagerIDs, model.PagerID, isFirst, masM.Ing_Fk_VipCardID));
            return true;
        }


        /// <summary>
        /// ΢��֧�� ��ֵ֧�� �� �ֿ�ȯ֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool WXPay(ParaForCoponPayM model)
        {
            if (!CheckWXPay(model))
            {
                return false;
            }
            ContinueInterD conD = new ContinueInterD();
            ContinueInterM conM = new ContinueInterM();
            conM = conD.GetRecord(model.MasterID, 0);
            if (conM != null)
            {
                conM.Ing_PayType = 1;
            }

            //��������
            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }
            ///�ȼ��ֿ�ȯ֧��
            if (model.ListPagerID.Count > 0)
            {
               
                string temp = string.Empty;
                CouponDetailsD couD = new CouponDetailsD();
                foreach (int pagerid in model.ListPagerID)
                {
                    temp += pagerid + "|";
                    model.PagerID = pagerid;
                    if (!couD.CouponDetailsUseIn(model, this.Sqlca))
                    {
                        this.LastError = "L����ȯ֧��ʧ��";
                        goto updateerr;
                    }
                }
            }
            string strRemark = string.Empty;

            if (model.dec_SurplusMoney > 0)
            {       
                //΢��Ԥ����ֵ֧��
                ParaForVipCardChargeM model1 = new ParaForVipCardChargeM();
                model1.Ing_Pk_VipCardID = model.Ing_Pk_VipCardId;
                model1.Ing_Fk_MasterID = model.MasterID;
                model1.chargemon = model.dec_SurplusMoney;
                model1.chargeType = 6;
                model1.Reamrk = "΢��Ԥ����ֵ֧��";
                if (!VipCardChargeExec(model1, this.Sqlca))
                {
                    this.LastError = "L��ֵ֧��ʧ��";
                    goto updateerr;
                }


                if (!ExecWeChatPaySurplusMoney(0, model.MasterID, "9981", model.dec_SurplusMoney, this.Sqlca))
                {
                    this.LastError = "L��ֵ֧�������������";
                    goto updateerr;
                }
                strRemark += string.Format("|��ֵ֧��:{0}Ԫ",model.dec_SurplusMoney);
            }

            if (model.dec_IntegralExchangeTotalMoney > 0)
            {
                //΢��Ԥ�����ֶһ�
                ParaForVipCardChargeM model1 = new ParaForVipCardChargeM();
                model1.Ing_Pk_VipCardID = model.Ing_Pk_VipCardId;
                model1.Ing_Fk_MasterID = model.MasterID;
                model1.chargemon = model.Ing_IntegralExchangeTotal;
                model1.chargeType = 98;
                model1.Reamrk = "΢��Ԥ�����ֶһ�";

                if (!VipCardChargeExec(model1, this.Sqlca))
                {
                    this.LastError = "L���ֶһ�ʧ��";
                    goto updateerr;
                }


                if (!ExecWeChatPayIntegral(0, model.MasterID, "9971", model.dec_IntegralExchangeTotalMoney, this.Sqlca))
                {
                    this.LastError = "L���ֶһ������������";
                    goto updateerr;
                }
                strRemark += string.Format("|���ֶһ�:{0}Ԫ", model.dec_IntegralExchangeTotalMoney);
            }

            if (model.dec_WechatPrice > 0) 
            {
                if (!ExecWeChatPaySurplusMoney(0, model.MasterID, "9906", model.dec_WechatPrice, this.Sqlca))
                {
                    this.LastError = "L΢��Ǯ��֧�������������";
                    goto updateerr;
                }
                WechatWalletD walletD = new WechatWalletD();
                WechatWalletM walletM = new WechatWalletM { 
                     Ing_Fk_MasterId=model.MasterID,
                     Ing_Fk_VipcardId=model.Ing_Pk_VipCardId,
                     Ing_Type=1,
                     dec_Price=model.dec_WechatPrice,
                     str_Creator="Wechat",
                     str_Memo="΢��Ԥ��",
                     dt_Create=DateTime.Now
                };
                if (!walletD.UpdateRecord<WechatWalletM>(walletM, walletM.Ing_PKID, this.Sqlca)) 
                {
                    this.LastError = "L΢��Ǯ��֧����¼�������";
                    goto updateerr;
                }
                string strSql1 = "UPDATE T_VipCard_Info SET dec_WechatPrice=dec_WechatPrice-{0} WHERE Ing_Pk_VipCardId={1} and dec_WechatPrice>={0}";
                strSql1=string.Format(strSql1, model.dec_WechatPrice, model.Ing_Pk_VipCardId);
                if (!this.Sqlca.ExecuteNonQuery(strSql1)) 
                {
                    this.LastError = "L�Ѿ�֧��,�����ظ�֧��";
                    goto updateerr;
                }
                strRemark += string.Format("|΢��Ǯ��֧��:{0}Ԫ", model.dec_WechatPrice);
            }
            //������־
            if (!string.IsNullOrEmpty(strRemark)) 
            {
                string strSql1 = "UPDATE dbo.T_Master SET str_memo=str_memo+'{0}' WHERE Ing_Pk_MasterID={1}";
                strSql1 = string.Format(strSql1, strRemark, model.MasterID);
                if (!this.Sqlca.ExecuteNonQuery(strSql1))
                {
                    this.LastError = "L����������־����";
                    goto updateerr;
                }
            }

            ///�޸��ӵ㷿״̬
            string strSql = "UPDATE dbo.T_Master SET str_Sta='R' WHERE Ing_Pk_MasterID={0} AND str_Sta='X'";
            strSql = string.Format(strSql,model.MasterID);

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

            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();


            if (model.dec_SurplusMoney > 0||model.dec_WechatPrice>0)
            {
                VipCardInfoD cardD = new VipCardInfoD();
                VipCardInfoM cardM2 = new VipCardInfoM();
                cardM2 = cardD.GetM<VipCardInfoM>(model.Ing_Pk_VipCardId);
                    //Public.LogHelper.LogInfo("������id:"+charge1M.Ing_Pk_VipCardID.ToString());
                    if (cardM2 != null)
                    {
                        if (!string.IsNullOrEmpty(cardM2.str_wcopenid))
                        {

                            WeChatD weD = new WeChatD();
                            WeChatChargeMon m2 = new WeChatChargeMon();
                            m2.Openid = cardM2.str_wcopenid;
                            m2.keyword1 = "���ѳɹ�";
                            m2.keyword2 = DateTime.Now.ToString("yyyy��MM��dd�� HH:mm");
                            m2.token = model.token;
                            if (model.dec_SurplusMoney > 0) 
                            {
                                m2.first = "��ֵ����";
                                m2.remark = string.Format("���Ѿ��ɹ���΢����ʹ�ô�ֵ֧��������{0}Ԫ�����{1}Ԫ", model.dec_SurplusMoney, cardM2.dec_SurplusMoney);
                                weD.VipOrder(m2);
                            }
                            if (model.dec_WechatPrice > 0) 
                            {
                                m2.first = "Ǯ������";
                                m2.remark = string.Format("���Ѿ��ɹ���΢����ʹ��Ǯ��֧��������{0}Ԫ�����{1}Ԫ", model.dec_WechatPrice, cardM2.dec_WechatPrice);
                                weD.VipOrder(m2);
                            }
                        }
                    }



                
            }

            return true;

        updateerr:
            if (string.IsNullOrEmpty(this.LastError))
            {
                this.LastError = this.Sqlca.LastError;
            }
        Public.LogHelper.LogInfo(string.Format("΢��֧��ʧ��(�ǻص�),����id:{0},�Ż�ȯid{1},ʧ��ԭ��:{2}", model.MasterID, string.Join(",", model.ListPagerID), this.LastError));
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            return false;
        }

        /// <summary>
        /// ��ֵ֧��/΢��Ǯ����������
        /// </summary>
        /// <returns></returns>
        public bool ExecWeChatPaySurplusMoney(int Ing_StoreID, int Ing_Fk_MasterID, string pccode, decimal SurplusMoney, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }
            string strSql = "EXEC U_WeChatPay_SurplusMoney @Ing_StoreID,@Ing_Fk_MasterID,@pccode,@Shift,@Empno,@SurplusMoney";

            this.Sqlca.AddParameter("@Ing_StoreID", Ing_StoreID);
            this.Sqlca.AddParameter("@Ing_Fk_MasterID", Ing_Fk_MasterID);
            this.Sqlca.AddParameter("@pccode", pccode);
            this.Sqlca.AddParameter("@Shift", "");
            this.Sqlca.AddParameter("@Empno", "Wechat");
            this.Sqlca.AddParameter("@SurplusMoney", SurplusMoney);

            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            if (!rev)
            {
                this.LastError = this.Sqlca.LastError;

            }
            this.Sqlca.ClearParameter();
            return rev;
        }


        /// <summary>
        /// ���ֶһ� ��������
        /// </summary>
        /// <returns></returns>
        public bool ExecWeChatPayIntegral(int Ing_StoreID, int Ing_Fk_MasterID, string pccode, decimal SurplusMoney, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }
            string strSql = "EXEC U_WeChatPay_Integral @Ing_StoreID,@Ing_Fk_MasterID,@pccode,@Shift,@Empno,@SurplusMoney";

            this.Sqlca.AddParameter("@Ing_StoreID", Ing_StoreID);
            this.Sqlca.AddParameter("@Ing_Fk_MasterID", Ing_Fk_MasterID);
            this.Sqlca.AddParameter("@pccode", pccode);
            this.Sqlca.AddParameter("@Shift", "");
            this.Sqlca.AddParameter("@Empno", "Wechat");
            this.Sqlca.AddParameter("@SurplusMoney", SurplusMoney);

            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            if (!rev)
            {
                this.LastError = this.Sqlca.LastError;

            }
            this.Sqlca.ClearParameter();
            return rev;
        }

        /// <summary>
        /// ��ֵ֧��ʱ����֤��ֵ֧������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool VerifyPayPWD(VerifyPayPWDM model)
        {
            if (model == null)
            {
                this.LastError = "L�����������Ժ�����";
                return false;
            }
            if (string.IsNullOrEmpty(model.str_paypassword))
            {
                this.LastError = "Lû�����ô�ֵ֧�����룬���ܽ���֧��";
                return false;
            }
            if (string.IsNullOrEmpty(model.str_pwd))
            {
                this.LastError = "L�����봢ֵ֧������";
                return false;
            }
            if (!Public.ConfigValue.GetMD5_32(model.str_pwd).Equals(model.str_paypassword))
            {
                this.LastError = "L��ֵ֧�������������������";
                return false;
            }
            return true;
        }

        /// <summary>
        /// ��ȡ�̳ǻ�Ա
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShopVipcardM GetShopVipCard(ShopVipcardM model) 
        {
            string strSql = @"SELECT TOP 1 c.str_Nickname as nickname,a.dec_SurplusMoney,a.dec_WechatPrice,a.Ing_SurplusIntegral as Ing_TotalIntegral,c.str_ident as idcard,
                              c.Ing_Pk_CustID as custid,c.str_CusName as name ,c.str_mobile as mobile,a.str_wcopenid as openid,
                                a.Ing_VipCardType as [level],a.Ing_Pk_VipCardId as id from T_VipCard_Info a
                                left JOIN T_Vip_Info b
                                on a.Ing_Fk_VipID=b.Ing_Pk_VipID
                                left JOIN T_Cust c
                                on b.Ing_Fk_CustID=c.Ing_Pk_CustID
                                WHERE 1=1 {0}
                                ORDER by a.Ing_Pk_VipCardId DESC";
            string where = string.Empty;
            if (model.id.HasValue && string.IsNullOrEmpty(where)) 
            {
                where += " and a.Ing_Pk_VipCardId="+model.id.Value;
            }

            if (!string.IsNullOrEmpty(model.openid)&&string.IsNullOrEmpty(where)) 
            {
                where += " and a.str_wcopenid =@openid";
                this.Sqlca.AddParameter("@openid",model.openid);
            }

            if (!string.IsNullOrEmpty(model.mobile) && string.IsNullOrEmpty(where)) 
            {
                where += " and  c.str_mobile =@mobile";
                this.Sqlca.AddParameter("@mobile", model.mobile);
            }

            if (string.IsNullOrEmpty(where)) where = "and 1=2";

            strSql = string.Format(strSql,where);

            ShopVipcardM cardM = this.GetQueryM<ShopVipcardM>(strSql).FirstOrDefault();
            this.Sqlca.ClearParameter();
            return cardM;
        }

        /// <summary>
        /// �̳��޸Ļ�Ա��Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool EditUserInfo(ShopVipcardM model)
        {
            ShopVipcardM mm = this.GetShopVipCard(model);
            if (mm == null) 
            {
                throw new MessageException("��Ա������");
            }

            CustD custD = new CustD();
            CustM custM = custD.GetM<CustM>(mm.custid);
            if (custM == null) 
            {
                throw new MessageException("����������");
            }

            if (!string.IsNullOrEmpty(mm.idcard) && !string.IsNullOrEmpty(model.idcard) && !mm.idcard.Equals(model.idcard)) 
            {
                VipCardInfoM cardM = GetCardByIdent(model.idcard);
                if (cardM != null) throw new MessageException("�����֤����ע��");

                VipCardInfoM m = GetRecordByVipcard(model.idcard);
                if (m != null) throw new MessageException("�����֤��ע��ɻ�Ա�����ˣ�����ǰ̨����");
            }

            if (!string.IsNullOrEmpty(mm.mobile) && !string.IsNullOrEmpty(model.mobile) && !mm.idcard.Equals(model.mobile))
            {
                VipCardInfoM cardM = GetCardByMobile(model.mobile);
                if (cardM != null) throw new MessageException("�����ֻ�����ע��");
            }
          



            if (!string.IsNullOrEmpty(model.name)) 
            {
                custM.str_CusName = model.name;
            }

            if (!string.IsNullOrEmpty(model.mobile)) 
            {
                custM.str_mobile = model.mobile;
            }

            if (!string.IsNullOrEmpty(model.openid)) 
            {
                VipCardInfoM cardM = GetVipCardByopenID(model.openid);
                if (cardM != null) throw new MessageException("����openid��ע��");
                VipCardInfoM infoM = this.GetM<VipCardInfoM>(mm.id??0);
                if (infoM == null) throw new MessageException("��Ա������");
                if (string.IsNullOrEmpty(infoM.str_wcopenid)||!string.IsNullOrEmpty(infoM.str_wcopenid) && !infoM.str_wcopenid.Equals(model.openid)) 
                {
                    infoM.str_wcopenid = model.openid;
                    if (!this.UpdateRecord<VipCardInfoM>(infoM, infoM.Ing_Pk_VipCardId))
                    {
                        throw new MessageException("����ʧ��");
                    }
                }
               
            }

            if (!string.IsNullOrEmpty(model.idcard)) 
            {
                custM.str_ident = model.idcard;
            }
            if (!string.IsNullOrEmpty(model.nickname))
            {
                custM.str_Nickname = model.nickname;
            }
            if (!string.IsNullOrEmpty(model.level)) 
            {
                int level = 0;
                int.TryParse(model.level, out level);
                string strSql = @"update T_VipCard_Info SET Ing_VipCardType={0}
                                where Ing_Pk_VipCardId={1}";
                strSql = string.Format(strSql,level,mm.id);

                this.Sqlca.ExecuteNonQuery(strSql);
            }

            return custD.UpdateRecord<CustM>(custM, custM.Ing_Pk_CustID);
        }

        /// <summary>
        /// �̳�������Ա
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShopVipcardM Rigister(ShopVipcardM model) 
        {
            if (string.IsNullOrEmpty(model.idcard)) throw new MessageException("֤���Ų���Ϊ��");

            if (string.IsNullOrEmpty(model.name)) throw new MessageException("��������Ϊ��");

            if (string.IsNullOrEmpty(model.openid)) throw new MessageException("openid����Ϊ��");

            if (string.IsNullOrEmpty(model.mobile)) throw new MessageException("�ֻ��Ų���Ϊ��");

            Public.CommonFunc func = new CommonFunc();
            if (!func.CheckIDCard(model.idcard)) throw new MessageException("���֤��ʽ����");

            VipCardInfoM cardM = GetCardByIdent(model.idcard);
            if (cardM != null) 
            {
                if (!string.IsNullOrEmpty(cardM.str_mobile)) throw new MessageException("�������֤����ע��");
                VipCardInfoM tempm = GetCardByMobile(model.mobile);
                if (tempm != null) throw new MessageException("�����ֻ�����ע��");
                cardM.str_mobile = model.mobile;
                this.UpdateRecord<VipCardInfoM>(cardM);
                return GetShopVipCard(model);
            }

            VipCardInfoM m = GetRecordByVipcard(model.idcard);
            if (m != null) throw new MessageException("�������֤��ע��ɻ�Ա�����ˣ�����ǰ̨����");

            VipCardInfoM mm = GetCardByMobile(model.mobile);
            if (mm != null) throw new MessageException("�����ֻ�����ע��");

            VipCardInfoM mmm = GetVipCardByopenID(model.openid);
            if (mmm != null) throw new MessageException("����openid��ע��");
            

          int id=  BindWeChatExec(model.mobile, model.name, model.openid, model.idcard,0,"�̳�ע��","Shop");
          if(id>0&&!string.IsNullOrEmpty(model.nickname))
          {
              mmm = GetCardByIdent(model.idcard);
              if (mmm != null)
              {
                  CustD custD = new CustD();
                  CustM tm = custD.GetM<CustM>(mmm.Ing_Pk_CustID);
                  if (tm != null)
                  {
                      tm.str_Nickname = model.nickname;
                      custD.UpdateRecord<CustM>(tm, tm.Ing_Pk_CustID);
                  }
              }


          }
          
            return GetShopVipCard(model);
        }


        /// <summary>
        /// ��ȡ��ֵ/Ǯ��/������ϸ��Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShopVipTotalM GetVipDetail(ShopVipDeatilM model) 
        {
            ShopVipTotalM backM = new ShopVipTotalM();

            ShopVipcardM mm =GetShopVipCard(new ShopVipcardM { mobile = model.mobile, openid = model.openid, id = model.id });
            
            if (mm== null) throw new MessageException("��Ա������");

            CommonFunc func = new CommonFunc();
            WechatWalletD walletD = new WechatWalletD();
            VipCardChargeMonD monD = new VipCardChargeMonD();
            MasterD masD=new MasterD();
            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }

            if (model.method == 1) //����
            {
                #region ����
                if (model.type == 1) //��ֵ��
                {
                    ParaForVipCardChargeM chargeM = new ParaForVipCardChargeM();
                    int type = 5;
                    if (model.amount < 0) type = 6;
                    chargeM.chargemon = Math.Abs(model.amount);
                    chargeM.SendMon = 0;
                    chargeM.Reamrk = "�̳Ǵ�ֵ,"+model.description;
                    chargeM.Ing_Pk_VipCardID = mm.id ?? 0;
                    chargeM.chargeType = type;
                    if (!VipCardChargeExec(chargeM, this.Sqlca))
                    {
                        this.LastError = "��ֵʧ��";
                    }
                }
                if (model.type == 2) //΢��Ǯ��
                {
                  
                    WechatWalletM walletM = new WechatWalletM
                    {
                        Ing_Fk_VipcardId = mm.id,
                        Ing_Type = model.amount > 0 ? 0 : 1,
                        dec_Price = Math.Abs(model.amount),
                        str_Creator = "Wechat",
                        str_Memo = "΢��Ԥ��,"+model.description,
                        dt_Create = DateTime.Now
                    };

                    if (!walletD.UpdateRecord<WechatWalletM>(walletM, walletM.Ing_PKID, this.Sqlca))
                    {
                        this.LastError = "L΢��Ǯ��֧����¼�������";
                        goto updateerr;
                    }
                    string strSql1 = "UPDATE T_VipCard_Info SET dec_WechatPrice=isnull(dec_WechatPrice,0) {2} {0} WHERE Ing_Pk_VipCardId={1}";
                    strSql1 = string.Format(strSql1, Math.Abs(model.amount),model.id ?? 0,model.amount>0?"+":"-");
                    if (!this.Sqlca.ExecuteNonQuery(strSql1))
                    {
                        this.LastError = "L΢��Ǯ������ʧ��";
                        goto updateerr;
                    }
                }
                if (model.type == 3) //����
                {
                    ParaForVipCardChargeM chargeM = new ParaForVipCardChargeM();
                    int type =1;
                    if (model.amount < 0) type =98;
                    chargeM.chargemon = Math.Abs(model.amount);
                    chargeM.SendMon = 0;
                    chargeM.Reamrk = "�̳ǻ���,"+model.description;
                    chargeM.Ing_Pk_VipCardID = mm.id ?? 0;
                    chargeM.chargeType = type;
                    if (!VipCardChargeExec(chargeM, this.Sqlca))
                    {
                        this.LastError = "��ֵʧ��";
                    }
                }
                #endregion
            }

            if (model.method == 2) //��ѯ
            {
                #region ��¼
                if (model.type == 1) //��ֵ
                {
                    string strSql = @"SELECT dt_ChargeDate as [Create],str_Remark as Remark,
                                    (case when isnull(Ing_ChargeType,0)=5 then dec_CreditMon else dec_ChargeMon end) as Amount,
                                    (CASE WHEN isnull(Ing_ChargeType,0)=5 THEN '��ֵ' WHEN ISNULL(Ing_ChargeType,0)=6 THEN '����' 
                                    WHEN  isnull(Ing_ChargeType,0)=7 THEN '����' ELSE '��Ч' END ) as strtype FROM T_VipCard_ChargeMon  
                                    where Ing_Fk_VipCardID={0} {1} ORDER BY Ing_pk_VCMID DESC";
                    string strWhere = string.Empty;
                    if (!string.IsNullOrEmpty(model.starttime))
                    {
                        strWhere += string.Format(" and  DATEDIFF(day,dt_ChargeDate,'{0}') >=0 ", func.UnixToDateTime(model.starttime));
                    }
                    if (!string.IsNullOrEmpty(model.endtime))
                    {
                        strWhere += string.Format(" and  DATEDIFF(day,dt_ChargeDate,'{0}') <=0 ", func.UnixToDateTime(model.endtime));
                    }
                    strSql = string.Format(strSql,mm.id,strWhere);
                    backM.details = this.GetQueryM<VipDetailM>(strSql, this.Sqlca);
                    backM.total = mm.dec_SurplusMoney;
                }

                if (model.type == 2) 
                {
                    string strSql = @"SELECT  dec_Price as Amount,dt_Create as [Create],str_Memo as Remark
                                       ,(CASE WHEN ISNULL(Ing_Type,0)=0 THEN '��ֵ' ELSE '����' END ) as strtype 
                                       FROM T_Wechat_Wallet where Ing_Fk_VipcardId={0} {1} ORDER by Ing_PKID DESC ";
                    string strWhere = string.Empty;
                    if (!string.IsNullOrEmpty(model.starttime))
                    {
                        strWhere += string.Format(" and  DATEDIFF(day,dt_Create,'{0}') >=0 ", func.UnixToDateTime(model.starttime));
                    }
                    if (!string.IsNullOrEmpty(model.endtime))
                    {
                        strWhere += string.Format(" and  DATEDIFF(day,dt_Create,'{0}') <=0 ", func.UnixToDateTime(model.endtime));
                    }
                    strSql = string.Format(strSql, mm.id, strWhere);
                    backM.details = this.GetQueryM<VipDetailM>(strSql, this.Sqlca);
                    backM.total = mm.dec_WechatPrice;
                }

                if (model.type == 3) 
                {
                    string strSql = @"SELECT (CASE WHEN isnull(Ing_ChargeIntegral,0)>0 THEN '�ۼ�' ELSE '����' END)as strtype
                                    ,(CASE WHEN isnull(Ing_ChargeIntegral,0)>0 
                                    THEN Ing_ChargeIntegral ELSE Ing_CreditIntegral END) as Amount
                                    ,str_remark as Remark,dt_ChargeDate as [Create] FROM T_VipCard_ChargeIntegral
                                    where Ing_Fk_VipCardID={0} {1}
                                    order BY Ing_pk_CintID desc";
                    string strWhere = string.Empty;
                    if (!string.IsNullOrEmpty(model.starttime))
                    {
                        strWhere += string.Format(" and  DATEDIFF(day,dt_Create,'{0}') >=0 ", func.UnixToDateTime(model.starttime));
                    }
                    if (!string.IsNullOrEmpty(model.endtime))
                    {
                        strWhere += string.Format(" and  DATEDIFF(day,dt_Create,'{0}') <=0 ", func.UnixToDateTime(model.endtime));
                    }
                    strSql = string.Format(strSql, mm.id, strWhere);
                    backM.details = this.GetQueryM<VipDetailM>(strSql, this.Sqlca);
                    backM.total = mm.Ing_TotalIntegral;
                }
                if (model.type == 5) 
                {
                    string strSql = @"SELECT c.str_StoreName,a.dec_ActualRate,a.str_RoomNo,a.dt_ArrDate,a.dt_DepDate,a.str_Sta from T_Master a
                                    LEFT JOIN T_VipCard_Info b
                                    on a.Ing_Fk_VipCardID=b.Ing_Pk_VipCardId
                                    LEFT JOIN T_Store_Info c
                                    on a.Ing_StoreID=c.Ing_StoreID
                                    where b.str_wcopenid='{0}'";
                    strSql = string.Format(strSql,mm.openid);
                    List<MasterM> list = this.GetQueryM<MasterM>(strSql);
                    backM.details = new List<VipDetailM>();
                    if (list != null && list.Count > 0) list.ForEach(a => backM.details.Add(new VipDetailM { Amount = a.dec_ActualRate ?? 0
                    ,Remark=string.Format("�Ƶ�:{0},����:{1},����:{2},����:{3},״̬:{4}",a.str_StoreName,a.str_RoomNo,a.dt_ArrDate,a.dt_DepDate,a.str_Sta)}));
                }

                if (model.type == 6) 
                {
                    string strSql = @"SELECT (CASE WHEN GETDATE() BETWEEN a.dt_StartTime and a.dt_EndTime AND isnull(a.Ing_LastNum,0)>0
                                    THEN '��Ч' ELSE '��Ч' END ) as strtype,a.dec_Amount as Amount,a.dt_createtime as [Create] from T_CouponDetails a
                                    WHERE a.Ing_VipcardInfoID={0}";
                    strSql = string.Format(strSql, mm.id);
                    backM.details = this.GetQueryM<VipDetailM>(strSql, this.Sqlca);
                }
                #endregion
            }

            if (model.method == 3) //�ܶ�
            {
                if (model.type == 1) 
                {
                    backM.total = mm.dec_SurplusMoney;
                }
                if (model.type == 2) 
                {
                    backM.total = mm.dec_WechatPrice;
                }
                if (model.type == 3) 
                {
                    backM.total = mm.Ing_TotalIntegral;
                }
            }

            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();
            backM.code = "1";
            return backM;
        updateerr:
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            throw new MessageException(this.LastError);

        }

        /// <summary>
        /// �����Ż�ȯ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseShopM DiscountGet(CreateCoupon model)
        {
            CouponDetailsD detailD = new CouponDetailsD();
            CouponTypeD typeD = new CouponTypeD();
            CouponTypeM typeM = typeD.GetWechatType("Shop");
            VipPackageD PackageD = new VipPackageD();
            if (typeM == null)
            {
                throw new MessageException("���ȴ����Ż�ȯ����");
            }
            ShopVipcardM mm = this.GetShopVipCard(new ShopVipcardM { id=model.id,mobile=model.mobile,openid=model.openid});
            if (mm == null) throw new MessageException("��Ա������");

            int num = detailD.GetMaxNum();
            if (num == 0) int.TryParse(typeM.str_Pccode, out num);
            num += 1;
            CouponDetailsM detailM = new CouponDetailsM();
         
            detailM.dt_StartTime = DateTime.Now;
            detailM.dt_EndTime = DateTime.Now.AddDays(182);
            detailM.dt_createtime = DateTime.Now;
            detailM.Ing_CanUseNum = 1;
            detailM.Ing_LastNum = 1;
            detailM.Ing_CouponTypeID = typeM.Ing_CouponTypeID;
            detailM.Ing_Sta = 1;
            detailM.str_UseArea = ",0,";
            detailM.str_PaperName = string.Concat(model.amount,"Ԫ",typeM.str_PaperName);
            detailM.Ing_VipcardInfoID = mm.id;
            detailM.str_creater = "WeChat";
            if (model.num <= 0) model.num = 1;
            detailM.dec_Amount = model.amount / model.num;
            if(!this.Sqlca.BeginTransaction())
            {
                goto updateerr;
            }

            if (model.amount > 0) 
            {
                for (int i = 0; i < model.num; i++)
                {
                    detailM.str_PaperCode = (num + i).ToString();
                    if (!detailD.UpdateRecord<CouponDetailsM>(detailM, detailM.Ing_PaperID, this.Sqlca))
                    {
                        goto updateerr;
                    }
                }
            }
           

            //������ǹ������,ֱ������ȥ
            if (model.packageid <=0) 
            {
                this.Sqlca.CommitTransaction();
                this.Sqlca.Close();
                return new BaseShopM { code = "1", msg = "" };
            }


            VipPackageM packM = PackageD.GetM<VipPackageM>(model.packageid);
            if (packM == null) goto updateerr;
            //���ͻ���
            if (packM.dec_Integral.HasValue && packM.dec_Integral.Value > 0)
            {
                ParaForVipCardChargeM jifenM = new ParaForVipCardChargeM();
                jifenM.Ing_Pk_VipCardID = mm.id ?? 0;
                jifenM.chargemon = packM.dec_Integral.Value;
                jifenM.chargeType = 1;
                jifenM.Reamrk = "������ͻ���";
                if (!this.VipCardChargeExec(jifenM, this.Sqlca))
                {
                    this.LastError = "L���ͻ���ʧ��";
                    goto updateerr;
                }

            }

            //�����Ż�ȯ
            if (packM.str_CouponIdes1 != null && packM.str_CouponIdes1.Count > 0)
            {
                CouponDetailsD couponDetail = new CouponDetailsD();
                CreateCoupponM coupponM = new CreateCoupponM();
                coupponM.vipCardInfoId = mm.id ?? 0;
                foreach (int li in packM.str_CouponIdes1)
                {
                    coupponM.coupontypeId = li;
                    LogHelper.LogInfo(string.Format("��������Ż�ȯ���ŵ꣺�̳ǹ�������  ��Ա��id:{1}", "", mm.id ?? 0));
                    if (!couponDetail.CreateCoupponDetail(coupponM, this.Sqlca))
                    {
                        this.LastError = "L�����Ż�ȯʧ��";
                        goto updateerr;
                    }
                }



            }

            bool firstReset = false;
            //�Ƿ����û�Ա��ס�Ż�
            if (packM.Ing_FirstCheck.HasValue && packM.Ing_FirstCheck.Value == 1)
            {
                firstReset = true;
                if (!this.ResetVipFirst(mm.id ?? 0, this.Sqlca))
                {
                    this.LastError = "L���û�Ա��ס�Ż�ʧ��";
                    goto updateerr;
                }
            }

            //��¼����Ա��־��
            VipCardLogD logD = new VipCardLogD();
            VipCardLogM logm = new VipCardLogM();
            logm.Ing_StoreID = 0;
            logm.Ing_Fk_VipCardId = mm.id;
            logm.str_LogType = "�������";
            logm.str_LogDesc = string.Format("�ŵ�:{0}|���:{1}|���:{2}|�Ƿ�������ס�Ż�:{3}|����Ա:{4}{5}|", "΢��"
                , packM.str_Name, packM.dec_Amount, firstReset ? "��" : "��","�̳ǹ���"
                , "�̳ǹ���");
            logm.dt_LogDate = DateTime.Now;
            logm.str_UserNo = "�̳ǹ���";
            
            if (!logD.UpdateRecord<VipCardLogM>(logm, logm.Ing_LogID, this.Sqlca))
            {
                this.LastError = "L�����������ʧ��";
                goto updateerr;
            }

            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();
            return new BaseShopM { code = "1", msg = "" };
        updateerr:
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            return new BaseShopM { code = "0", msg = "�����Ż�ȯʧ��" };
           
        }


        /// <summary>
        /// ��ȡ���ͽӿ�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ShopVipCardType> GetVipCardType(ShopVipDeatilM model)
        {
           // if (string.IsNullOrEmpty(model.hotelides)) throw new MessageException("��������ȷ");
            string strSql = @"  SELECT  a.Ing_CardTypeID,a.str_CardTypeName FROM T_VipCard_Type a
                                where  a.Ing_Halt=1";
            strSql = string.Format(strSql);
            return this.GetQueryM<ShopVipCardType>(strSql);
        }



        /// <summary>
        /// ���ݻ�Աid������ס�Ż�
        /// </summary>
        /// <param name="ing_Vipcardid"></param>
        /// <returns></returns>
        public bool ResetVipFirst(int ing_Vipcardid, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }
            string strSql = "UPDATE T_VipCard_Info SET Ing_FirstMaster=0 where Ing_Pk_VipCardId={0} ";
            strSql = string.Format(strSql, ing_Vipcardid);
            return this.Sqlca.ExecuteNonQuery(strSql);
        }

    }
}

