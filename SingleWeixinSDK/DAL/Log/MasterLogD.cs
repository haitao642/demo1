using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bee.Web;
using Model.Log;

namespace DAL
{
    public class MasterLogD:BaseTable
    {
        public MasterLogD()
            : base("T_Master_Log", "Ing_LogID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(MasterLogM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ����������־
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(MasterLogM model, DataTrans DataTrans=null)
        {
            if (DataTrans != null) 
            {
                this.Sqlca = DataTrans;
            }
            if (!CheckUpdateM(model))
            {
                return false;
            }
            if (string.IsNullOrEmpty(model.str_Pk_Accnt))
            {
                MasterD masD = new MasterD();
                MasterM masM = new MasterM();
                masM = masD.GetM<MasterM>(model.Ing_Fk_MasterID.Value);
                if (masM != null)
                {
                    model.str_Pk_Accnt = masM.str_Pk_Accnt;
                    model.str_CusName = masM.str_cusname;
                }
            }

            bool rev = this.UpdateRecord<MasterLogM>(model, model.Ing_LogID);
            model.Ing_LogID = this.lngKeyID;
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
