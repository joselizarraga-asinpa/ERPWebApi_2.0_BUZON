using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Email: IEntidadBase
	{
		private Int64 Id;
		private Int64 Iddatosgenerales;
		private Int64 Iddomicilio;
		private string Tipoemail;
		private string Direccionemail;
        private bool Fiscal;
        private bool Entrega;
		
		
		//Constructor
		public Email()
		{
			Id = 0; 
			Iddatosgenerales = 0; 
			Iddomicilio = 0; 
			Tipoemail = ""; 
			Direccionemail = "";
            Fiscal = false;
            Entrega = false;
			
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
		public Int64 IDDATOSGENERALES
		{
			get{ return Iddatosgenerales; }
			set
			{
				if(value!=Iddatosgenerales)
				{
					
					Iddatosgenerales = value;
				}
			}
		}
		public Int64 IDDOMICILIO
		{
			get{ return Iddomicilio; }
			set
			{
				if(value!=Iddomicilio)
				{
					
					Iddomicilio = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPOEMAIL
		{
			get{ return Tipoemail.ToString().Trim(); }
			set
			{
				if(value!=Tipoemail)
				{
					
					Tipoemail = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string DIRECCIONEMAIL
		{
			get{ return Direccionemail.ToString().Trim(); }
			set
			{
				if(value!=Direccionemail)
				{
					
					Direccionemail = value;
				}
			}
		}
        public bool FISCAL
        {
            get { return Fiscal; }
            set
            {
                if (value != Fiscal)
                {
                    Fiscal = value;
                }
            }
        }
        public bool ENTREGA
        {
            get { return Entrega; }
            set
            {
                if (value != Entrega)
                {
                    Entrega = value;
                }
            }
        }
    }
}
