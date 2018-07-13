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
    public partial class MasterForm_Dialogo_Consulta : winCont.Formularios.MasterForm_Dialogo
    {
        public MasterForm_Dialogo_Consulta()
        {
            InitializeComponent();
        }
        public MasterForm_Dialogo_Consulta(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }
    }
}
