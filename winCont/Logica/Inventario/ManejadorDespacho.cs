using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;
using Sistema;

namespace winCont.Logica.Inventario
{
    class ManejadorDespacho : Interfaz_logica<INV_ENCA_DESP >
    {
        private DataSistema _datasistema;
        public ManejadorDespacho(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<INV_ENCA_DESP> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_ENCA_DESP> l = new List<INV_ENCA_DESP>();
            l = (from u in _datasistema.ContextoInventario.INV_ENCA_DESP
                 select u).ToList();
            return l;
        }
        public List<INV_ENCA_DESP> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_ENCA_DESP> l = new List<INV_ENCA_DESP>();
            l = (from u in _datasistema.ContextoInventario.INV_ENCA_DESP
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public V_INV_ENCA_DESP consultarVistaPorId(int id)
        {
            _datasistema.conectarInventario();
            V_INV_ENCA_DESP l;
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_DESP
                 where u.ID == id
                 select u).First();
            return l;
        }

        public List<V_INV_ENCA_DESP> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<V_INV_ENCA_DESP> l = new List<V_INV_ENCA_DESP>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_DESP
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<V_INV_ENCA_DESP> consultarVistaPorIdEmpresaPeriodo(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarInventario();
            List<V_INV_ENCA_DESP> l = new List<V_INV_ENCA_DESP>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_DESP
                 where u.ID_EMPRESA == idEmpresa && u.NM_EJERCICIO == periodo.NM_EJERCICIO && u.NM_PERIODO == periodo.NM_PERIODO
                 select u).ToList();
            return l;
        }
        public INV_ENCA_DESP insertar(INV_ENCA_DESP data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_DESP s = data;
            _datasistema.ContextoInventario.INV_ENCA_DESP.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ENCA_DESP modificar(INV_ENCA_DESP data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_DESP s = (from u in _datasistema.ContextoInventario.INV_ENCA_DESP
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("La requisicion ya esta actualizada");
            }
            s.DS_NOMBRE_DESPACHADOR = data.DS_NOMBRE_DESPACHADOR;
            s.DS_REFERENCIA = data.DS_REFERENCIA;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ENCA_DESP eliminar(INV_ENCA_DESP data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_DESP s = (from u in _datasistema.ContextoInventario.INV_ENCA_DESP
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("La requisicion ya esta actualizada");
            }
            _datasistema.ContextoInventario.INV_ENCA_DESP.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
        public INV_ENCA_DESP despachar(INV_ENCA_DESP data) {
            _datasistema.conectarInventario();
            INV_ENCA_DESP p = (from u in _datasistema.ContextoInventario.INV_ENCA_DESP
                               where u.ID == data.ID
                               select u).First();
            List<V_INV_DETA_DESP> lista_deta = (from u in _datasistema.ContextoInventario.V_INV_DETA_DESP
                               where u.ID == data.ID
                               select u).ToList();
                if (p.CD_ESTA_DOCUMENTO == 'D')
                {
                        int? error = 0;
                        string msj = string.Empty;

                        ///valida si hay existencia
                        foreach (var item in lista_deta)
                        {
                                INV_ARTICULO art = (from u in _datasistema.ContextoInventario.INV_ARTICULO where u.ID == item.ID_ARTICULO select u).First();
                                if ((from u in _datasistema.ContextoInventario.INV_EXISTENCIA
                                     where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO && u.ID_BODEGA == p.ID_UBICACION_DESP && u.ID_ARTICULO == item.ID_ARTICULO
                                     select u).Count() <= 0 && art.FLG_INVENTARIABLE == 'S')
                                {
                                    throw new Exception("El articulo " + item.DS_NOMBRE + " no es inventariable ");
                                }

                                INV_EXISTENCIA exist = (from u in _datasistema.ContextoInventario.INV_EXISTENCIA
                                                        where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO && u.ID_BODEGA == p.ID_UBICACION_DESP && u.ID_ARTICULO == item.ID_ARTICULO
                                                        select u).First();
                                if (exist.NM_CANT_ACTUAL < item.NM_CANTIDAD && art.FLG_INVENTARIABLE == 'S')
                                {
                                    throw new Exception ("No hay suficientes existencias del " + item.DS_NOMBRE + " para despacharlo");
                                }
                                INV_DETA_REQ req = (from u in _datasistema.ContextoInventario.INV_DETA_REQ
                                                    where u.ID == item.ID_DETA_REQ
                                                    select u).First();
                                if (item.NM_CANTIDAD > req.NM_CANTIDAD - req.NM_CANT_DESP && item.FLG_DESP != 'S')
                                {
                                    throw new Exception ("El articulo " + item.DS_NOMBRE + " solo tiene pendiente de despachar " + (req.NM_CANTIDAD - req.NM_CANT_DESP).ToString());
                                }
                        }

                        foreach (var item in lista_deta)
                        {
                            INV_ARTICULO art = (from u in _datasistema.ContextoInventario.INV_ARTICULO where u.ID == item.ID_ARTICULO select u).First();
                            if (item.FLG_DESP != 'S')
                            {
                                if (art.FLG_INVENTARIABLE == 'S')
                                {
                                    _datasistema.ContextoInventario.PR_INV_PROC_DESPACHO(_datasistema.empresa.ID, p.ID_UBICACION_DESP, p.NM_EJERCICIO, p.NM_PERIODO, item.ID_ARTICULO, item.NM_CANTIDAD, p.ID, p.ID_TIPO_DOCUMENTO, p.CD_SERIE + p.CD_NUMERO.ToString(), ref error, ref msj);
                                }
                                if (error == 0)
                                {
                                    INV_DETA_DESP d = (from u in _datasistema.ContextoInventario.INV_DETA_DESP
                                                       where u.ID == item.ID
                                                       select u).First();
                                    INV_DETA_REQ r = (from u in _datasistema.ContextoInventario.INV_DETA_REQ
                                                      where u.ID == item.ID_DETA_REQ
                                                      select u).First();
                                    d.FLG_DESP = 'S';
                                    r.NM_CANT_DESP = r.NM_CANT_DESP + item.NM_CANTIDAD;
                                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                                    _datasistema.ContextoInventario.SubmitChanges();
                                }
                                else
                                {
                                    throw new Exception(msj);
                                }

                            }
                        }

                        if ((from u in _datasistema.ContextoInventario.INV_DETA_DESP
                             where u.ID_DESP == p.ID && u.FLG_DESP != 'S'
                             select u).Count() > 0)
                        {
                            throw new Exception("Despacho parcial: Hay productos que no se despacharon, reintentar");
                        }
                        p.CD_ESTA_DOCUMENTO = 'A';
                        _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                        _datasistema.ContextoInventario.SubmitChanges();
                        _datasistema.ContextoInventario.PR_CONT_GENE_CONT_DESP(p.ID, ref error, ref msj);
                        if (error != 0)
                        {
                            throw new Exception(msj);
                        }

                }
            return p;
        }

    }
}
