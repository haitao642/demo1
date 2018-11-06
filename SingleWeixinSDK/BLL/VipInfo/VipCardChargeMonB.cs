using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VipCardChargeMonB
    {
        public DAL.VipCardChargeMonD dal = new DAL.VipCardChargeMonD();

        /// <summary>
        /// ��ȡ��Ա����Ӧ�Ĵ�ֵ��ϸ��¼
        /// </summary>
        /// <param name="vipcardID"></param>
        /// <returns></returns>
        public List<VipCardChargeMonM> GetListbyVipcardID(int vipcardID)
        {
            return dal.GetListbyVipcardID(vipcardID);
        }
    }
}
