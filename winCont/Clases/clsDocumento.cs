using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCont.Clases
{
    class clsDocumento
    {
        private int _id;
        private String _serie;
        private int _numero;
        private String _referencia;
        private String _tercero;
        private int _idTercero;
        private String _solicitante;
        private int _idsolicitante;
        private Decimal _total;
        private DateTime _fecha;
        private int _idtipodocumento;
        private String _tipodocumento;
        private int? _idpart;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }

        public string Tercero
        {
            get { return _tercero; }
            set { _tercero = value; }
        }

        public int IdTercero
        {
            get { return _idTercero; }
            set { _idTercero = value; }
        }

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public string Solicitante
        {
            get { return _solicitante; }
            set { _solicitante = value; }
        }

        public int Idsolicitante
        {
            get { return _idsolicitante; }
            set { _idsolicitante = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int Idtipodocumento
        {
            get { return _idtipodocumento; }
            set { _idtipodocumento = value; }
        }

        public string Tipodocumento
        {
            get { return _tipodocumento; }
            set { _tipodocumento = value; }
        }

        public int? Idpart
        {
            get { return _idpart; }
            set { _idpart = value; }
        }

        public clsDocumento()
        {
        }
    }
}
