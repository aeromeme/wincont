using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ContabilidadDB;
using winCont.Utilidades;
using winCont.Logica.Contabilidad;


namespace winCont.Formularios.Contabilidad
{
    public partial class frm_cont_part : winCont.Formularios.MasterForm,Interfaz_forms 
    {
        ManejadorPartidaBorrador manejadorData;
        public frm_cont_part()
        {
            InitializeComponent();
        }
        public frm_cont_part(DataSistema ds): base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorPartidaBorrador(ds);
        }

        private void uibtn_cont_part_borr_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MetodosForm.preguntar("Esta seguro de contabilizar todas las partidas de borrador?"))
                {
                    return;
                }
                manejadorData.contabilizarPartida(_datasistema .empresa .ID,_datasistema .periodo );
                MetodosForm.mensajeInfo("Notificacion", "Operacion realizada con exito", _datasistema);
                
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void consultar()
        {
           
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
            this.Close();
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

        private void uibtndescontabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MetodosForm.preguntar("Esta seguro de revertir contabilizar todas las partidas de borrador?"))
                {
                    return;
                }
                manejadorData.descontabilizarPartida(_datasistema.empresa.ID, _datasistema.periodo);
                MetodosForm.mensajeInfo("Notificacion", "Operacion realizada con exito", _datasistema);
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

    }
}
