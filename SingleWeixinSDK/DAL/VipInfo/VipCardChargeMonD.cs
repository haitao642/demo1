using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VipCardChargeMonD:BaseTable
    {
        public VipCardChargeMonD()
            : base("T_VipCard_ChargeMon", "Ing_pk_VCMID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(VipCardChargeMonM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ��Ա��Ǯ��¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(VipCardChargeMonM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<VipCardChargeMonM>(model, model.Ing_pk_VCMID);
            model.Ing_pk_VCMID = this.lngKeyID;
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
        /// ��ȡ��Ա����Ӧ�Ĵ�ֵ��ϸ��¼
        /// </summary>
        /// <param name="vipcardID"></param>
        /// <returns></returns>
        public List<VipCardChargeMonM> GetListbyVipcardID(int vipcardID)
        {
            string strSql = @"SELECT a.* from T_VipCard_ChargeMon a WHERE a.Ing_Fk_VipCardID=@cardid
                                ORDER BY a.Ing_pk_VCMID DESC";
            this.Sqlca.AddParameter("@cardid", vipcardID);

            List<VipCardChargeMonM> list = this.GetQueryM<VipCardChargeMonM>(strSql);
            this.Sqlca.ClearParameter();
            return list;
        }
    }
}
