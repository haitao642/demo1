using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_StoreSum
    /// </summary>
    public class StoreSumM
    {
        ///<summary>
        ///Ing_StoreSumID
        /// </summary>
        public int Ing_StoreSumID { get; set; }

        ///<summary>
        ///����
        /// </summary>
        public string str_city { get; set; }

        ///<summary>
        ///�ŵ�����
        /// </summary>
        public int Ing_Sum { get; set; }


        /// <summary>
        /// ����
        /// </summary>
        public int Ing_order { get; set; }
    }

    /// <summary>
    /// �Ƶ�ͳ���б�
    /// </summary>
    public class StoreSumListM
    {
        /// <summary>
        /// �б�
        /// </summary>
        public List<StoreSumM> list { get; set; }
    }
}