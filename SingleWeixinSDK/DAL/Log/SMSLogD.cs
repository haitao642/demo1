using Model;
using Model.Log;
using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SMSLogD:BaseTable
    {
        public SMSLogD()
            : base("T_SMSLog", "Ing_pk_sd")
        { }

        #region 添加，删除，修改
        /// <summary>
        /// 检查更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckUpdateM(SMSLogM model)
        {            
            return true;
        }

        /// <summary>
        /// 保存 短信日志
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(SMSLogM model)
        {
            if (!CheckUpdateM(model))
            {
                return false;
            }
            bool rev= this.UpdateRecord<SMSLogM>(model, model.Ing_pk_sd);
            model.Ing_pk_sd = this.lngKeyID;
            return rev;
        }


        
        /// <summary>
        /// 检查删除
        /// </summary>
        /// <param name="lnguserid"></param>
        /// <returns></returns>
        public bool CheckDelete(int id)
        {
            return true;
        }


        /// <summary>
        /// 删除
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
