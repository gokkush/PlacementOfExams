﻿using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle>-1)
            {
                return (long)tablo.GetFocusedRowCellValue("Id");
            }
            Messages.KartSecmemeHataMesaj();
            return -1;
        }

        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle>-1)
            {
                return (T)tablo.GetRow(tablo.FocusedRowHandle);
            }
            if (mesajVer)
            {
                Messages.KartSecmemeHataMesaj();
            }
            return default(T);


        }

        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {

                foreach (var prop in currentEntity.GetType().GetProperties())
                {
                    if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                    var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                    var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                    if (prop.PropertyType == typeof(byte[]))
                    {
                        if (string.IsNullOrEmpty(oldValue.ToString())) oldValue = new byte[] { 0 };
                        if (string.IsNullOrEmpty(currentValue.ToString())) currentValue = new byte[] { 0 };
                        if ((((byte[])oldValue).Length != (((byte[])currentValue).Length)))
                        {
                        return VeriDegisimYeri.Alan;
                        }
                    }
                    else if (!currentValue.Equals(oldValue))
                    {
                    return VeriDegisimYeri.Alan;
                    }
                }
            return VeriDegisimYeri.VeriDegisimiYok;
            
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity) 
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabeledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabeledDurumu;
            btnGeriAl.Enabled = buttonEnabeledDurumu;
            btnYeni.Enabled = !buttonEnabeledDurumu;
            btnSil.Enabled = !buttonEnabeledDurumu;
        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            string SifirEkle(string deger)
            {
                if (deger.Length==1)
                {
                    return "0" + deger;
                }
                return deger;
            }
            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;

                }
                return deger;
            }
            string Id()
            {
                var yil = SifirEkle(DateTime.Now.Year.ToString());
                var ay = SifirEkle(DateTime.Now.Month.ToString());
                var gun = SifirEkle(DateTime.Now.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Second.ToString());
                var miliSaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var randomSayi = SifirEkle(new Random().Next(0,99).ToString());
                return yil + ay + gun + saat + dakika + saniye + miliSaniye + randomSayi;
            }
            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.id : long.Parse(Id());

        }
    }
}