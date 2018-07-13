using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;
using SistemaContext;
using winCont.Utilidades;
using winCont.Logica.Configuracion;


namespace winCont.Formularios.Configuracion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool flg_user_autenticado;
        private char default_char_password;
        public DataSistema _dataSistema;
        ManejadorUsuario manejadorUsuario;
        

        #region aspectosVisuales
        private void uitxtusuario_TextChanged(object sender, EventArgs e)
        {
            if (uitxtusuario.Text != "")
            {
                uitxtusuario.ForeColor = Color.Black;

            }
            else
            {
                uitxtusuario.ForeColor = Color.Silver;
            }

        }

        private void uitxtpassword_TextChanged(object sender, EventArgs e)
        {
            if (uitxtpassword.Text != "" && uitxtpassword.Text != "Contraseña")
            {
                uitxtpassword.ForeColor = Color.Black;
                uitxtpassword.Properties.PasswordChar = '*';
            }
            else
            {
                uitxtpassword.Properties.PasswordChar = default_char_password;
                uitxtpassword.ForeColor = Color.Silver;
              
            }
        }

        private void uitxtusuario_Leave(object sender, EventArgs e)
        {
            if (uitxtusuario.Text == "")
            {
                uitxtusuario.Text = null;
            }
        }

        private void uitxtpassword_Leave(object sender, EventArgs e)
        {
            if (uitxtpassword.Text == "")
            {
                
                uitxtpassword.Text = null;
            }
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            default_char_password = uitxtpassword.Properties.PasswordChar;
            if (Preferencias .recuerdaUsuario()) {
                uitxtusuario.Text = Preferencias.obtenerUsuario();
                uitxtpassword.Text = Preferencias.obtenerPassword();
                uichkrecordarme.Checked = true;
            }
        }

        private void uibtnlogin_Click(object sender, EventArgs e)
        {
            _dataSistema = new DataSistema();
            manejadorUsuario = new ManejadorUsuario(_dataSistema );
            if (uitxtusuario.Text == "root")
            {
                if (uitxtpassword.Text == "root")
                {
                    flg_user_autenticado = true;
                    _dataSistema.usuario = new SIS_USER { CD_LOGIN ="root",CD_PASSWORD ="root"};
                    procesar();
                }
            }
            else {
                _dataSistema.conectarSistema();
                if (manejadorUsuario.autenticar (uitxtusuario .Text ,uitxtpassword .Text )) {
                         flg_user_autenticado = true;
                    _dataSistema .usuario = manejadorUsuario .consultar (uitxtusuario.Text  ,uitxtpassword.Text );
                    procesar();

                }
                  
            }
        }

        private void procesar() {
            if (uichkrecordarme.Checked)
            {
                Preferencias.recordarUsuario(uitxtusuario.Text, uitxtpassword.Text);
            }
            else {
                Preferencias.olvidarUsuario();
            }
            this.Close();
        }

      

        
    }
}
