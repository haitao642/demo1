using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// T_StoreImg
    /// </summary>
    public class StoreImgM
    {
        ///<summary>
        ///���
        /// </summary>
        public int Ing_PK_ImgID {get;set;}

        ///<summary>
        ///�ŵ�ID
        /// </summary>
        public int Ing_StoreID {get;set;}

        ///<summary>
        ///�ϴ�·��
        /// </summary>
        public string str_DLPath {get;set;}

        ///<summary>
        ///ͼƬ����
        /// </summary>
        public string str_FileName {get;set;}

        ///<summary>
        ///ͼƬ��ʶ
        /// </summary>
        public int Ing_IsTop {get;set;}

        /// <summary>
        /// ˳��
        /// </summary>
        public int order { get; set; }

        /// <summary>
        /// ��ʾ
        /// </summary>
        public string display { get; set; }

        /// <summary>
        /// id����
        /// </summary>
        public string strid { get {
            return string.Format("divimgshow{0}", order);
        } }

        /// <summary>
        /// ����
        /// </summary>
        public string str_Room { get; set; }
    }
}