using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso : BusinessEntity
    {
        private enum TipoCargos { };
        TipoCargos _Cargo;
        int _IDCurso;
        int _IDDocente;

        public TipoCargos Cargo { get { return _Cargo; } set { _Cargo = value; } }
        public int IDCurso { get { return _IDCurso; } set { _IDCurso = value; } }
        public int IDDocente { get { return _IDDocente; } set { _IDDocente = value; } }
    }
}
