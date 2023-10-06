using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Entidades
{
    public class Entidad
    {
        public string TypeName { get; private set; }
        public object[] include { get; private set; }
        public string MasterDetailKey { get; private set; }
        public Enumeradores.TypeAction TransactionDetailType { get; private set; }
        public List<Entidad> lEntidad { get; private set; }
        public bool ParamValueFirstParent { get; private set; }

        public Entidad(string _TypeName
                            ,object[] _include
                            ,string _MasterDetailKey
                            ,Enumeradores.TypeAction _TransactionDetailType
                            ,bool _ParamValueFirstParent = true
                            )
        {
            this.TypeName = _TypeName;
            this.include = _include;
            this.MasterDetailKey = _MasterDetailKey;
            this.TransactionDetailType = _TransactionDetailType;
            this.lEntidad = new List<Entidad>();
            this.ParamValueFirstParent = _ParamValueFirstParent;
        }

        Entidad()
        {
            MasterDetailKey = "";
        }        
    }
}
