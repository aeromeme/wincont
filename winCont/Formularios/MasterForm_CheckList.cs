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
    public partial class MasterForm_CheckList : winCont.Formularios.MasterForm
    {
        public bool flg_marca;
        public MasterForm_CheckList()
        {
            InitializeComponent();
        }
        public MasterForm_CheckList(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }
        public virtual void refrescar() { 
        
        }
        public virtual void enlazar_aux() { 
        
        }

        private void MasterForm_CheckList_Load(object sender, EventArgs e)
        {
            refrescar();
            //and datasistema porque visual extranamente ejecuta load en tiempo de diseno
             if(!flg_marca && _datasistema!=null) {
                GridCheckMarksSelection selec = new GridCheckMarksSelection(UIGRIDVIEW);
                 selec.CheckMarkColumn.VisibleIndex = 0;
                 flg_marca = true;
             }
        }

    }

}
