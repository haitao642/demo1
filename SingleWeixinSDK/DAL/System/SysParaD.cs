using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SysParaD:BaseTable
    {
        public SysParaD()
            : base("T_Sys_Para", "Ing_pk_PID")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(SysParaM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(SysParaM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<SysParaM>(model, model.Ing_pk_PID);
            model.Ing_pk_PID = this.lngKeyID;
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
        /// ȡĳ������
        /// </summary>
        /// <param name="str_ParaType"></param>
        /// <param name="str_ParaCode"></param>
        /// <returns></returns>
        public SysParaM GetRecord(string str_ParaType, string str_ParaCode)
        {
            string strSql = "SELECT * from T_Sys_Para a WHERE a.str_ParaType='{0}' AND a.str_ParaCode='{1}'";
            strSql = string.Format(strSql, str_ParaType, str_ParaCode);

            return this.GetQueryM<SysParaM>(strSql).FirstOrDefault();
        }
    }
}
