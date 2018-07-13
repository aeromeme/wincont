using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using ContabilidadDB;
using System.Linq;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_desactu_part_borr : winCont.Formularios.MasterForm_CheckList,Interfaz_forms 
    {
        List<V_CONT_ENCA_PART_BORRADOR> lista ;
        List<V_CONT_ENCA_PART_BORRADOR> lista_aux ;
        ManejadorPartidaBorrador manejadorPartida;
        ManejadorDetallePartidaBorrrador manejadorDetallePartida;
        public frm_desactu_part_borr()
        {
            InitializeComponent();
        }
        public frm_desactu_part_borr(DataSistema ds) : base(ds) {
            InitializeComponent();
            manejadorPartida = new ManejadorPartidaBorrador(ds);
            manejadorDetallePartida = new ManejadorDetallePartidaBorrrador(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista_aux = manejadorPartida .consultarVistaPorIdEmpresaPorPeriodoPorEstadoActualizada (_datasistema .empresa .ID,_datasistema.periodo );
                lista = new List<V_CONT_ENCA_PART_BORRADOR>();
                foreach (var item in lista_aux)
                {
                    V_CONT_DETA_PART_BORR_AUX aux = manejadorDetallePartida.consultarVistaAuxPorIdEnca(item.ID);
                    if (aux.NM_ABONO == aux.NM_CARGO && aux.NM_ABONO > 0)
                    {
                        lista.Add(item);
                    }
                }

                UIGRIDCONTROL .DataSource = lista;

            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void nuevo()
        {
           
        }

        public void guardar()
        {
           
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
        public override void refrescar()
        {
            consultar();
        }

        private void uirbnbtn_actu_massive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MetodosForm.preguntar("Esta seguro de desactualizar las partidas de borrador seleccionadas?"))
            {
                return;
            }
            List<CONT_ENCA_PART_BORRADOR> listado = new List<CONT_ENCA_PART_BORRADOR> ();
            CONT_ENCA_PART_BORRADOR tupla;
            Array.ForEach
           (
               UIGRIDVIEW .GetSelectedRows(),
               //cell => listado.Add((from u in _datasistema .ContextoContabilidad .CONT_ENCA_PART_BORRADOR where u.ID == ((V_CONT_ENCA_PART_BORRADOR )UIGRIDVIEW .GetRow (cell)).ID   select u).First()) 
               cell=>listado.Add (manejadorPartida .consultarPorId (((V_CONT_ENCA_PART_BORRADOR )UIGRIDVIEW .GetRow (cell)).ID))
           );
            foreach (var item in listado)
            {
                item.CD_ESTA_PART = 'D';
                //_datasistema.ContextoContabilidad.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoContabilidad.SubmitChanges();
                //consultar();
                manejadorPartida .modificar (item);
            }
            consultar ();

        }
    }
}
