using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CouponTypeB
    {
        public DAL.CouponTypeD dal = new DAL.CouponTypeD();

        /// <summary>
        /// ��ȡ΢�Ŷ�  ���ֶһ�����ȯ�Ļ
        /// </summary>
        /// <returns></returns>
        public CouponTypeM GetWechatType()
        {
            return dal.GetWechatType();
        }
    }
}
