using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoAplicacionCategoria: IEntidadBase
	{
		private Int16 Id;
        private Int16 Idtipoaplicacion;
        private Int16 Idtipoaplicacioncampo;
		private string Categoria;
		private string Color;
		
		
		//Constructor
		public TipoAplicacionCategoria()
		{
			Id = 0;
            Idtipoaplicacion = 0;
            Idtipoaplicacioncampo = 0; 
			Categoria = ""; 
			Color = ""; 			
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

        public Int16 IDTIPOAPLICACION
        {
            get { return Idtipoaplicacion; }
            set
            {
                if (value != Idtipoaplicacion)
                {
                    Idtipoaplicacion = value;
                }
            }
        }

        [DataMember(IsRequired = true)]
		public Int16 IDTIPOAPLICACIONCAMPO
		{
			get{ return Idtipoaplicacioncampo; }
			set
			{
				if(value!=Idtipoaplicacioncampo)
				{
					Idtipoaplicacioncampo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CATEGORIA
		{
			get{ return Categoria.ToString().Trim(); }
			set
			{
				if(value!=Categoria)
				{
					Categoria = value;
				}
			}
		}
		public string COLOR
		{
			get{ return Color.ToString().Trim(); }
			set
			{
				if(value!=Color)
				{
					Color = value;
				}
			}
		}
	}
}
