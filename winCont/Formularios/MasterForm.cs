using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winCont.Utilidades;

namespace winCont.Formularios
{
    public partial class MasterForm : Form
    {
        public DataSistema _datasistema;

        public MasterForm(DataSistema ds)
        {
            InitializeComponent();
            _datasistema = ds;
            this.Text = _datasistema.nombreVentana;
            uilbl_opcion.Text = _datasistema.nombreOpcion;
        }
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Activated(object sender, EventArgs e)
        {
            _datasistema.mainForm.adaptarInterfaz(_datasistema.modoInterfaz);
        }

        private void MasterForm_Leave(object sender, EventArgs e)
        {
            _datasistema.mainForm.adaptarInterfaz(0);
        }
       
    }
}
