using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ClasDet: IEntidadBase
	{
		private Int64 Id;
		private Int32 Idclas;
		private Int64 Idref;
		private Int16 Idfuncionalidad;        
        private Int16 Idaplicacion;
        private Int16 Idempresa;
        private decimal Importe;
		private DateTime Fecha;
		private string Texto;
        private string NombreClasificacion;
        private string Codigo;
        private string Abreviatura;


        //Constructor
        public ClasDet()
		{
            MasterDetailKey = "@IDREF";

			Id = 0; 
			Idclas = 0; 
			Idref = 0; 
			Idfuncionalidad = 0; 
			Idaplicacion = 0;
            Idempresa = 0;
            Importe = 0; 
			Fecha = DateTime.Parse("01/01/2000");
			Texto = "";
            NombreClasificacion = "";
            Codigo = "";
            Abreviatura = "";

        }
		
		public Int64 ID
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
		public Int64 IDREF
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
		public Int16 IDAPLICACION
		{
			get{ return Idaplicacion; }
			set
			{
				if(value!=Idaplicacion)
				{
					
					Idaplicacion = value;
				}
			}
		}
        public Int16 IDEMPRESA
        {
            get { return Idempresa; }
            set
            {
                if (value != Idempresa)
                {

                    Idempresa = value;
                }
            }
        }
        public decimal IMPORTE
		{
			get{ return Importe; }
			set
			{
				if(value!=Importe)
				{
					
					Importe = value;
				}
			}
		}
		public DateTime FECHA
		{
			get{ return Fecha; }
			set
			{
				if (value != null)
				{
					if(value!=Fecha)
					{
						
						Fecha = value;
					}
				}
			}
		}
		public string TEXTO
		{
			get{ return Texto.ToString().Trim(); }
			set
			{
				if(value!=Texto)
				{
					
					Texto = value;
				}
			}
		}
        public string NOMBRECLASIFICACION
        {
            get { return NombreClasificacion.ToString().Trim(); }
            set
            {
                if (value != NombreClasificacion)
                {
                    
                    NombreClasificacion = value;
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
        public string ABREVIATURA
        {
            get { return Abreviatura.ToString().Trim(); }
            set
            {
                if (value != Abreviatura)
                {

                    Abreviatura = value;
                }
            }
        }
    }
}
