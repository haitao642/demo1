using Bee.Web;
using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CouponDetailsD:BaseTable
    {
        public CouponDetailsD()
            : base("T_CouponDetails", "Ing_PaperID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(CouponDetailsM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� �Ż�ȯ��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(CouponDetailsM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<CouponDetailsM>(model, model.Ing_PaperID);
            model.Ing_PaperID = this.lngKeyID;
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
        /// ��ȡ��Ч���Ż�ȯ����
        /// </summary>
        /// <param name="vipcardid"></param>
        /// <returns></returns>
        public int GetUseFulCount(int vipcardid)
        {
            string strSql = "SELECT COUNT(*) FROM dbo.T_CouponDetails a WHERE a.Ing_VipcardInfoID={0} AND ISNULL(a.Ing_Sta,0)=1 AND DATEDIFF(DAY,GETDATE(),ISNULL(a.dt_EndTime,GETDATE()))>=0";
            strSql = string.Format(strSql,vipcardid);

            return this.Sqlca.GetInt32(strSql);
        }

        /// <summary>
        /// �������ͷ����Ż�ȯ
        /// </summary>
        /// <param name="vipcardid">vipcardid</param>
        /// <param name="type">0:��Ч
        /// 1����Ч   2������</param>
        /// <returns></returns>
        public List<CouponDetailsM> GetListbytype(int vipcardid,int type)
        {
            if (type < 0 || type > 2) type = 1;//and  (isnull(b.Ing_type,0)=0 or isnull(b.Ing_type,0)=1)  and   isnull(b.Ing_type,0)=0  and   isnull(b.Ing_type,0)=0
            string strSql = "";
            if (type == 1)
            {
                strSql = @"SELECT a.* FROM dbo.T_CouponDetails a
                          left JOIN T_CouponType b on a.Ing_CouponTypeID=b.Ing_CouponTypeID
                          WHERE a.Ing_VipcardInfoID={0} AND ISNULL(a.Ing_Sta,0)=1 AND DATEDIFF(DAY,GETDATE(),ISNULL(a.dt_EndTime,GETDATE()))>=0
                          
                           AND  DATEDIFF(DAY,GETDATE(),ISNULL(a.dt_StartTime,GETDATE()))<=0  ORDER BY a.Ing_PaperID desc";
            }
            else if (type == 2)
            {
                strSql = @"SELECT * FROM dbo.T_CouponDetails a 
                             left JOIN T_CouponType b on a.Ing_CouponTypeID=b.Ing_CouponTypeID
                             WHERE a.Ing_VipcardInfoID={0}    
                             AND ISNULL(a.Ing_Sta,0)=1 AND DATEDIFF(DAY,GETDATE(),ISNULL(a.dt_EndTime,GETDATE()))<0
                            ORDER BY a.Ing_PaperID desc";
            }
            else
            {
                strSql = @"SELECT * FROM dbo.T_CouponDetails a
                          left JOIN T_CouponType b on a.Ing_CouponTypeID=b.Ing_CouponTypeID
                         WHERE a.Ing_VipcardInfoID={0} AND ISNULL(a. Ing_IsUse,0)=1  
                            ORDER BY a.Ing_PaperID desc";
            }
            strSql = string.Format(strSql,vipcardid);

            return this.GetQueryM<CouponDetailsM>(strSql);
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <returns></returns>
        public int GetMaxNum()
        {
            string strSql = "SELECT MAX(str_PaperName) FROM T_CouponDetails";
            return this.Sqlca.GetInt32(strSql);
        }


        /// <summary>
        /// ��������id��������Ч�Ż�ȯ�б�
        /// </summary>0��ͨ�Ż�ȯ,1���۱���Ż�ȯ
        /// <param name="MasterID"></param>
        /// <returns></returns>
        public List<ResultCouponM> GetCouponByMasterID(int MasterID,int type=0)
        {
            MasterD masD = new MasterD();
            MasterM masM = new MasterM();
            masM = masD.GetM<MasterM>(MasterID);

            if (masM == null)
            {
                this.LastError = "L�����쳣";
                return null;
            }

            if (!masM.Ing_Fk_VipCardID.HasValue)
            {
                this.LastError = "L���������ǻ�Ա��ס������ʹ�õֿ�ȯ";
                return null;
            }

            if (masM.Ing_Fk_VipCardID.Value == 0)
            {
                this.LastError = "L���������ǻ�Ա��ס������ʹ�õֿ�ȯ";
                return null;
            }

       string where=" and 1=1 ";
       string  strSql = @"select '{0}' as str_RateID,isnull(d.str_InterType,'ALL') as str_InterType, b.str_PaperName,b.str_SendType,
                          a.Ing_PaperID,a.str_PaperCode,a.dec_Amount,a.dt_EndTime,a.Ing_LastNum,a.dt_StartTime
                        FROM T_CouponDetails a
                        INNER JOIN T_CouponType b on a.Ing_CouponTypeID=b.Ing_CouponTypeID
                        INNER JOIN T_CouponRange c ON b.Ing_CouponTypeID=c.Ing_CouponTypeID
                    left join T_Master d on d.Ing_Pk_MasterID={5}
                        WHERE b.Ing_type={4} AND a.Ing_VipcardInfoID={1} and a.Ing_Sta=1 AND a.Ing_LastNum>0
                        AND c.Ing_StoreID={2} AND (','+c.str_RoomCode+',' like '%,{6},%' or ','+c.str_RoomCode+',' like '%,0,%')
                        AND isnull(a.dec_Amount,0)<>0 AND isnull(a.dec_Amount,0)<{3}";
       strSql = string.Format(strSql, masM.str_RateID, masM.Ing_Fk_VipCardID ?? -1, masM.Ing_StoreID ?? -1, masM.dec_ActualRate ?? 0, type, masM.Ing_Pk_MasterID, masM.str_RoomType);
//            string strSql = @"SELECT '{1}' as str_RateID,isnull(c.str_InterType,'ALL') as str_InterType, a.str_PaperName,a.str_SendType,b.Ing_PaperID
//                              ,b.str_PaperCode,b.dec_Amount,b.dt_EndTime,b.Ing_LastNum
//                                     FROM T_CouponType a INNER JOIN T_CouponDetails b ON a.Ing_CouponTypeID=b.Ing_CouponTypeID
//                                    left join T_Master c on c.Ing_Pk_MasterID={2}
//                                    WHERE b.Ing_Sta=1 AND b.Ing_LastNum>0 AND DATEDIFF(DAY,ISNULL(b.dt_StartTime,GETDATE()),GETDATE())>=0
//                                    and DATEDIFF(DAY,GETDATE(),ISNULL(b.dt_EndTime,GETDATE()))>=0 AND b.Ing_VipcardInfoID={0} ";//and a.Ing_type={3}
//            strSql = string.Format(strSql, masM.Ing_Fk_VipCardID ?? 0, masM.str_RateID, MasterID);//,type
            if (type == 0) 
            {
                where = "AND DATEDIFF(DAY,ISNULL(a.dt_StartTime,GETDATE()),GETDATE())>=0  and DATEDIFF(DAY,GETDATE(),ISNULL(a.dt_EndTime,GETDATE()))>=0";
            }

            strSql += where;
            List<ResultCouponM> list = this.GetQueryM<ResultCouponM>(strSql);

            if (list == null || list.Count == 0)
            {
                this.LastError = "L�û�Ա��û����Ч�ĵֿ�ȯ";
                return null;
            }

            return list;
        }

       
        #region ʹ�õֿ�ȯ

        /// <summary>
        /// �ֿ�ȯ֧���Ĺ���
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CouponDetailsUseIn(ParaForCoponPayM model, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }
            model.str_Remark = "΢��ʹ�õֿ�ȯ";
            string strSql = "EXEC U_CouponDetails_UseIn @Ing_StoreID,@str_PagerID,@Ing_MasterID,@str_Remark,@str_Empno,@shift";
            this.Sqlca.AddParameter("@Ing_StoreID", model.Ing_StoreID);
            this.Sqlca.AddParameter("@str_PagerID", model.PagerID);
            this.Sqlca.AddParameter("@Ing_MasterID", model.MasterID);
            this.Sqlca.AddParameter("@str_Remark", model.str_Remark);
            this.Sqlca.AddParameter("@str_Empno", "WeChat");
            this.Sqlca.AddParameter("@shift", "");

            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            if (!rev)
            {
                this.LastError = this.Sqlca.LastError;

            }
            this.Sqlca.ClearParameter();
            return rev;
        }

        /// <summary>
        /// �ֿ�ȯ֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CouponPay(ParaForCoponPayM model)
        {
            if (!CheckCouponPay(model))
            {
                return false;
            }

            bool rev = CouponDetailsUseIn(model);
            return rev;
        }


        /// <summary>
        /// ����Ƿ���Եֿ�ȯ֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckCouponPay(ParaForCoponPayM model)
        {

            if (model == null)
            {
                this.LastError = "L�����������";
                return false;
            }

            if (model.ListPagerID.Count == 0)
            {
                ///û��ѡ���Ż�ȯ��ֱ�ӷ��سɹ�
                return true;
            }

            List<ResultCouponM> list = new List<ResultCouponM>();
            list = GetCouponByMasterID(model.MasterID);

            if (list == null)
            {
                return false;
            }


            foreach (int PagerID in model.ListPagerID)
            {
                ResultCouponM mod = list.Where(x => x.Ing_PaperID == PagerID).FirstOrDefault();
                if (mod == null)
                {
                    this.LastError = "Lѡ����Ż�ȯ����";
                    return false;
                }
                if (mod.Ing_LastNum <= 0)
                {
                    this.LastError = "Lѡ����Ż�ȯ������";
                    return false;
                }
            }
           
            return true;
        }



        #endregion

        /// <summary>
        /// ͨ���Ż�ȯ�ı䷿��
        /// </summary>
        /// <param name="masterid"></param>
        /// <param name="couponid"></param>
        /// <returns></returns>
        public bool CouponPrice(int masterid, int couponid)
        {
            MasterD masD = new MasterD();
            MasterM masM = masD.GetM<MasterM>(masterid);
            if (masM == null)
            {
                this.LastError="L����������";
                return false;
            }
            CouponDetailsD couponD=new CouponDetailsD();
            CouponDetailsM couponM = couponD.GetM<CouponDetailsM>(couponid);
            if (couponM == null) 
            {
                this.LastError = "L�Ż�ȯ������";
                return false;
            }
            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }
            decimal price=couponM.dec_Amount ?? 0;
         
            masM.str_memo += string.Format("|����ʹ����{0}({1}),�ɷ���({2})=>�·���({3})",couponM.str_PaperName,couponM.Ing_PaperID,masM.dec_ActualRate??0,price);
            masM.dec_ActualRate = price;
            masM.dec_StandardRate = price;
            masM.str_Sta = "X";
            if (!masD.UpdateRecord<MasterM>(masM, masM.Ing_Pk_MasterID, this.Sqlca)) 
            {
                this.LastError = "L�������ķ���ʧ��";
                goto updateerr;
            }
            couponM.Ing_LastNum -= 1;
            couponM.Ing_Sta = 2;
            if (!couponD.UpdateRecord<CouponDetailsM>(couponM, couponM.Ing_PaperID, this.Sqlca))
            {
                this.LastError = "L�Ż�ȯʹ��ʧ��";
                goto updateerr;
            }

            //����һ���Ż�ȯʹ�ü�¼
            CouponLogD couponLogD = new CouponLogD();
            CouponLogM couponLogM = new CouponLogM {
                Ing_MasterID = masterid,
                Ing_PaperID = couponid,
                Ing_StoreID=masM.Ing_StoreID??0,
                Ing_useSta=2,
                str_PaperCode=couponM.str_PaperCode,
                str_PK_Accnt=masM.str_Pk_Accnt,
                dt_useTime=DateTime.Now
            
            };
            if (!couponLogD.UpdateRecord<CouponLogM>(couponLogM, couponLogM.Ing_LogID, this.Sqlca)) 
            {
                this.LastError = "L�Ż�ȯʹ��ʧ��";
                goto updateerr;
            }

            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();
            return true;
        updateerr:
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            Public.LogHelper.LogInfo("΢�ű�۳���:"+this.LastError);
            return false;
        }


        /// <summary>
        ///0����  �����Ż�ȯ����Ϊ��Աʱ���ݻ�Ա���������ɣ����������Ż�ȯ(��Ա����ͨ���ֽ𣬺ͻ��ֹ����Ż�ȯ)
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
            this.Sqlca.AddParameter("@UserName", "WeChat");
            this.Sqlca.AddParameter("@CouponTypeId", model.coupontypeId);
            this.Sqlca.AddParameter("@ingmonth", model.ingmonth);
            this.Sqlca.AddParameter("@price", model.price);
            this.Sqlca.AddParameter("@str_Activity", model.str_Activity);
            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            this.Sqlca.ClearParameter();
            return rev;
        }

        /// <summary>
        /// �жϸ�������û��ʹ�ñ���Ż�ȯ
        /// </summary>
        /// <param name="masterid"></param>
        /// <returns></returns>
        public CouponDetailsM GetCouponDetail(int masterid)
        {
            string strSql = @"SELECT top 1 a.dt_useTime,b.* FROM T_CouponLog a
                                INNER JOIN T_CouponDetails b
                                on a.Ing_PaperID=b.Ing_PaperID
                                INNER JOIN T_CouponType c
                                on b.Ing_CouponTypeID=c.Ing_CouponTypeID
                                WHERE c.Ing_type=1 AND a.Ing_MasterID={0} AND (isnull(b.Ing_LastNum,0)=0 or b.Ing_Sta=2)
                                AND DATEDIFF(DAY,a.dt_useTime,GETDATE())>=0  ORDER BY a.Ing_LogID desc";
            strSql = string.Format(strSql, masterid);
            return this.GetQueryM<CouponDetailsM>(strSql).FirstOrDefault();

        }
    }
}
