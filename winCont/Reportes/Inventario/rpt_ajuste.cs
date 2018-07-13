using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using InventarioDB;
using winCont.Clases;
using winCont.Clases.Reportes;

namespace winCont.Reportes.Inventario
{
    public partial class rpt_ajuste : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_ajuste()
        {
            InitializeComponent();
        }

        private void rpt_ajuste_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            cAjuste V = (cAjuste)GetCurrentRow();
            //String tipodoc = Convert.ToString(GetCurrentColumnValue("CD_TIPO_DOCUMENTO"));
            String tipodoc = V.encabezado .CD_TIPO_DOCUMENTO  ;
            if (tipodoc.Equals("AJS"))
            {
                uiprecio.Visible = false;
                uilblprecio.Visible = false;
            }
        }

    }
}
