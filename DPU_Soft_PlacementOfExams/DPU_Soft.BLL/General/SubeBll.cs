using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class SubeBll : BaseGenelBll<SubeEntity>, IBaseHareketSelectBll, IBaseCommonBll
    {
        // private KartTuru _kartTuru;
        public SubeBll() : base(KartTuru.Sube)
        {

        }
        public SubeBll(Control ctrl) : base(ctrl, KartTuru.Sube)
        {

        }

        public override BaseEntity Single(Expression<Func<SubeEntity, bool>> filter)
        {
            return Basesingle(filter, x => new SubeS
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Adres = x.Adres,
                AdresIlId = x.AdresIlId,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceId = x.AdresIlceId,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
                Telefon = x.Telefon,
                Faks = x.Faks,

                durum = x.durum

            }) ;


        }

        public override IEnumerable<BaseEntity> List(Expression<Func<SubeEntity, bool>> filter)
        {
            return BaseList(filter, x => new SubeL
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi=x.SubeAdi,
                Adres=x.Adres,
                AdresIlAdi=x.AdresIl.IlAdi,
                AdresIlceAdi=x.AdresIlce.IlceAdi,
                Telefon = x.Telefon,
                Faks = x.Faks

            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
