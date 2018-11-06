using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NewsB
    {
        public DAL.NewsD dal = new DAL.NewsD();

        public NewsB() { }

        /// <summary>
        /// �õ�һ����¼
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NewsM GetOne(int id)
        {
            return dal.GetM<NewsM>(id);
        }


        /// <summary>
        /// ��ȡĳһ�������
        /// </summary>
        /// <param name="topnum">0:ȫ��  </param>
        /// <param name="Ing_FCaption">��������   31�� ������Ϣ</param>
        /// <returns></returns>
        public List<NewsM> GetNews(int topnum, int Ing_FCaption)
        {
            return dal.GetNews(topnum, Ing_FCaption);
        }
    }
}
