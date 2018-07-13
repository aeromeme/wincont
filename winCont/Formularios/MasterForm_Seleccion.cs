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
    public partial class MasterForm_Seleccion : Form
    {
        public MasterForm_Seleccion()
        {
            InitializeComponent();
        }
        public MasterForm_Seleccion(DataSistema ds) {
            InitializeComponent();
            this.Text = ds.nombreVentana;
            _datasistema = ds;
        }
       public DataSistema _datasistema;


    }
}
