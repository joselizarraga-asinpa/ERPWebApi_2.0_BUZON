using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
    public class CfdiComplemento
    {
        private Int64 Iddocfiscal;
        private string Xml;

        public CfdiComplemento()
        {
            Iddocfiscal = 0;
            Xml = "";
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

        public string XML
        {
            get { return Xml.ToString().Trim(); }
            set
            {
                if (value != Xml)
                {
                    Xml = value;
                }
            }
        }
        
    }
}
