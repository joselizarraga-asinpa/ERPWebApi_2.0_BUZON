using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepCfdiComplemento: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Complemento;
		private string Valor;
		private Int16 Registro;
		
		
		//Constructor
		public RepCfdiComplemento()
		{
			Iddocfiscal = 0;
            Complemento = ""; 
			Valor = ""; 
			Registro = 0; 
			
		}
		
		public Int64 IDDOCFISCAL
		{
			get{ return Iddocfiscal; }
			set
			{
				if(value!=Iddocfiscal)
				{
					Iddocfiscal = value;
				}
			}
		}
		public string COMPLEMENTO
        {
			get{ return Complemento.ToString().Trim(); }
			set
			{
				if(value!= Complemento)
				{
                    Complemento = value;
				}
			}
		}
		public string VALOR
		{
			get{ return Valor.ToString().Trim(); }
			set
			{
				if(value!=Valor)
				{
					Valor = value;
				}
			}
		}
		public Int16 REGISTRO
		{
			get{ return Registro; }
			set
			{
				if(value!=Registro)
				{
					Registro = value;
				}
			}
		}
	}
}
