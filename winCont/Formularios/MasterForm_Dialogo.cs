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
    public partial class MasterForm_Dialogo : winCont.Formularios.MasterForm
    {
        public MasterForm_Dialogo()
        {
            InitializeComponent();
        }
        public MasterForm_Dialogo(DataSistema ds) : base(ds) {
            InitializeComponent();
        }
    }
}
