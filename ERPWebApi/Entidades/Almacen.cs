using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Almacen: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idsucursal;
        private long IdDocumento;
		private string Nombrealmacen;
		private bool Ventas;
		private bool Apartados;
		private bool Recepciones;
        private bool Entradas;
        private bool Salidas;


        //Constructor
        public Almacen()
		{
			Id = 0; 
			Idsucursal = 0;
            IdDocumento = 0;
            Nombrealmacen = ""; 
			Ventas = false; 
			Apartados = false; 
			Recepciones = false;
            Entradas = false;
            Salidas = false;


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
        public long IDDOCUMENTO
        {
            get { return IdDocumento; }
            set
            {
                if (value != IdDocumento)
                {

                    IdDocumento = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public string NOMBREALMACEN
		{
			get{ return Nombrealmacen.ToString().Trim(); }
			set
			{
				if(value!=Nombrealmacen)
				{
					
					Nombrealmacen = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool VENTAS
		{
			get{ return Ventas; }
			set
			{
				if(value!=Ventas)
				{
					
					Ventas = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool APARTADOS
		{
			get{ return Apartados; }
			set
			{
				if(value!=Apartados)
				{
					
					Apartados = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool RECEPCIONES
		{
			get{ return Recepciones; }
			set
			{
				if(value!=Recepciones)
				{
					
					Recepciones = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public bool ENTRADAS
        {
            get { return Entradas; }
            set
            {
                if (value != Entradas)
                {
                    
                    Entradas = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public bool SALIDAS
        {
            get { return Salidas; }
            set
            {
                if (value != Salidas)
                {
                    
                    Salidas = value;
                }
            }
        }
    }
}
