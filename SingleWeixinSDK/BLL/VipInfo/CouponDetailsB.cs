using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CouponDetailsB
    {
        public DAL.CouponDetailsD dal = new DAL.CouponDetailsD();

        /// <summary>
        /// ��ȡ��Ч���Ż�ȯ����
        /// </summary>
        /// <param name="vipcardid"></param>
        /// <returns></returns>
        public int GetUseFulCount(int vipcardid)
        {
            return dal.GetUseFulCount(vipcardid);
        }


        
        /// <summary>
        /// �������ͷ����Ż�ȯ
        /// </summary>
        /// <param name="vipcardid">vipcardid</param>
        /// <param name="type">0:��Ч   1����Ч   2������</param>
        /// <returns></returns>
        public List<CouponDetailsM> GetListbytype(int vipcardid, int type)
        {
            return dal.GetListbytype(vipcardid, type);
        }


        /// <summary>
        /// �ֿ�ȯ֧��
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseModel CouponPay(ParaForCoponPayM model)
        {
            BaseResponseModel response = new BaseResponseModel();

            response.data = dal.CouponPay(model);
            ConvertResponseB.HandResponse(response, dal.LastError);
            return response;
        }

        /// <summary>
        /// ����������ѯ��Ч���Ż�ȯ
        /// </summary>
        /// <param name="MasterID"></param>
        /// <param name="type">0:��ͨ1�䷿��</param>
        /// <returns></returns>
        public List<ResultCouponM> GetCouponByMasterID(int MasterID, int type = 0) 
        {
            return dal.GetCouponByMasterID(MasterID, type);
        }

        /// <summary>
        /// ��鵱���Ƿ���ʹ�÷��۱���Ż�ȯ
        /// </summary>
        /// <param name="masterid"></param>
        /// <returns></returns>
        public bool CheckDayUser(int masterid,int couponid=0)
        {
            MasterD masD = new MasterD();
            MasterM masM = masD.GetM<MasterM>(masterid);
            if (masM == null)
            {
                return false;
            }
            if (!masM.Ing_Fk_VipCardID.HasValue || masM.Ing_Fk_VipCardID.Value == 0)
            {
                return false;
            }
            VipCardInfoD vipD = new VipCardInfoD();
            VipCardInfoM vipM = vipD.GetM<VipCardInfoM>(masM.Ing_Fk_VipCardID ?? 0);
            if (vipM == null)
            {
                return false;
            }
            //1,�ж�����û������ס�Ż�
            if (vipM == null || !vipM.Ing_FirstMaster.HasValue || vipM.Ing_FirstMaster.Value == masM.Ing_Pk_MasterID)
            {
                return false;
            }
            //3,�������Ƿ����Ѿ�ʹ����
            CouponDetailsM coupM = dal.GetCouponDetail(masterid);
            if (coupM != null) 
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// ͨ���Ż�ȯ�ı䷿��
        /// </summary>
        /// <param name="masterid"></param>
        /// <param name="couponid"></param>
        /// <returns></returns>
        public bool CouponPrice(int masterid, int couponid) 
        {
            if(!this.CheckDayUser(masterid))
            {
                return false;
            }
            //����Ż�ȯ�ǲ������ڱ���
            List<ResultCouponM> list = this.GetCouponByMasterID(masterid, 1);
            if (list == null || list.Count == 0)
            {
                return false;
            }
            if (list.Where(a => a.Ing_PaperID == couponid).Count()==0) 
            {
                return false;
            }
            if (!dal.CouponPrice(masterid, couponid)) 
            {
                return false;
            }
          return true;
        }

        /// <summary>
        /// �жϸ�������û��ʹ�ñ���Ż�ȯ
        /// </summary>
        /// <param name="masterid"></param>
        /// <returns></returns>
        public CouponDetailsM GetCouponDetail(int masterid)
        {
            return dal.GetCouponDetail(masterid);
        }
    }
}
