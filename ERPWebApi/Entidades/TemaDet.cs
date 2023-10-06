using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TemaDet: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idtema;
		private Int16 Idtemacomponente;
		private Int16 Colorrfondo;
		private Int16 Colorgfondo;
		private Int16 Colorbfondo;
		private Int16 Colorrfuente;
		private Int16 Colorgfuente;
		private Int16 Colorbfuente;
		private Int16 Colorralterno;
		private Int16 Colorgalterno;
		private string Colorbalterno;
		
		
		//Constructor
		public TemaDet()
		{
			Id = 0; 
			Idtema = 0; 
			Idtemacomponente = 0; 
			Colorrfondo = 0; 
			Colorgfondo = 0; 
			Colorbfondo = 0; 
			Colorrfuente = 0; 
			Colorgfuente = 0; 
			Colorbfuente = 0; 
			Colorralterno = 0; 
			Colorgalterno = 0; 
			Colorbalterno = ""; 
			
		}
		
		public Int16 ID
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
		public Int16 IDTEMA
		{
			get{ return Idtema; }
			set
			{
				if(value!=Idtema)
				{
					
					Idtema = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDTEMACOMPONENTE
		{
			get{ return Idtemacomponente; }
			set
			{
				if(value!=Idtemacomponente)
				{
					
					Idtemacomponente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 COLORRFONDO
		{
			get{ return Colorrfondo; }
			set
			{
				if(value!=Colorrfondo)
				{
					
					Colorrfondo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 COLORGFONDO
		{
			get{ return Colorgfondo; }
			set
			{
				if(value!=Colorgfondo)
				{
					
					Colorgfondo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 COLORBFONDO
		{
			get{ return Colorbfondo; }
			set
			{
				if(value!=Colorbfondo)
				{
					
					Colorbfondo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 COLORRFUENTE
		{
			get{ return Colorrfuente; }
			set
			{
				if(value!=Colorrfuente)
				{
					
					Colorrfuente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 COLORGFUENTE
		{
			get{ return Colorgfuente; }
			set
			{
				if(value!=Colorgfuente)
				{
					
					Colorgfuente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 COLORBFUENTE
		{
			get{ return Colorbfuente; }
			set
			{
				if(value!=Colorbfuente)
				{
					
					Colorbfuente = value;
				}
			}
		}
		public Int16 COLORRALTERNO
		{
			get{ return Colorralterno; }
			set
			{
				if(value!=Colorralterno)
				{
					
					Colorralterno = value;
				}
			}
		}
		public Int16 COLORGALTERNO
		{
			get{ return Colorgalterno; }
			set
			{
				if(value!=Colorgalterno)
				{
					
					Colorgalterno = value;
				}
			}
		}
		public string COLORBALTERNO
		{
			get{ return Colorbalterno.ToString().Trim(); }
			set
			{
				if(value!=Colorbalterno)
				{
					
					Colorbalterno = value;
				}
			}
		}
	}
}
