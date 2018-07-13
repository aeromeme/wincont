using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using Sistema;
using System.Linq;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class form_sis_config : winCont.Formularios.MasterForm,Interfaz_forms 
    {
        List<SIS_CONFIG > lista;
        SIS_CONFIG  conf;
        ManejadorConfig manejadorData;
        
        public form_sis_config()
        {
            InitializeComponent();
        }
        public form_sis_config(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorConfig(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData .consultar () ;
                
                desenlazar();
                enlazar();
               
                if (lista.Count() == 0)
                {
                    nuevo();
                }
                else if (lista.Count() == 1)
                {
                    UINM_PROC_IVA.EditValue = lista[0].NM_PORC_IVA;
                    UINM_PORC_RETENCION.EditValue = lista[0].NM_PORC_RETENCION;
                    UINM_MONTO_SOBRE_RETENCION.EditValue = lista[0].NM_MONTO_SOBRE_RETENCION;
                    UINM_PORC_RENTA.EditValue = lista[0].NM_PORC_RENTA;
                }
                else {
                    MetodosForm.mensajeErrorDefault("Base de datos de configuracion invalida", _datasistema);
                }
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
            try
            {
                
                if (lista.Count() > 0)
                {

                    conf = lista.First();
                    conf.NM_PORC_IVA = (decimal)UINM_PROC_IVA .EditValue;
                    conf.NM_PORC_RENTA = (decimal)UINM_PORC_RENTA .EditValue;
                    conf.NM_PORC_RETENCION = (decimal)UINM_PORC_RETENCION .EditValue;
                    conf.NM_MONTO_SOBRE_RETENCION = (decimal)UINM_MONTO_SOBRE_RETENCION .EditValue;
                    manejadorData.modificar(conf);

                }
                else
                {
                    conf = new SIS_CONFIG()
                    {
                        ID_EMPRESA = _datasistema.empresa.ID,
                        NM_PORC_IVA = (decimal)UINM_PROC_IVA.EditValue,
                        NM_PORC_RENTA = (decimal)UINM_PORC_RENTA.EditValue,
                        NM_PORC_RETENCION = (decimal)UINM_PORC_RETENCION.EditValue,
                        NM_MONTO_SOBRE_RETENCION = (decimal)UINM_MONTO_SOBRE_RETENCION.EditValue
                    };
                    manejadorData.insertar(conf);
                    
                }
                consultar();
            }
            catch (Exception)
            {

                throw;
            }
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
      

        private void form_sis_config_Load(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
