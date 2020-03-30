using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlceForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.UI.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        private DpuButtonEdit _btnEdit;
        private DpuButtonEdit _prmEdit;
        private KartTuru _kartTuru;

        public void Sec(DpuButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(DpuButtonEdit btnEdit,DpuButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }


        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtIl":
                    {
                        var entity = (IlEntity)ShowListforms<IlListForm>.ShowDialogListForm(_kartTuru,_btnEdit.Id);
                        if (entity!=null)
                        {
                            _btnEdit.Id = entity.id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;
                case "txtIlce":
                    {
                        var entity = (IlceEntity)ShowListforms<IlceListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id,_prmEdit.Id,_prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
