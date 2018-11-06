using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VipCardChargeIntegralB
    {
        public DAL.VipCardChargeIntegralD dal = new DAL.VipCardChargeIntegralD();

                /// <summary>
        /// ����openid��ȡ���ּ�¼
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public List<VipCardChargeIntegralM> GetListbyOpenid(string openid)
        {
            return dal.GetListbyOpenid(openid);
        }


                /// <summary>
        /// ���ݻ�Ա��id���һ��ּ�¼
        /// </summary>
        /// <param name="cardid"></param>
        /// <returns></returns>
        public List<VipCardChargeIntegralM> GetListbyVipcardid(int cardid)
        {
            return dal.GetListbyVipcardid(cardid);
        }
    }
}
