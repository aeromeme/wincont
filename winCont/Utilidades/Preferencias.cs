using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCont.Utilidades
{
    class Preferencias
    {
        public static bool guardarConexion(String pip,String pbd, String pu, String pp) {
            winCont.Properties.Settings.Default.IP_SERVIDOR = pip;
            winCont.Properties.Settings.Default.NOMBRE_BD = pbd;
            winCont.Properties.Settings.Default.USUARIO_BD = pu;
            winCont.Properties.Settings.Default.PASSWORD_BD = pp;
            winCont.Properties.Settings.Default.Save();
            return true;
        }
        public static String obtenercadenaConexion() { 
        String cadena;
        cadena = @"Server=" + winCont.Properties.Settings.Default.IP_SERVIDOR +";uid=" + winCont.Properties.Settings.Default.USUARIO_BD + ";pwd=" + winCont.Properties.Settings.Default.PASSWORD_BD + ";database=" + winCont.Properties.Settings.Default.NOMBRE_BD + "";
        return cadena; 
        }
        public static string obtenerServidor() {
            return winCont.Properties.Settings.Default.IP_SERVIDOR;
        }
        public static string obtenerBaseDatos()
        {
            return winCont.Properties.Settings.Default.NOMBRE_BD;
        }
        public static string obtenerUsuarioBD()
        {
            return winCont.Properties.Settings.Default.USUARIO_BD ;
        }
        public static string obtenerPasswordBD()
        {
            return winCont.Properties.Settings.Default.PASSWORD_BD;
        }
        public static  bool recuerdaUsuario() {
            return winCont.Properties.Settings.Default.LOGIN_RECUERDAME;
        }
        public static string obtenerUsuario() {
            return winCont.Properties.Settings.Default.LOGIN_USER;
        }
        public static string obtenerPassword() {
            return winCont.Properties.Settings.Default.LOGIN_PASSWORD;
        }
        public static int obtenerNumeEmpre() {
            return winCont.Properties.Settings.Default.NUME_EMPRE;
        }
        public static int obtenerEmpreSel() {
            return winCont.Properties.Settings.Default.EMPRE_SEL;
        }
        public static int obtenerPeriodoSel() {
            return winCont.Properties.Settings.Default.PERIODO_SEL;
        }
        public static int obtenerEjercicioSel() {
            return winCont.Properties.Settings.Default.EJERCICIO_SEL;
        }
        public static void recordarUsuario(string usuario, string pass) {
            winCont.Properties.Settings.Default.LOGIN_USER = usuario;
            winCont.Properties.Settings.Default.LOGIN_PASSWORD = pass;
            winCont.Properties.Settings.Default.LOGIN_RECUERDAME = true;
            winCont.Properties.Settings.Default.Save();
        }
        public static void olvidarUsuario()
        {
            winCont.Properties.Settings.Default.LOGIN_USER = "";
            winCont.Properties.Settings.Default.LOGIN_PASSWORD = "";
            winCont.Properties.Settings.Default.LOGIN_RECUERDAME = false;
            winCont.Properties.Settings.Default.Save();
           
        }
        public static bool guardarNMEMPRE(int nmempre)
        {
            winCont.Properties.Settings.Default.NUME_EMPRE  = nmempre ;
            winCont.Properties.Settings.Default.Save();
            return true;
        }
        public static bool guardarParamGeneEmpre(int empresel) {
            winCont.Properties.Settings.Default.EMPRE_SEL  = empresel ;
            winCont.Properties.Settings.Default.Save();
            return true;
        }
        public static bool guardarParamGenePeriodo(int periodosel, int ejerciciosel)
        {
            winCont.Properties.Settings.Default.PERIODO_SEL = periodosel;
            winCont.Properties.Settings.Default.EJERCICIO_SEL = ejerciciosel;
            winCont.Properties.Settings.Default.Save();
            return true;
        }



    }
}
