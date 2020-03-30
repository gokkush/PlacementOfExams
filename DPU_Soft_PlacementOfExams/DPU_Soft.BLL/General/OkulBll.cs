using DPU_Soft.BLL.Base;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Linq;
using DPU_Soft.BLL.Base.Interfaces;

namespace DPU_Soft.BLL.General
{
    public class OkulBll: BaseGenelBll<OkulEntity> , IBaseGenelBll,IBaseCommonBll
    {
        public OkulBll():base(KartTuru.Okul)
        {

        }
        public OkulBll(Control ctrl): base(ctrl,KartTuru.Okul)
        {

        }

        public override BaseEntity Single(Expression<Func<OkulEntity, bool>> filter)
        {
            return Basesingle(filter, x => new OkulS
            {
                Id = x.Id,
                Kod = x.Kod,
                FakulteAdi = x.FakulteAdi,
                UniversiteId = x.UniversiteId,
                UniversiteAdi = x.Universite.UniversiteAdi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama,
                durum = x.durum

            });


        }

        public override IEnumerable<BaseEntity> List(Expression<Func<OkulEntity, bool>> filter)
        {
            return BaseList(filter, x => new OkulL
            {
                Id = x.Id,
                Kod = x.Kod,
                FakulteAdi = x.FakulteAdi,
                UniversiteAdi = x.Universite.UniversiteAdi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
