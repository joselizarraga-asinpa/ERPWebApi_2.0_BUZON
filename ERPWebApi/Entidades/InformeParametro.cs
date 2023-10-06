using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class InformeParametro: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idtipoparametro;
		private string Nombreinformeparametro;
		private string Entidad;
		private string Campocodigo;
		private string Campodesc;
		private bool Codigotodos;
		private bool Desctodos;
		private bool Combo;
		private string Valordefault;
		
		
		//Constructor
		public InformeParametro()
		{
			Id = 0; 
			Idtipoparametro = 0; 
			Nombreinformeparametro = ""; 
			Entidad = ""; 
			Campocodigo = ""; 
			Campodesc = ""; 
			Codigotodos = false; 
			Desctodos = false; 
			Combo = false; 
			Valordefault = ""; 
			
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
		public Int16 IDTIPOPARAMETRO
		{
			get{ return Idtipoparametro; }
			set
			{
				if(value!=Idtipoparametro)
				{
					
					Idtipoparametro = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREINFORMEPARAMETRO
		{
			get{ return Nombreinformeparametro.ToString().Trim(); }
			set
			{
				if(value!=Nombreinformeparametro)
				{
					
					Nombreinformeparametro = value;
				}
			}
		}
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
		public string CAMPOCODIGO
		{
			get{ return Campocodigo.ToString().Trim(); }
			set
			{
				if(value!=Campocodigo)
				{
					
					Campocodigo = value;
				}
			}
		}
		public string CAMPODESC
		{
			get{ return Campodesc.ToString().Trim(); }
			set
			{
				if(value!=Campodesc)
				{
					
					Campodesc = value;
				}
			}
		}
		public bool CODIGOTODOS
		{
			get{ return Codigotodos; }
			set
			{
				if(value!=Codigotodos)
				{
					
					Codigotodos = value;
				}
			}
		}
		public bool DESCTODOS
		{
			get{ return Desctodos; }
			set
			{
				if(value!=Desctodos)
				{
					
					Desctodos = value;
				}
			}
		}
		public bool COMBO
		{
			get{ return Combo; }
			set
			{
				if(value!=Combo)
				{
					
					Combo = value;
				}
			}
		}
		public string VALORDEFAULT
		{
			get{ return Valordefault.ToString().Trim(); }
			set
			{
				if(value!=Valordefault)
				{
					
					Valordefault = value;
				}
			}
		}
	}
}
