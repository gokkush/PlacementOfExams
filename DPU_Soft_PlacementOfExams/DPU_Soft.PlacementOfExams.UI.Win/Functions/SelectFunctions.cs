using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlceForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UniversiteForms;
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
                case "txtAdresIl":
                    {
                        var entity = (IlEntity)ShowListforms<IlListForm>.ShowDialogListForm(_kartTuru,_btnEdit.Id);
                        if (entity!=null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;
                case "txtIlce":
                case "txtAdresIlce":
                    {
                        var entity = (IlceEntity)ShowListforms<IlceListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;
                case "txtUnvAdi":
                    {
                        var entity = (UniversiteEntity)ShowListforms<UnvListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.UniversiteAdi;
                        }
                    }
                    break;
                case "txtDers":
                    {
                        var entity = (DersEntity)ShowListforms<DersListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.DersAdi;
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
