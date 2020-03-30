using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DPU_Soft.PlacementOfExams.Common.Enums;
using System.Security;
using System.Windows.Forms;


namespace Dpu_Soft.PlacementOfExams.UI.Yonetim.Forms.Genelforms
{
    public partial class AnaForm : RibbonForm
    {
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private YetkilendirmeTuru _yetkilendirmeTuru;

        public AnaForm(params object[] prm)
        {

            InitializeComponent();
            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];

            longNavigator.Navigator.NavigatableControl = tablo.GridControl;
            EventsLoad();
            ButtonEnabledDurumu();
        }

        private void EventsLoad()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }
        }

        protected virtual void ShowEditForm(long id)
        {
            
            DPU_Soft.PlacementOfExams.UI.Win.Functions.GeneralFunctions.CreateConnectionString("DPU_Soft_PlacementOfExams_Yonetim",_server,_kullaniciAdi,_sifre,_yetkilendirmeTuru);
            var result = FormShow.ShowDialogeditForm(BaseKartTuru, id);
            ShowEditFormDefault(result);
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item==btnYeni||e.Item==btnDuzelt)
            {
                if (e.Item==btnYeni)
                {
                    ShowEditForm(-1);
                }
                else if (e.Item==btnDuzelt)
                {
                    ShowEditForm(tablo.GetRowId());
                }

            }
            else
            {

            }

            Cursor.Current = Cursors.Default;
        }

        private void ButtonEnabledDurumu()
        {

        }


    }
}