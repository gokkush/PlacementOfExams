using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms
{
    public partial class KullanicibirimYetkileriEditForm : BaseEditForm
    {
        public KullanicibirimYetkileriEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnKaydet, btnSil, btnGeriAl };
            TabloYukle();
        }

        public override void Yukle()
        {

            subeTable.Yukle();
            donemTable.Yukle();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            
        }

        protected override void TabloYukle()
        {
            kullaniciTable.OvnerForm = this;
            subeTable.OvnerForm = this;
            donemTable.OvnerForm = this;
            kullaniciTable.Yukle();
        }

    }
}