using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades ;

namespace winCont.Formularios
{
    public partial class MasterFormTab : winCont.Formularios.MasterForm
    {
        public MasterFormTab()
        {
            InitializeComponent();
        }
        public MasterFormTab(DataSistema ds):base(ds)
        {
            InitializeComponent();
        }
        public virtual void refrescar() { 
        
        }
        public virtual void enlazar_aux() { 
        
        }

        private void MasterFormTab_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (uidialogogrid.ShowDialog() == DialogResult.OK) {
                    uigridcontrol.ExportToXlsx(uidialogogrid.FileName);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void uigridview_DoubleClick(object sender, EventArgs e)
        {
            uimaintabcontrol.SelectedTabPageIndex = 0;
            enlazar_aux();
        }
    }
}
