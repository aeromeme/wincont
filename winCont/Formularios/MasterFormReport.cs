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
    public partial class MasterFormReport : winCont.Formularios.MasterForm
    {
        public MasterFormReport()
        {
            InitializeComponent();
        }
        public MasterFormReport(DataSistema ds) : base(ds) {
            InitializeComponent();
        }
        
    }
}
