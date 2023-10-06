using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

    //Clase creada por generador de código

    public class CfdiCancel : IEntidadBase
    {
        private Int64 Iddocfiscal;

        //Constructor
        public CfdiCancel()
        {
            Iddocfiscal = 0;

        }

        [DataMember(IsRequired = true)]
        public Int64 IDDOCFISCAL
        {
            get { return Iddocfiscal; }
            set
            {
                if (value != Iddocfiscal)
                {
                    Iddocfiscal = value;
                }
            }
        }

    }
}
