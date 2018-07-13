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
    class ManejadorAjuste : Interfaz_logica<INV_ENCA_AJUS >
    {
         private DataSistema _datasistema;
         public ManejadorAjuste(DataSistema ds)
        {
            _datasistema = ds;
        }

         public List<INV_ENCA_AJUS> consultar()
         {
             _datasistema.conectarInventario();
             List<INV_ENCA_AJUS> l = new List<INV_ENCA_AJUS>();
             l = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS
                  select u).ToList();
             return l;
         }
         public List<INV_ENCA_AJUS> consultarPorIdEmpresa(int idEmpresa)
         {
             _datasistema.conectarInventario();
             List<INV_ENCA_AJUS> l = new List<INV_ENCA_AJUS>();
             l = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS
                  where u.ID_EMPRESA == idEmpresa
                  select u).ToList();
             return l;
         }
         public V_INV_ENCA_AJUS consultarVistaPorId(int id)
         {
             _datasistema.conectarInventario();
             V_INV_ENCA_AJUS l;
             l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_AJUS
                  where u.ID == id
                  select u).First();
             return l;
         }

         public List<V_INV_ENCA_AJUS> consultarVistaPorIdEmpresa(int idEmpresa)
         {
             _datasistema.conectarInventario();
             List<V_INV_ENCA_AJUS> l = new List<V_INV_ENCA_AJUS>();
             l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_AJUS
                  where u.ID_EMPRESA == idEmpresa
                  select u).ToList();
             return l;
         }
         public List<V_INV_ENCA_AJUS> consultarVistaPorIdEmpresaPeriodo(int idEmpresa, SIS_PERIODO periodo)
         {
             _datasistema.conectarInventario();
             List<V_INV_ENCA_AJUS> l = new List<V_INV_ENCA_AJUS>();
             l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_AJUS
                  where u.ID_EMPRESA == idEmpresa && u.NM_EJERCICIO == periodo.NM_EJERCICIO && u.NM_PERIODO == periodo.NM_PERIODO
                  select u).ToList();
             return l;
         }
         public INV_ENCA_AJUS insertar(INV_ENCA_AJUS data)
         {
             _datasistema.conectarInventario();
             INV_ENCA_AJUS s = data;
             _datasistema.ContextoInventario.INV_ENCA_AJUS.InsertOnSubmit(s);
             _datasistema.ContextoInventario.SubmitChanges();
             return s;
         }

         public INV_ENCA_AJUS modificar(INV_ENCA_AJUS data)
         {
             _datasistema.conectarInventario();
             INV_ENCA_AJUS s = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS
                                where u.ID == data.ID
                                select u).First();
             if (s.CD_ESTA_DOCUMENTO != 'D')
             {
                 throw new Exception("El ajuste ya esta actualizado");
             }
             s.DS_NOMBRE_PROCESADOR = data.DS_NOMBRE_PROCESADOR;
             s.DS_REFERENCIA = data.DS_REFERENCIA;

             _datasistema.ContextoInventario.SubmitChanges();
             return s;
         }

         public INV_ENCA_AJUS eliminar(INV_ENCA_AJUS data)
         {
             _datasistema.conectarInventario();
            INV_ENCA_AJUS s = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("El ajuste ya esta actualizado");
            }
            _datasistema.ContextoInventario.INV_ENCA_AJUS.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
         }
    }
}
