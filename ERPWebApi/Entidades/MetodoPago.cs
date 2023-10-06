using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MetodoPago: IEntidadBase
	{
		private Int16 Id;
		private string Nombremetodopago;
		private bool Dinerocaja;
		private bool Datobancario;
		private Int16 Orden;
		private string Clavesat;
        private Int16 BancoDefault;


        //Constructor
        public MetodoPago()
		{
			Id = 0; 
			Nombremetodopago = ""; 
			Dinerocaja = false; 
			Datobancario = false; 
			Orden = 0; 
			Clavesat = "";
            BancoDefault = 0;
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
		public string NOMBREMETODOPAGO
		{
			get{ return Nombremetodopago.ToString().Trim(); }
			set
			{
				if(value!=Nombremetodopago)
				{
					
					Nombremetodopago = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool DINEROCAJA
		{
			get{ return Dinerocaja; }
			set
			{
				if(value!=Dinerocaja)
				{
					
					Dinerocaja = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool DATOBANCARIO
		{
			get{ return Datobancario; }
			set
			{
				if(value!=Datobancario)
				{
					
					Datobancario = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ORDEN
		{
			get{ return Orden; }
			set
			{
				if(value!=Orden)
				{
					
					Orden = value;
				}
			}
		}
		public string CLAVESAT
		{
			get{ return Clavesat.ToString().Trim(); }
			set
			{
				if(value!=Clavesat)
				{
					
					Clavesat = value;
				}
			}
		}
        public Int16 BANCODEFAULT
        {
            get { return BancoDefault; }
            set
            {
                if (value != BancoDefault)
                {
                    BancoDefault = value;
                }
            }
        }
    }
}
