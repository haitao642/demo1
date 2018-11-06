using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShareRecordD:BaseTable
    {
        public ShareRecordD()
            : base("T_ShareRecord", "Ing_Pk_id")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(ShareRecordM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ΢�ŷ���
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(ShareRecordM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<ShareRecordM>(model, model.Ing_Pk_id);
            model.Ing_Pk_id = this.lngKeyID;
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
        /// ����openid,�鿴 ���Ƽ��ļ�¼
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public ShareRecordM GetRecordByopenid(string openid)
        {
            string strSql = "SELECT * FROM T_ShareRecord a WHERE ISNULL(a.str_openid,'')='{0}'";
            strSql = string.Format(strSql,openid);

            return this.GetQueryM<ShareRecordM>(strSql).FirstOrDefault();
        }

        /// <summary>
        /// ���ݻ�Ա��id���ң��Ƽ�����˵ļ�¼
        /// </summary>
        /// <param name="vipcardid"></param>
        /// <returns></returns>
        public ShareRecordM GetRecordByvipcardid(int vipcardid)
        {
            string strSql = @"SELECT a.* FROM dbo.T_ShareRecord a INNER JOIN dbo.T_VipCard_Info b ON a.str_openid=b.str_wcopenid
                                 WHERE ISNULL(a.Ing_sta,0)=0 AND b.Ing_Pk_VipCardId={0}";
            strSql = string.Format(strSql,vipcardid);

            return this.GetQueryM<ShareRecordM>(strSql).FirstOrDefault();
        }

        #region ��ӷ����¼
        /// <summary>
        /// ��ӷ����¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddShare(ShareRecordM model)
        {
            if (model == null)
            {
                this.LastError = "L����Ϊ��";
                return false;
            }
            if (model.Ing_VipCardID == 0)
            {
                this.LastError = "L�Ƽ��ߵ�idΪ0�����ܱ���";
                return false;
            }
            if (string.IsNullOrEmpty(model.str_openid))
            {
                this.LastError = "L���Ƽ�����openidΪ�գ����ܱ���";
                return false;
            }

            ShareRecordM model1 = GetRecordByopenid(model.str_openid);
            if (model1 == null) model1 = new ShareRecordM();
            if (model1.Ing_sta == 1)
            {
                this.LastError = "L���Ƽ����Ѿ���ֵ���ˣ����ܱ���";
                return false;
            }
            model1.Ing_VipCardID = model.Ing_VipCardID;
            model1.str_openid = model.str_openid;

            return this.UpdateRecord<ShareRecordM>(model1, model1.Ing_Pk_id);
        }

        #endregion
    }
}
