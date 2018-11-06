using Model;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TimeRoomRuleD:BaseTable
    {
        public TimeRoomRuleD()
            : base("T_TimeRoomRule", "Ing_PID")
        {
        }

        #region ��ӣ�ɾ�����޸�
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(TimeRoomRuleM model)
        {            
            return true;
        }

        /// <summary>
        /// ���� ��������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(TimeRoomRuleM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<TimeRoomRuleM>(model, model.Ing_PID);
            model.Ing_PID = this.lngKeyID;
            return rev;
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <returns></returns>
        public List<TimeRoomRuleM> GetAllList()
        {
            string strSql = "select * from V_TimeRoomRule";

            return this.GetQueryM<TimeRoomRuleM>(strSql);
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
        /// ��ȡ�ӵ㷿����
        /// </summary>
        /// <param name="Ing_StoreID"></param>
        /// <param name="RoomType"></param>
        /// <returns></returns>
        public List<TimeRoomRuleM> GetRule(int Ing_StoreID,string RoomType)
        {
            string strSql = @"SELECT * FROM dbo.T_TimeRoomRule a WHERE a.Ing_Sta=1 AND a.str_Remark='wechat'
                                AND ISNULL(a.str_RoomType,'-')='{1}'";
            strSql = string.Format(strSql,Ing_StoreID,RoomType);
            return this.GetQueryM<TimeRoomRuleM>(strSql);
        }
    }
}
