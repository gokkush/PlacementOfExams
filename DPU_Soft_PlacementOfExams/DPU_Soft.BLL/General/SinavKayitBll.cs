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
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class SinavKayitBll:BaseGenelBll<SinavKayitEntity>,IBaseHareketSelectBll,IBaseCommonBll
    {

        public SinavKayitBll():base(KartTuru.SinavKayit)
        {

        }
        public SinavKayitBll(Control ctrl) : base(ctrl, KartTuru.SinavKayit)
        {

        }


        public override BaseEntity Single(Expression<Func<SinavKayitEntity, bool>> filter)
        {
            return Basesingle(filter, x => new SinavKayitS
            {
                Id = x.Id,
                Kod = x.Kod,
                DersId=x.DersId,
                SubeId=x.SubeId,
                DonemId=x.DonemId,
                DersAdi=x.Ders.DersAdi,
                Aciklama=x.Aciklama,
                SubeAdi=x.Sube.SubeAdi,
                DonemAdi=x.Donem.DonemAdi,
                SinavTuru=x.SinavTuru,
                ListeOlustu=x.ListeOlustu,
                durum=x.durum
            });
        }


        public SinavKayitR SingleDetail(Expression<Func<SinavKayitEntity, bool>> filter)
        {
            return Basesingle(filter, x => new SinavKayitR
            {
                DersAdi = x.Ders.DersAdi,
                SubeAdi = x.Sube.SubeAdi,
                DonemAdi = x.Donem.DonemAdi,
                SinavTuru = x.SinavTuru,
                Aciklama=x.Aciklama
            });
        }


        public override IEnumerable<BaseEntity> List(Expression<Func<SinavKayitEntity, bool>> filter)
        {
            return BaseList(filter, x => new SinavKayitL
            {
                Id = x.Id,
                Kod = x.Kod,
                DersAdi = x.Ders.DersAdi,
                SubeAdi = x.Sube.SubeAdi,
                DonemAdi = x.Donem.DonemAdi,
                SinavTuru = x.SinavTuru,
                ListeOlustu=x.ListeOlustu,
                Aciklama=x.Aciklama,
                Durum = x.durum



            }).OrderBy(x => x).ToList();

        }
    }
}
