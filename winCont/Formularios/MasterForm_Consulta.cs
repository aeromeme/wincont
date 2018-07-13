using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;

namespace winCont.Formularios
{
    public partial class MasterForm_Consulta : winCont.Formularios.MasterForm
    {
        public MasterForm_Consulta()
        {
            InitializeComponent();
        }
        public MasterForm_Consulta(DataSistema ds) : base(ds)
        {
            InitializeComponent();
        }
        public virtual void refrescar()
        {

        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (uidialogogrid.ShowDialog() == DialogResult.OK)
                {
                    UIGRIDCONTROL.ExportToXlsx(uidialogogrid.FileName);
                }
            }
            catch (Exception)
            {

            }
        }

        private void MasterForm_Consulta_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        
    }
}
