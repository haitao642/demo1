using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VipCardChargeMonRuleD:BaseTable
    {
        public VipCardChargeMonRuleD()
            : base("T_VipCard_ChargeMonRule", "Ing_ChargeMonId")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(VipCardChargeMonRuleM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ��Ա����ֵ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(VipCardChargeMonRuleM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<VipCardChargeMonRuleM>(model, model.Ing_ChargeMonId);
            model.Ing_ChargeMonId = this.lngKeyID;
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
    }
}
