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
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavSalonForms
{
    public partial class SinavSalonuListForm : BaseListForm
    {
        public SinavSalonuListForm()
        {
            InitializeComponent();
            Bll = new SinavSalonuBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Salon;
            FormShow = new ShowEditforms<SinavSalonuEditForm>();
            base.Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinavSalonuBll)Bll).List(FilterFunctions.Filter<SinavSalonuEntity>(AktifKartlariGoster));
        }


    }
}