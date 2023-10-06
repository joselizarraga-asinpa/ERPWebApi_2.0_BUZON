using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIStatus: IEntidadBase
	{
		private Int16 Status;
		private Int64 Iddocfiscal;
		
		
		//Constructor
		public CFDIStatus()
		{
			Status = 0; 
			Iddocfiscal = 0; 
			
		}
		
		public Int16 STATUS
		{
			get{ return Status; }
			set
			{
				if(value!=Status)
				{
					Status = value;
				}
			}
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
	}
}
