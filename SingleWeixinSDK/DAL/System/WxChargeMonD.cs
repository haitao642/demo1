using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WxChargeMonD:BaseTable
    {
        public WxChargeMonD()
            : base("T_WxChargeMon", "Ing_Pk_id")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(WxChargeMonM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ΢�Ŵ�ֵ��ֵ���ͱ�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(WxChargeMonM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<WxChargeMonM>(model, model.Ing_Pk_id);
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
        private static List<WxChargeMonM> list = new List<WxChargeMonM> { new WxChargeMonM(1, 20), new WxChargeMonM(2, 30), new WxChargeMonM(3, 50), new WxChargeMonM(4, 100), new WxChargeMonM(5, 200), new WxChargeMonM(6, 300) };
        public List<WxChargeMonM> GetAll()
        {
            return list;
        }
        public WxChargeMonM GetByid(int Ing_Pk_id)
        {
            return list.Where(x => x.Ing_Pk_id == Ing_Pk_id).FirstOrDefault();
        }
    }
}
