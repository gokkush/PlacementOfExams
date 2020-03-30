using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.Common.Enums;
using System.Drawing;
using System.Drawing.Printing;
using System;

namespace DPU_Soft.PlacementOfExams.UI.Win.Functions
{
    public class TablePrintingFunctions
    {
        private static GridView _tablo;
        private static string _fakulteAdi;
        private static PrintableComponentLink _link;
        private static PrintingSystem _ps;
        private static DokumParametreleri _dp;
        public static void Yazdir(GridView tablo, string raporBaslik, string fakulteAdi)
        {
            _link = new PrintableComponentLink();
            _ps = new PrintingSystem();
            _tablo = tablo;
            _fakulteAdi = fakulteAdi;
            _dp = ShowEditforms<TabloDokumParametreleri>.ShowDialogEditForm<DokumParametreleri>(raporBaslik);

            RapoprDokumu();
        }

        private static void RapoprDokumu()
        {
            Baslikekle();
            RaporuKagidaSigdirmak();

            _tablo.OptionsPrint.PrintHorzLines = _dp.YatayCizgileriGoster == EvetHayir.Evet;
            _tablo.OptionsPrint.PrintVertLines = _dp.DikeyCizgileriGoster== EvetHayir.Evet;
            _tablo.OptionsPrint.PrintHeader = _dp.SutunBasliklariniGoster == EvetHayir.Evet;
            _tablo.OptionsView.ShowViewCaption = false;

            _link.Component = _tablo.GridControl;
            _link.PaperKind = PaperKind.Letter;
            _link.Margins = new Margins(59,59,115,48);
            _link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;
            _link.CreateDocument(_ps);


            switch (_dp.DokumSekli)
            {
                case DokumSekli.TabloBaskiOnizleme:
                    ShowRibbonForms<RaporOnizleme>.ShowForm(true,_ps,_dp.RaporBaslik);
                    break;
                case DokumSekli.TabloYazdir:
                    for (int i = 0; i < _dp.YazdirilacakAdet; i++)
                    {
                        _link.Print(_dp.YaziciciAdi);
                    }
                    break;
            }

            _tablo.OptionsView.ShowViewCaption = true;


        }

        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (_dp.BaslikEkle == EvetHayir.Hayir) return;
            var boldFont = new Font("Tahoma", 7, FontStyle.Bold);
            var regularFont = new Font("Tahoma", 7, FontStyle.Regular);
            var sayfaBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                PageInfo = PageInfo.NumberOfTotal,
                Format="Sayfa: {0} / {1}",
                Alignment=BrickAlignment.Far,
                AutoWidth=true
            };
            _ps.Graph.DrawBrick(sayfaBrick, new RectangleF(200, 25, 40, 15));

            var tarihBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                PageInfo = PageInfo.DateTime,
                Format = "Tarih: {0:dd:MM:yyyy}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true
            };
            _ps.Graph.DrawBrick(tarihBrick, new RectangleF(0, 40, 50, 15));

            var fakulteBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldFont,
                Text = "Fakülte"
            };
            _ps.Graph.DrawBrick(fakulteBaslikBrick, new RectangleF(0, 25, 40, 15));

            var fakulteDegerBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                Text = ":  " + _fakulteAdi
            };
            _ps.Graph.DrawBrick(fakulteDegerBrick, new RectangleF(55, 25, 500, 15));

            var dersBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldFont,
                Text = "Ders"
            };
            _ps.Graph.DrawBrick(dersBaslikBrick, new RectangleF(0, 40, 40, 15));

            var dersDegerBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                Text = ":  " + AnaForm.SubeAdi
            };
            _ps.Graph.DrawBrick(dersDegerBrick, new RectangleF(55, 40, 200, 15));

        }

        private static void RaporuKagidaSigdirmak()
        {
            YazdirmaYonuAyarla();
            switch (_dp.RaporKagidaSigdirma)
            {
                case RaporuKagidaSigdir.SutunlariDaraltarakSigdir:
                    _tablo.OptionsPrint.AutoWidth = true;
                    break;
                case RaporuKagidaSigdir.YaziBoyutunuKücülterekSigdir:
                    _tablo.OptionsPrint.AutoWidth = false;
                    _ps.Document.AutoFitToPagesWidth = 1;
                    break;
                default:
                    _tablo.OptionsPrint.AutoWidth = false;
                    _ps.Document.ScaleFactor = 1.0f;
                    break;
            }
        }

        private static void YazdirmaYonuAyarla()
        {
            switch (_dp.YazdirmaYonu)
            {
                case YazdirmaYonu.Dikey:
                    _link.Landscape = false;
                    break;
                case YazdirmaYonu.Yatay:
                    _link.Landscape = true;
                    break;
                case YazdirmaYonu.Otomatik:
                    _link.Landscape = OtomatikYazdirmaYonu();
                    break;
            }
        }

        private static bool OtomatikYazdirmaYonu()
        {
            const int sayfaGenisligi = 703;
            var tabloSutunGenislikleri = 0;
            for (int i = 0; i < _tablo.Columns.Count; i++)
                if (_tablo.Columns[i].Visible)
                    tabloSutunGenislikleri += _tablo.Columns[i].Width;
            return tabloSutunGenislikleri > sayfaGenisligi;
                
        }

        private static void Baslikekle()
        {
            if (_dp.BaslikEkle == EvetHayir.Hayir) return;
            var headetArea = new PageHeaderArea();
            headetArea.Content.AddRange(new[] {"",_dp.RaporBaslik,"" } );
            headetArea.Font = new Font("Arial Narrow",10f,FontStyle.Bold);
            headetArea.LineAlignment = BrickAlignment.Far;
            _link.PageHeaderFooter = new PageHeaderFooter(headetArea,null);


        }
    }
}
