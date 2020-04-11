using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Drawing;
using System.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace DPU_Soft.PlacementOfExams.UI.Win.Functions
{
    public class SelectRowFunctions
    {
        private GridView _tablo;
        private GridColumn _kolon;
        private readonly IList<BaseEntity> _selectedRows;
        private RepositoryItemCheckEdit _checkEdit;

        public SelectRowFunctions(GridView tablo)
        {
            _tablo = tablo;
            _selectedRows = new List<BaseEntity>();

            RemoveEvents();
            AddEvents(tablo);
        }

        public int SelectedRowCount()
        {
            return _selectedRows.Count();
        }

        public BaseEntity GetSelectedRow(int index)
        {
            return _selectedRows[index];
        }

        public IList<BaseEntity> GetSelectedRows()
        {
            return _selectedRows;
        }

        public int GetSelectedRowIndex(BaseEntity row)
        {
            return _selectedRows.IndexOf(row);
        }

        public bool IsRowSelected(int rowHandle)
        {
            var row = (BaseEntity)_tablo.GetRow(rowHandle);
            return GetSelectedRowIndex(row)>-1;
        }

        public void SelectAll()
        {
            _selectedRows.Clear();
            for (int i = 0; i < _tablo.DataRowCount; i++)
                _selectedRows.Add(_tablo.GetRow<BaseEntity>(i));
            Update();
        }

        private void Update()
        {
            _tablo.BeginUpdate();
            _tablo.EndUpdate();
        }

        public void ClearSelection()
        {
            _selectedRows.Clear();
            Update();
        }

        private void SelectRow(int rowHandle, bool select)
        {
            if (IsRowSelected(rowHandle) == select) return;
            var row = _tablo.GetRow<BaseEntity>(rowHandle);

            if (select)
                _selectedRows.Add(row);
            else
                _selectedRows.Remove(row);

            Update();
        }

        public void RowSelection(int rowHandle)
        {
            if (!_tablo.IsDataRow(rowHandle)) return;
            SelectRow(rowHandle, !IsRowSelected(rowHandle));
        }

        private void AddEvents(GridView tablo)
        {
            if (tablo == null) return;
            _selectedRows.Clear();
            _tablo = tablo;
            _checkEdit = (RepositoryItemCheckEdit)_tablo.GridControl.RepositoryItems.Add("CheckEdit");
            _kolon= tablo.Columns.Add();
            _kolon.OptionsColumn.AllowSort = DefaultBoolean.False;
            _kolon.Visible = true;
            _kolon.VisibleIndex = 0;
            _kolon.FieldName = "Secim";
            _kolon.OptionsColumn.ShowCaption = false;
            _kolon.OptionsColumn.AllowEdit = false;
            _kolon.OptionsColumn.AllowSize = false;
            _kolon.UnboundType = UnboundColumnType.Boolean;
            _kolon.Width = 35;
            _kolon.ColumnEdit = _checkEdit;
            _tablo.FocusedColumn = _kolon;
            if (_tablo is BandedGridView bView)
            {
                bView.Bands["bndSecim"].Visible = true;
                bView.Bands["bndSecim"].VisibleIndex = 0;
                bView.Bands["bndSecim"].Columns.Add((BandedGridColumn)_kolon);
            }

            _tablo.Click += Tablo_Click;
            _tablo.CustomDrawColumnHeader += Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            _tablo.KeyDown += Tablo_KeyDown;
            _tablo.RowStyle += Tablo_RowStyle;
        }

        private void RemoveEvents()
        {
            if (_tablo == null) return;
            _kolon?.Dispose();

            if (_checkEdit!=null)
            {
                _tablo.GridControl.RepositoryItems.Remove(_checkEdit);
                _checkEdit.Dispose();
            }
            _tablo.Click -= Tablo_Click;
            _tablo.CustomDrawColumnHeader -= Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData -= Tablo_CustomUnboundColumnData;
            _tablo.KeyDown -= Tablo_KeyDown;
            _tablo.RowStyle -= Tablo_RowStyle;

            _tablo = null;
        }

        private void CheckBoxEkle(GraphicsCache cache, Rectangle r, bool checks)
        {
            var info = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
            var painter = (CheckEditPainter)_checkEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = checks;
            info.Bounds = r;
            info.CalcViewInfo(cache.Graphics);
            var arg = new ControlGraphicsInfoArgs(info, cache, r);
            painter?.Draw(arg);
        }

        private void Tablo_Click(object sender, EventArgs e)
        {
            var point = _tablo.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = _tablo.CalcHitInfo(point);

            if (info.Column == _kolon)
            {
                if (info.InColumn)
                {
                    if (SelectedRowCount() == _tablo.RowCount)
                        ClearSelection();
                    else
                        SelectAll();
                }
                else if (info.InRowCell)
                    RowSelection(info.RowHandle);
            }
            else if (info.InRow)
                RowSelection(info.RowHandle);
        }

        private void Tablo_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != _kolon) return;
            e.Info.InnerElements.Clear();
            e.Painter.DrawObject(e.Info);
            CheckBoxEkle(e.Cache,e.Bounds,SelectedRowCount()==_tablo.RowCount);
            e.Handled = true;
        }

        private void Tablo_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column != _kolon) return;
            e.Value = IsRowSelected(_tablo.GetRowHandle(e.ListSourceRowIndex));
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;
            RowSelection(_tablo.FocusedRowHandle);
        }
        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (!IsRowSelected(e.RowHandle)) return;
            e.Appearance.BackColor = SystemColors.Highlight;
            e.Appearance.ForeColor = SystemColors.HighlightText;
        }

    }
}
