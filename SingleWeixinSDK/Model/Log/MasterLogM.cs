using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Log
{
    /// <summary>
    /// T_Master_Log
    /// </summary>
    public class MasterLogM
    {
        ///<summary>
        ///Ing_LogID
        /// </summary>
        public int Ing_LogID { get; set; }

        ///<summary>
        ///记录时间
        /// </summary>
        public DateTime? dt_LogDate { get; set; }

        ///<summary>
        ///日志线程
        /// </summary>
        public string str_LogThread { get; set; }

        ///<summary>
        ///日志等级
        /// </summary>
        public string str_LogLevel { get; set; }

        ///<summary>
        ///记录人
        /// </summary>
        public string str_Logger { get; set; }

        ///<summary>
        ///操作的页面
        /// </summary>
        public string str_LogPageClass { get; set; }

        ///<summary>
        ///登录IP
        /// </summary>
        public string str_LogIP { get; set; }

        ///<summary>
        ///信息
        /// </summary>
        public string str_LogMessage { get; set; }

        ///<summary>
        ///异常
        /// </summary>
        public string str_LogException { get; set; }

        ///<summary>
        ///房号
        /// </summary>
        public string str_RoomNo { get; set; }

        ///<summary>
        ///客户号
        /// </summary>
        public int? Ing_Fk_CustID { get; set; }

        ///<summary>
        ///主单id
        /// </summary>
        public int? Ing_Fk_MasterID { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string str_Pk_Accnt { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string str_CusName { get; set; }

        ///<summary>
        ///功能
        /// </summary>
        public string str_FunC { get; set; }

        ///<summary>
        ///Ing_StoreID
        /// </summary>
        public int Ing_StoreID { get; set; }
    }

    /// <summary>
    /// 查询操作日志用到的参数
    /// </summary>
    public class ParaForSearchmasterLog : AspNetPageBaseM
    {
        /// <summary>
        /// 主单ID
        /// </summary>
        public int MasterID { get; set; }

        /// <summary>
        /// 团队主单ID
        /// </summary>
        public string GroupNo { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? dtStart { get; set; }


        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? dtEnd { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string EmpNo { get; set; }

        /// <summary>
        /// 房号
        /// </summary>
        public string roomno { get; set; }

        /// <summary>
        /// 功能
        /// </summary>
        public string func { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string desc { get; set; }


    }

    /// <summary>
    /// 详细主单页面用到的日志查询
    /// </summary>
    public class ParaForSearchLogM : AspNetPageBaseM
    {
        ///<summary>
        ///客户号
        /// </summary>
        public int Ing_Fk_CustID { get; set; }

        ///<summary>
        ///帐号
        /// </summary>
        public int Ing_Fk_MasterID { get; set; }
    }
}
