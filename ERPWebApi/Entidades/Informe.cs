using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Informe: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idpincliente;
		private Int16 Idempresa;
		private Int16 Idsucursal;
		private Int16 Idtipoinforme;
		private Int16 Idmodulo;
		private Int16 Idtipodoc;
		private Int16 Idfuncionalidad;
		private Int64 Idarchivo;
		private string Nombreinforme;
		private string Formato;
		private string Entidad;
		private bool Ejecutarinicio;
		
		
		//Constructor
		public Informe()
		{
			Id = 0; 
			Idpincliente = 0; 
			Idempresa = 0; 
			Idsucursal = 0; 
			Idtipoinforme = 0; 
			Idmodulo = 0; 
			Idtipodoc = 0; 
			Idfuncionalidad = 0; 
			Idarchivo = 0; 
			Nombreinforme = ""; 
			Formato = ""; 
			Entidad = ""; 
			Ejecutarinicio = false; 
			
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
		public Int16 IDPINCLIENTE
		{
			get{ return Idpincliente; }
			set
			{
				if(value!=Idpincliente)
				{
					
					Idpincliente = value;
				}
			}
		}
		public Int16 IDEMPRESA
		{
			get{ return Idempresa; }
			set
			{
				if(value!=Idempresa)
				{
					
					Idempresa = value;
				}
			}
		}
		public Int16 IDSUCURSAL
		{
			get{ return Idsucursal; }
			set
			{
				if(value!=Idsucursal)
				{
					
					Idsucursal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDTIPOINFORME
		{
			get{ return Idtipoinforme; }
			set
			{
				if(value!=Idtipoinforme)
				{
					
					Idtipoinforme = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDMODULO
		{
			get{ return Idmodulo; }
			set
			{
				if(value!=Idmodulo)
				{
					
					Idmodulo = value;
				}
			}
		}
		public Int16 IDTIPODOC
		{
			get{ return Idtipodoc; }
			set
			{
				if(value!=Idtipodoc)
				{
					
					Idtipodoc = value;
				}
			}
		}
		public Int16 IDFUNCIONALIDAD
		{
			get{ return Idfuncionalidad; }
			set
			{
				if(value!=Idfuncionalidad)
				{
					
					Idfuncionalidad = value;
				}
			}
		}
		public Int64 IDARCHIVO
		{
			get{ return Idarchivo; }
			set
			{
				if(value!=Idarchivo)
				{
					
					Idarchivo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREINFORME
		{
			get{ return Nombreinforme.ToString().Trim(); }
			set
			{
				if(value!=Nombreinforme)
				{
					
					Nombreinforme = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string FORMATO
		{
			get{ return Formato.ToString().Trim(); }
			set
			{
				if(value!=Formato)
				{
					
					Formato = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string ENTIDAD
		{
			get{ return Entidad.ToString().Trim(); }
			set
			{
				if(value!=Entidad)
				{
					
					Entidad = value;
				}
			}
		}
		public bool EJECUTARINICIO
		{
			get{ return Ejecutarinicio; }
			set
			{
				if(value!=Ejecutarinicio)
				{
					
					Ejecutarinicio = value;
				}
			}
		}
	}
}
