using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocFiscalComplemento: IEntidadBase
	{
		private Int32 Id;
		private Int32 Iddocfiscalcomppadre;
		private Int16 Idtipodato;
        private long IdDocFiscal;
		private string Nombredocfiscalcomp;
		private string Codigo;
		private bool Nodo;
		private string Datofijo;
		private bool Obligatorio;
		private Int16 Orden;
        private bool Componentes;
        private string Valor;
		
		
		//Constructor
		public DocFiscalComplemento()
		{
			Id = 0; 
			Iddocfiscalcomppadre = 0;
            IdDocFiscal = 0;
            Idtipodato = 0; 
			Nombredocfiscalcomp = ""; 
			Codigo = ""; 
			Nodo = false; 
			Datofijo = ""; 
			Obligatorio = false; 
			Orden = 0;
            Componentes = false;
            Valor = "";

        }
		
		public Int32 ID
		{
			get{ return Id; }
			set
			{
				if(value!=Id)
				{
					Id = value;
				}
			}
		}
		public Int32 IDDOCFISCALCOMPPADRE
		{
			get{ return Iddocfiscalcomppadre; }
			set
			{
				if(value!=Iddocfiscalcomppadre)
				{
					Iddocfiscalcomppadre = value;
				}
			}
		}
        public long IDDOCFISCAL
        {
            get { return IdDocFiscal; }
            set
            {
                if (value != IdDocFiscal)
                {
                    IdDocFiscal = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public Int16 IDTIPODATO
		{
			get{ return Idtipodato; }
			set
			{
				if(value!=Idtipodato)
				{
					Idtipodato = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREDOCFISCALCOMP
		{
			get{ return Nombredocfiscalcomp.ToString().Trim(); }
			set
			{
				if(value!=Nombredocfiscalcomp)
				{
					Nombredocfiscalcomp = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CODIGO
		{
			get{ return Codigo.ToString().Trim(); }
			set
			{
				if(value!=Codigo)
				{
					Codigo = value;
				}
			}
		}
		public bool NODO
		{
			get{ return Nodo; }
			set
			{
				if(value!=Nodo)
				{
					Nodo = value;
				}
			}
		}
		public string DATOFIJO
		{
			get{ return Datofijo.ToString().Trim(); }
			set
			{
				if(value!=Datofijo)
				{
					Datofijo = value;
				}
			}
		}
		public bool OBLIGATORIO
		{
			get{ return Obligatorio; }
			set
			{
				if(value!=Obligatorio)
				{
					Obligatorio = value;
				}
			}
		}
		public Int16 ORDEN
		{
			get{ return Orden; }
			set
			{
				if(value!=Orden)
				{
					Orden = value;
				}
			}
		}
        public bool COMPONENTES
        {
            get { return Componentes; }
            set
            {
                if (value != Componentes)
                {
                    Componentes = value;
                }
            }
        }
        public string VALOR
        {
            get { return Valor.ToString().Trim(); }
            set
            {
                if (value != Valor)
                {
                    Valor = value;
                }
            }
        }
    }
}
