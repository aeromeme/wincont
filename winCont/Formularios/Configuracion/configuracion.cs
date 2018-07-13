using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;

namespace winCont.Formularios.Configuracion
{
    public partial class configuracion : winCont.Formularios.MasterForm,Interfaz_forms 
    {
        public configuracion()
        {
            InitializeComponent();
        }
        public configuracion(DataSistema ds):base(ds) {
            InitializeComponent();
        }

        public void consultar()
        {
            uitxtbasedatos.Text = Preferencias.obtenerBaseDatos ();
            uitxtservidor .Text = Preferencias.obtenerServidor ();
            uitxtusuario.Text = Preferencias.obtenerUsuarioBD();
            uitxtpassword.Text = Preferencias.obtenerPasswordBD();
            UINUME_EMPRE.EditValue = Preferencias.obtenerNumeEmpre();
     
        }

        public void nuevo()
        {
           
        }

        public void guardar()
        {
            Preferencias.guardarConexion(uitxtservidor.Text, uitxtbasedatos.Text, uitxtusuario.Text, uitxtpassword.Text);
            Preferencias.guardarNMEMPRE(int.Parse (UINUME_EMPRE.EditValue.ToString ()));
           
        }

        public void eliminar()
        {
           
        }

        public void imprimir()
        {
            
        }

        public void cerrar()
        {
           
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
            consultar();
        }


        public void enlazar()
        {
            
        }

        public void desenlazar()
        {
            
        }

        public bool validar()
        {
            return true;
        }
    }
}
