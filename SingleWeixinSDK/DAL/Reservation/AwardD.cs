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
    public class AwardD : BaseTable
    {
        public AwardD()
            : base("T_Award", "Ing_AwardID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(AwardM model)
        {
            return true;
        }

        /// <summary>
        /// ���� �齱��Ʒ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(AwardM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev = this.UpdateRecord<AwardM>(model, model.Ing_AwardID);
            model.Ing_AwardID = this.lngKeyID;
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
        /// ��ȡ������Ч�Ľ�������
        /// </summary>
        /// <returns></returns>
        public List<AwardM> GetUseFulAward()
        {
            string strSql = "SELECT * FROM T_Award a WHERE ISNULL(a.Ing_Amount,0)>0 AND DATEDIFF(DAY,a.dt_Start,GETDATE())>=0 AND DATEDIFF(DAY,GETDATE(),a.dt_End)>=0";
            return this.GetQueryM<AwardM>(strSql);
        }

        /// <summary>
        /// �õ��齱���������
        /// </summary>
        /// <param name="vipcardID"></param>
        /// <returns></returns>
        public AwardM GetAward(int vipcardID)
        {
            //�����Ա��id=0,˵����΢�Ż�û�а�
            if (vipcardID == 0)
            {
                this.LastError = "L�㻹δ�󶨣���رմ�ҳ�棬�󶨺��ٽ��г齱";
                return null;
            }

            AwardGoodsD goodsD = new AwardGoodsD();
            if (goodsD.AlreadyAward(vipcardID))
            {
                this.LastError = "L�ף����Ѿ��齱����Ŷ!";
                return null;
            }

            List<AwardM> list = new List<AwardM>();
            list = this.GetUseFulAward();
            if (list == null || list.Count == 0)
            {
                this.LastError = "L��δ�趨������������Ѿ����꣬����ϵ����Ա";
                return null;
            }

            #region ����齱
            int sum = list.Sum(x => x.Ing_Amount);

            Random rn = new Random();
            int key = rn.Next(sum);

            sum = 0;

            AwardM model = null;
            foreach (AwardM m in list)
            {
                sum += m.Ing_Amount;
                if (key <= sum)
                {
                    model = m;
                    break;
                }
            }
            if (model == null)
            {
                this.LastError = "L��δ�趨������������Ѿ����꣬����ϵ����Ա!";
                return null;
            }
            #endregion

            ///���뽱Ʒ
            AwardGoodsM m1 = new AwardGoodsM();
            m1.dt_Create = DateTime.Now;
            m1.Ing_AwardID = model.Ing_AwardID;
            m1.Ing_VipcardID = vipcardID;
            m1.Ing_Sta = 0;
            if (model.Ing_RealGoods == 0)
            {
                //�����������Ʒ��ֱ����ȡ
                m1.dt_Modify = DateTime.Now;
                m1.str_Modify = "WeChat";
                m1.Ing_StoreID = 0;
                m1.Ing_Sta = 1;
            }


            if (goodsD.AlreadyAward(vipcardID))
            {
                this.LastError = "L�ף����Ѿ��齱����Ŷ!";
                return null;
            }

            if (!this.Sqlca.BeginTransaction())
            {
                this.LastError = this.Sqlca.LastError;
                goto updateerr;
            }

            if (!goodsD.UpdateRecord<AwardGoodsM>(m1, 0, this.Sqlca))
            {
                this.LastError = "Lϵͳ��æ�����Ժ�����!";
                goto updateerr;
            }

            ///�ǲ��ǳ�һ�Σ������Ʒ������Ҫ��1����ʱ��ע�͵�
            //model.Ing_Amount -= 1;
            //if (!this.UpdateRecord<AwardM>(model, model.Ing_AwardID, this.Sqlca))
            //{
            //    this.LastError = "Lϵͳ��æ�����Ժ�����!";
            //    goto updateerr;
            //}

            if (model.Ing_level == 1 || model.Ing_level == 2)
            {
                //�����Ӧ���Ż�ȯ��Ϣ
                if (model.Ing_CouponTypeID == 0)
                {
                    this.LastError = "Lϵͳ��æ�����Ժ�����1!";
                    goto updateerr;
                }
                if (!this.CreateCoupponDetail(vipcardID, model.Ing_CouponTypeID, 0, this.Sqlca))
                {
                    this.LastError = "Lϵͳ��æ�����Ժ�����2!";
                    goto updateerr;
                }
            }


            this.Sqlca.CommitTransaction();
            this.Sqlca.Close();

            return model;

        updateerr:
            if (string.IsNullOrEmpty(this.LastError))
            {
                this.LastError = this.Sqlca.LastError;
            }
            this.Sqlca.RollbackTransaction();
            this.Sqlca.Close();
            return null;
        }


        /// <summary>
        /// ���ݻ�Ա���������Ż�ȯ
        /// </summary>
        /// <param name="vipCardId"></param>
        /// <returns></returns>
        public bool CreateCoupponDetail(int vipCardInfoId, int coupontypeId = 0, int ingmonth = 0, DataTrans DataTrans = null)
        {
            if (DataTrans != null)
            {
                this.Sqlca = DataTrans;
            }

            string strSql = "EXEC U_CreateCouponDetail @StoreId,@VipCardInfoId,@UserName,@CouponTypeId,@ingmonth";
            this.Sqlca.AddParameter("@StoreId", 0);
            this.Sqlca.AddParameter("@VipCardInfoId", vipCardInfoId);
            this.Sqlca.AddParameter("@UserName", "WeChat");
            this.Sqlca.AddParameter("@CouponTypeId", coupontypeId);
            this.Sqlca.AddParameter("@ingmonth", ingmonth);
            bool rev = this.Sqlca.ExecuteNonQuery(strSql);
            this.Sqlca.ClearParameter();
            return rev;
        }
    }
}
