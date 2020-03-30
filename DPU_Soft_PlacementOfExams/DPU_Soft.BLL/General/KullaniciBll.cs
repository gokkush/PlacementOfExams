using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Data.Contexts;
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
    public class KullaniciBll : BaseGenelBll<KullaniciEntity>, IBaseGenelBll, IBaseCommonBll
    {

        public KullaniciBll():base(KartTuru.Kullanici)
        {

        }

        public KullaniciBll(Control ctrl) : base(ctrl,KartTuru.Kullanici)
        {

        }

        public override BaseEntity Single(Expression<Func<KullaniciEntity, bool>> filter)
        {
            return Basesingle(filter, x => new KullaniciS
            {
                Id = x.Id,
                Kod = x.Kod,
                FakulteAdi = x.Okul.FakulteAdi,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                OkulId = x.OkulId,
                Sifre = x.Sifre,
                GizliKelime = x.GizliKelime,
                durum = x.durum,
                Aciklama = x.Aciklama


            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<KullaniciEntity, bool>> filter)
        {
            return BaseList(filter, x => new KullaniciL
            {
                Id = x.Id,
                Kod = x.Kod,
                FakulteAdi = x.Okul.FakulteAdi,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();

        }


    }
}

