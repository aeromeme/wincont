using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using InventarioDB;
using System.Linq;

namespace winCont.Formularios.Inventario
{
    public partial class frm_existencia : winCont.Formularios.MasterForm_Consulta, Interfaz_forms
    {
        public List<V_INV_EXISTENCIA> lista;
        public frm_existencia()
        {
            InitializeComponent();
        }
        public frm_existencia(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarInventario();
                lista = (from u in _datasistema.ContextoInventario.V_INV_EXISTENCIA where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_PERIODO ==_datasistema .periodo .NM_PERIODO && u.NM_EJERCICIO ==_datasistema .periodo .NM_EJERCICIO select u
                    ).ToList();
                //llenarcombo();
                UIGRIDCONTROL.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count == 0)
                {
                    nuevo();
                }
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void nuevo()
        {
            //throw new NotImplementedException();
        }

        public void guardar()
        {
            //throw new NotImplementedException();
        }

        public void eliminar()
        {
            //throw new NotImplementedException();
        }

        public void imprimir()
        {
            //throw new NotImplementedException();
        }

        public void cerrar()
        {
            //throw new NotImplementedException();
            this.Close();
        }

        public void enlazar()
        {
            //throw new NotImplementedException();
        }

        public void desenlazar()
        {
            //throw new NotImplementedException();
        }

        public bool validar()
        {
            //throw new NotImplementedException();
            return true;
        }
        public override void refrescar()
        {
            consultar();
        }
    }
}
