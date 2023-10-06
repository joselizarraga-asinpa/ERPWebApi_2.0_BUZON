using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class LayoutDet: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idlayout;
		private Int16 Idtipodato;
		private Int32 Idclas;
		private string Columna;
		private string Dato;
        private string Alias;


        //Constructor
        public LayoutDet()
		{
			Id = 0; 
			Idlayout = 0; 
			Idtipodato = 0; 
			Idclas = 0; 
			Columna = ""; 
			Dato = "";
            Alias = "";
			
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
		public Int16 IDLAYOUT
		{
			get{ return Idlayout; }
			set
			{
				if(value!=Idlayout)
				{
					
					Idlayout = value;
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
		public Int32 IDCLAS
		{
			get{ return Idclas; }
			set
			{
				if(value!=Idclas)
				{
					
					Idclas = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string COLUMNA
		{
			get{ return Columna.ToString().Trim(); }
			set
			{
				if(value!=Columna)
				{
					
					Columna = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string DATO
		{
			get{ return Dato.ToString().Trim(); }
			set
			{
				if(value!=Dato)
				{
					
					Dato = value;
				}
			}
		}
        public string ALIAS
        {
            get { return Alias.ToString().Trim(); }
            set
            {
                if (value != Alias)
                {
                    
                    Alias = value;
                }
            }
        }
    }
}
