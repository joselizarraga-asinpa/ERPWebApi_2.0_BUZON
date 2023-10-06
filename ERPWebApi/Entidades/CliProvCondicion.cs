using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CliProvCondicion: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idcliprov;
		private Int16 Idtipodocumento;
		private Int16 Idtipoproducto;
		private Int32 Idclasproducto;
		private Int32 Idproducto;
        private string NombreTipoDocumento;
        private string NombreTipoProducto;
        private string NombreClasProducto;
        private string NombreProducto;
        private string Nombrecondicion;
		private bool Copiardoc;
		private DateTime Fecharecordatorio;
		
		
		//Constructor
		public CliProvCondicion()
		{
			Id = 0; 
			Idcliprov = 0; 
			Idtipodocumento = 0; 
			Idtipoproducto = 0; 
			Idclasproducto = 0; 
			Idproducto = 0;
            NombreTipoDocumento = "";
            NombreTipoProducto = "";
            NombreClasProducto = "";
            NombreProducto = "";
            Nombrecondicion = ""; 
			Copiardoc = false; 
			Fecharecordatorio = System.DateTime.Today;
			
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
		[DataMember(IsRequired = true)]
		public Int32 IDCLIPROV
		{
			get{ return Idcliprov; }
			set
			{
				if(value!=Idcliprov)
				{
					Idcliprov = value;
				}
			}
		}
		public Int16 IDTIPODOCUMENTO
		{
			get{ return Idtipodocumento; }
			set
			{
				if(value!=Idtipodocumento)
				{
					Idtipodocumento = value;
				}
			}
		}
		public Int16 IDTIPOPRODUCTO
		{
			get{ return Idtipoproducto; }
			set
			{
				if(value!=Idtipoproducto)
				{
					Idtipoproducto = value;
				}
			}
		}
		public Int32 IDCLASPRODUCTO
		{
			get{ return Idclasproducto; }
			set
			{
				if(value!=Idclasproducto)
				{
					Idclasproducto = value;
				}
			}
		}
		public Int32 IDPRODUCTO
		{
			get{ return Idproducto; }
			set
			{
				if(value!=Idproducto)
				{
					Idproducto = value;
				}
			}
		}
        public string NOMBRETIPODOCUMENTO
        {
            get { return NombreTipoDocumento.ToString().Trim(); }
            set
            {
                if (value != NombreTipoDocumento)
                {
                    NombreTipoDocumento = value;
                }
            }
        }
        public string NOMBRETIPOPRODUCTO
        {
            get { return NombreTipoProducto.ToString().Trim(); }
            set
            {
                if (value != NombreTipoProducto)
                {
                    NombreTipoProducto = value;
                }
            }
        }
        public string NOMBRECLASPRODUCTO
        {
            get { return NombreClasProducto.ToString().Trim(); }
            set
            {
                if (value != NombreClasProducto)
                {
                    NombreClasProducto = value;
                }
            }
        }
        public string NOMBREPRODUCTO
        {
            get { return NombreProducto.ToString().Trim(); }
            set
            {
                if (value != NombreProducto)
                {
                    NombreProducto = value;
                }
            }
        }
        public string NOMBRECONDICION
		{
			get{ return Nombrecondicion.ToString().Trim(); }
			set
			{
				if(value!=Nombrecondicion)
				{
					Nombrecondicion = value;
				}
			}
		}
		public bool COPIARDOC
		{
			get{ return Copiardoc; }
			set
			{
				if(value!=Copiardoc)
				{
					Copiardoc = value;
				}
			}
		}
		public DateTime FECHARECORDATORIO
		{
			get{ return Fecharecordatorio; }
			set
			{
				if (value != null)
				{
					if(value!=Fecharecordatorio)
					{
						Fecharecordatorio = value;
					}
				}
			}
		}
	}
}
