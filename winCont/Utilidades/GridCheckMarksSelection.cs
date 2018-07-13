using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace winCont.Utilidades
{
    class GridCheckMarksSelection
    {
        protected GridView view;
        protected ArrayList selection;
        //VCL - added to track gridview row handle, so we can use GetRowCellValue method to retrieve data for anonymous type
        //VCL - since Row Handles can be reassigned after sorting, filtering and grouping
        //      so use Datasource indexes using GetDataSourceRowIndex method instead
        //      and then get required data using GetListSourceRowCellValue method
        //protected ArrayList selectionRowHandle;
        protected ArrayList selectionDataSourceIndex;
        private GridColumn column;
        private RepositoryItemCheckEdit edit;


        public GridCheckMarksSelection()
            : base()
        {
            selection = new ArrayList();
            //selectionRowHandle = new ArrayList(); //VCL
            selectionDataSourceIndex = new ArrayList(); //VCL
        }

        public GridCheckMarksSelection(GridView view)
            : this()
        {
            View = view;
        }

        protected virtual void Attach(GridView view)
        {
            if (view == null) return;
            selection.Clear();
            this.view = view;
            edit = view.GridControl.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;
            edit.EditValueChanged += new EventHandler(edit_EditValueChanged);

            column = view.Columns.Add();
            column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            column.VisibleIndex = int.MaxValue;
            column.FieldName = "CheckMarkSelection";
            column.Caption = Environment.NewLine;
            column.OptionsColumn.ShowCaption = true;

            column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            column.ColumnEdit = edit;

            view.Click += new EventHandler(View_Click);
            view.CustomDrawColumnHeader += new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            view.CustomDrawGroupRow += new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            view.CustomUnboundColumnData += new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            view.RowStyle += new RowStyleEventHandler(view_RowStyle);
            view.MouseDown += new MouseEventHandler(view_MouseDown); // clear selection
        }

        protected virtual void Detach()
        {
            if (view == null) return;
            if (column != null)
                column.Dispose();
            if (edit != null)
            {
                view.GridControl.RepositoryItems.Remove(edit);
                edit.Dispose();
            }

            view.Click -= new EventHandler(View_Click);
            view.CustomDrawColumnHeader -= new ColumnHeaderCustomDrawEventHandler(View_CustomDrawColumnHeader);
            view.CustomDrawGroupRow -= new RowObjectCustomDrawEventHandler(View_CustomDrawGroupRow);
            view.CustomUnboundColumnData -= new CustomColumnDataEventHandler(view_CustomUnboundColumnData);
            view.RowStyle -= new RowStyleEventHandler(view_RowStyle);
            view.MouseDown -= new MouseEventHandler(view_MouseDown);

            view = null;
        }

        protected void DrawCheckBox(Graphics g, Rectangle r, bool Checked)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = edit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;
            info.Bounds = r;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }

        private void View_Click(object sender, EventArgs e)
        {
            GridHitInfo info;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            info = view.CalcHitInfo(pt);
            if (info.InColumn && info.Column == column)
            {
                if (SelectedCount == view.DataRowCount)
                    ClearSelection();
                else
                    SelectAll();
            }
            if (info.InRow && view.IsGroupRow(info.RowHandle) && info.HitTest != GridHitTest.RowGroupButton)
            {
                bool selected = IsGroupRowSelected(info.RowHandle);
                SelectGroup(info.RowHandle, !selected);
            }
        }

        //VCL - remove to only allow user to click on checkbox to select not row
        private void view_MouseDown(object sender, MouseEventArgs e)
        {
            //if(e.Clicks == 1 && e.Button == MouseButtons.Left) {
            //    GridHitInfo info;
            //    Point pt = view.GridControl.PointToClient(Control.MousePosition);
            //    info = view.CalcHitInfo(pt);
            //    if(info.InRow && info.Column != column && view.IsDataRow(info.RowHandle)) {
            //        ClearSelection();
            //        SelectRow(info.RowHandle, true);
            //    }
            //}
        }

        private void View_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == column)
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e.Graphics, e.Bounds, SelectedCount == view.DataRowCount);
                e.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                e.Appearance.Options.UseTextOptions = true;

                e.Handled = true;
            }
        }

        private void View_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info;
            info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;

            info.GroupText = "         " + info.GroupText.TrimStart();
            e.Info.Paint.FillRectangle(e.Graphics, e.Appearance.GetBackBrush(e.Cache), e.Bounds);
            e.Painter.DrawObject(e.Info);

            Rectangle r = info.ButtonBounds;
            r.Offset(r.Width * 2, 0);
            DrawCheckBox(e.Graphics, r, IsGroupRowSelected(e.RowHandle));
            e.Handled = true;
        }

        private void view_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (IsRowSelected(e.RowHandle))
            {
                e.Appearance.BackColor = SystemColors.Highlight;
                e.Appearance.ForeColor = SystemColors.HighlightText;
            }
        }

        public GridView View
        {
            get
            {
                return view;
            }
            set
            {
                if (view != value)
                {
                    Detach();
                    Attach(value);
                }
            }
        }

        public GridColumn CheckMarkColumn
        {
            get
            {
                return column;
            }
        }

        public int SelectedCount
        {
            get
            {
                return selection.Count;
            }
        }

        public object GetSelectedRow(int index)
        {
            return selection[index];
        }

        public int GetSelectedIndex(object row)
        {
            return selection.IndexOf(row);
        }

        //VCL - track actual gridview row handle
        //public int GetSelectedRowHandle(int index)
        //{
        //    return Convert.ToInt32(selectionRowHandle[index].ToString());
        //}
        //VCL - track actual datasource index
        public int GetSelectedDataSourceIndex(int index)
        {
            return Convert.ToInt32(selectionDataSourceIndex[index].ToString());
        }

        public void ClearSelection()
        {
            selection.Clear();
            //selectionRowHandle.Clear(); //VCL
            selectionDataSourceIndex.Clear(); //VCL
            Invalidate();
        }

        private void Invalidate()
        {
            view.BeginUpdate();
            view.EndUpdate();
        }

        //VCL - allow handle LINQ Data Source
        public void SelectAll()
        {
            selection.Clear();
            //original code does not work with filtered row
            //if(view.DataSource is ICollection)
            //    selection.AddRange(((ICollection)view.DataSource));  // fast
            //else
            //    for(int i = 0; i < view.DataRowCount; i++)  // slow
            //        selection.Add(view.GetRow(i));
            //replacing code that should work with filter row
            for (int i = 0; i < view.DataRowCount; i++)
            {
                selection.Add(view.GetRow(i));
                //selectionRowHandle.Add(i); //VCL
                selectionDataSourceIndex.Add(view.GetDataSourceRowIndex(i)); //VCL
            }
            Invalidate();
        }

        public void SelectGroup(int rowHandle, bool select)
        {
            if (IsGroupRowSelected(rowHandle) && select) return;
            for (int i = 0; i < view.GetChildRowCount(rowHandle); i++)
            {
                int childRowHandle = view.GetChildRowHandle(rowHandle, i);
                if (view.IsGroupRow(childRowHandle))
                    SelectGroup(childRowHandle, select);
                else
                    SelectRow(childRowHandle, select, false);
            }
            Invalidate();
        }

        public void SelectRow(int rowHandle, bool select)
        {
            SelectRow(rowHandle, select, true);
        }

        private void SelectRow(int rowHandle, bool select, bool invalidate)
        {
            if (IsRowSelected(rowHandle) == select) return;
            object row = view.GetRow(rowHandle);
            if (select)
            {
                selection.Add(row);
                //selectionRowHandle.Add(rowHandle); //VCL
                selectionDataSourceIndex.Add(view.GetDataSourceRowIndex(rowHandle)); //VCL
            }
            else
            {
                selection.Remove(row);
                //selectionRowHandle.Remove(rowHandle); //VCL
                selectionDataSourceIndex.Remove(view.GetDataSourceRowIndex(rowHandle)); //VCL
            }
            if (invalidate)
            {
                Invalidate();
            }
        }

        public bool IsGroupRowSelected(int rowHandle)
        {
            for (int i = 0; i < view.GetChildRowCount(rowHandle); i++)
            {
                int row = view.GetChildRowHandle(rowHandle, i);
                if (view.IsGroupRow(row))
                {
                    if (!IsGroupRowSelected(row)) return false;
                }
                else
                    if (!IsRowSelected(row)) return false;
            }
            return true;
        }

        public bool IsRowSelected(int rowHandle)
        {
            if (view.IsGroupRow(rowHandle))
                return IsGroupRowSelected(rowHandle);

            object row = view.GetRow(rowHandle);
            return GetSelectedIndex(row) != -1;
        }

        private void view_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column == CheckMarkColumn)
            {
                if (e.IsGetData)
                    //e.Value = IsRowSelected(e.RowHandle);
                    e.Value = IsRowSelected(e.ListSourceRowIndex); //07/19/2011 - replace obsolete properties
                else
                    //SelectRow(e.RowHandle, (bool)e.Value);
                    SelectRow(e.ListSourceRowIndex, (bool)e.Value);
            }
        }

        private void edit_EditValueChanged(object sender, EventArgs e)
        {
            view.PostEditor();
        }
    }
}
