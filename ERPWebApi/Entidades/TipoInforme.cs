using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoInforme: IEntidadBase
	{
		private Int16 Id;
		private string Nombretipoinforme;
		private bool Esreporte;
		private bool Establadinamica;
		private bool Esgrafica;
		private bool Esconsulta;
		private bool Esarchivoword;
		
		
		//Constructor
		public TipoInforme()
		{
			Id = 0; 
			Nombretipoinforme = ""; 
			Esreporte = false; 
			Establadinamica = false; 
			Esgrafica = false; 
			Esconsulta = false; 
			Esarchivoword = false; 
			
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
		public string NOMBRETIPOINFORME
		{
			get{ return Nombretipoinforme.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoinforme)
				{
					
					Nombretipoinforme = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool ESREPORTE
		{
			get{ return Esreporte; }
			set
			{
				if(value!=Esreporte)
				{
					
					Esreporte = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool ESTABLADINAMICA
		{
			get{ return Establadinamica; }
			set
			{
				if(value!=Establadinamica)
				{
					
					Establadinamica = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool ESGRAFICA
		{
			get{ return Esgrafica; }
			set
			{
				if(value!=Esgrafica)
				{
					
					Esgrafica = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool ESCONSULTA
		{
			get{ return Esconsulta; }
			set
			{
				if(value!=Esconsulta)
				{
					
					Esconsulta = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool ESARCHIVOWORD
		{
			get{ return Esarchivoword; }
			set
			{
				if(value!=Esarchivoword)
				{
					
					Esarchivoword = value;
				}
			}
		}
	}
}
