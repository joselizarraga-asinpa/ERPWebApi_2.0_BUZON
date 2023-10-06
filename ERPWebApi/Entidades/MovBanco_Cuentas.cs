using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovBanco_Cuentas: IEntidadBase
	{
		private Int32 Idfuncionalidad;
		private Int32 Idref;
        private string Codigo;
		private string Nombre;
		
		
		//Constructor
		public MovBanco_Cuentas()
		{
			Idfuncionalidad = 0; 
			Idref = 0;
            Codigo = "";
            Nombre = ""; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int32 IDFUNCIONALIDAD
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
		[DataMember(IsRequired = true)]
		public Int32 IDREF
		{
			get{ return Idref; }
			set
			{
				if(value!=Idref)
				{
					Idref = value;
				}
			}
		}
        public string CODIGO
        {
            get { return Codigo.ToString().Trim(); }
            set
            {
                if (value != Codigo)
                {
                    Codigo = value;
                }
            }
        }
        public string NOMBRE
		{
			get{ return Nombre.ToString().Trim(); }
			set
			{
				if(value!=Nombre)
				{
					Nombre = value;
				}
			}
		}
	}
}
