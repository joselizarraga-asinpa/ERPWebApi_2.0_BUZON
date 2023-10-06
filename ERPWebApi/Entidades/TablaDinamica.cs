using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TablaDinamica: IEntidadBase
	{
		private Int16 Id;
		private Int32 Idinforme;
		private Int16 Idtipografica;
		private string Nombretabladinamica;
		private bool Predeterminado;
		
		
		//Constructor
		public TablaDinamica()
		{
			Id = 0; 
			Idinforme = 0; 
			Idtipografica = 0; 
			Nombretabladinamica = ""; 
			Predeterminado = false; 
			
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
		public Int32 IDINFORME
		{
			get{ return Idinforme; }
			set
			{
				if(value!=Idinforme)
				{
					Idinforme = value;
				}
			}
		}
		public Int16 IDTIPOGRAFICA
		{
			get{ return Idtipografica; }
			set
			{
				if(value!=Idtipografica)
				{
					Idtipografica = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBRETABLADINAMICA
		{
			get{ return Nombretabladinamica.ToString().Trim(); }
			set
			{
				if(value!=Nombretabladinamica)
				{
					Nombretabladinamica = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool PREDETERMINADO
		{
			get{ return Predeterminado; }
			set
			{
				if(value!=Predeterminado)
				{
					Predeterminado = value;
				}
			}
		}
	}
}
