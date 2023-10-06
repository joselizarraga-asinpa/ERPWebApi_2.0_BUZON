using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Layout: IEntidadBase
	{
		private Int16 Id;
        private Int16 Idpincliente;
        private Int16 Idfuncionalidad;
		private Int16 Idaplicacion;
        private Int16 Idtipodocumento;
        private string Nombrelayout;
		private string Importaexporta;
        private bool Documentos;
		private string Llave1;
		private string Llave2;
		private string Archivo;
        private string TipoArchivo;
        private string Hoja;


        //Constructor
        public Layout()
		{
			Id = 0;
            Idpincliente = 0;
            Idfuncionalidad = 0; 
			Idaplicacion = 0;
            Idtipodocumento = 0;
            Nombrelayout = ""; 
			Importaexporta = "";
            Documentos = false;
            Llave1 = ""; 
			Llave2 = ""; 
			Archivo = "";
            TipoArchivo = "";
            Hoja = "";

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
        public Int16 IDPINCLIENTE
        {
            get { return Idpincliente; }
            set
            {
                if (value != Idpincliente)
                {
                    
                    Idpincliente = value;
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
        public Int16 IDTIPODOCUMENTO
        {
            get { return Idtipodocumento; }
            set
            {
                if (value != Idtipodocumento)
                {

                    Idtipodocumento = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public string NOMBRELAYOUT
		{
			get{ return Nombrelayout.ToString().Trim(); }
			set
			{
				if(value!=Nombrelayout)
				{
					
					Nombrelayout = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string IMPORTAEXPORTA
		{
			get{ return Importaexporta.ToString().Trim(); }
			set
			{
				if(value!=Importaexporta)
				{
					
					Importaexporta = value;
				}
			}
		}
        public bool DOCUMENTOS
        {
            get { return Documentos; }
            set
            {
                if (value != Documentos)
                {

                    Documentos = value;
                }
            }
        }
        public string LLAVE1
		{
			get{ return Llave1.ToString().Trim(); }
			set
			{
				if(value!=Llave1)
				{
					
					Llave1 = value;
				}
			}
		}
		public string LLAVE2
		{
			get{ return Llave2.ToString().Trim(); }
			set
			{
				if(value!=Llave2)
				{
					
					Llave2 = value;
				}
			}
		}
		public string ARCHIVO
		{
			get{ return Archivo.ToString().Trim(); }
			set
			{
				if(value!=Archivo)
				{
					
					Archivo = value;
				}
			}
		}
        public string TIPOARCHIVO
        {
            get { return TipoArchivo.ToString().Trim(); }
            set
            {
                if (value != TipoArchivo)
                {
                    
                    TipoArchivo = value;
                }
            }
        }
        public string HOJA
        {
            get { return Hoja.ToString().Trim(); }
            set
            {
                if (value != Hoja)
                {
                    
                    Hoja = value;
                }
            }
        }
    }
}
