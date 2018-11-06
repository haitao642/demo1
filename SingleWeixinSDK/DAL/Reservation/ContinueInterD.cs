using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContinueInterD:BaseTable
    {
        public ContinueInterD()
            : base("T_ContinueInter", "Ing_pkid")
        { }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(ContinueInterM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ��ס��¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(ContinueInterM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<ContinueInterM>(model, model.Ing_pkid);
            model.Ing_pkid = this.lngKeyID;
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
        /// ��������id�����Ͳ��Ҽ�¼
        /// </summary>
        /// <param name="MasterID">����id</param>
        /// <param name="type">0:��ס   1���˷�</param>
        /// <returns></returns>
        public ContinueInterM GetRecord(int MasterID, int type)
        {
            string strSql = "SELECT TOP 1 * FROM dbo.T_ContinueInter a WHERE a.Ing_MasterID={0} AND ISNULL(a.Ing_type,0)={1} ORDER BY a.Ing_pkid DESC";
            strSql = string.Format(strSql,MasterID,type);

            return this.GetQueryM<ContinueInterM>(strSql).FirstOrDefault();
        }
    }
}
