using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Clasificacion: IEntidadBase
      {
        private Int32 Id;
        private Int32 Idclaspadre;
        private Int16 Idempresa;
        private Int16 Idfuncionalidad;
        private Int16 Idaplicacion;
        private Int16 Idtipounidad;
        private long IdRef;
        private string Nombreclasificacion;
        private string Abreviatura;
        private string Codigo;
        private string Ingreso;
        private bool Obligatorio;
        private bool Solicitaendoc;
        private bool Multiplesclas;
        private bool Incluirennombre;
        private bool ManejaCosto;
        private bool AsignaUnico;
        private bool Cerrado;
        private bool Hijos;
        private decimal Factor;
        private decimal Orden;
        private bool MostrarId;

        public Int16 LEVEL { get; set; }
        public string PATH { get; set; }
        public string PATHDesc { get; set; }
            

        //public Empresa Empresa { get; set;}
        //public Funcionalidad Funcionalidad { get; set;}
        //public TipoUnidad TipoUnidad { get; set;}
        //public List<Clasificacion> Clasificacion { get; set; }
        //public List<ProductoClas> ProductoClas { get; set; }

        //Constructor
        public Clasificacion()
        {
            Id = 0; 
            Idclaspadre = 0; 
            Idempresa = 0; 
            Idfuncionalidad = 0; 
            Idaplicacion = 0; 
            Idtipounidad = 0;
            IdRef = 0;
            Nombreclasificacion = ""; 
            Abreviatura = ""; 
            Codigo = "";
            Ingreso = "N";
            Obligatorio = false; 
            Solicitaendoc = false;
            Multiplesclas = false;
            Incluirennombre = false;
            ManejaCosto = false;
            AsignaUnico = false;
            Cerrado = false;
            Hijos = false;
            Factor = 0; 
            Orden = 0;
            MostrarId = true;


            LEVEL = 0;
            PATH = "";
            PATHDesc = "";
                

                //Empresa = new Empresa();
                //Funcionalidad = new Funcionalidad();
                //TipoUnidad = new TipoUnidad();
                //Clasificacion = new List<Clasificacion>(); 
                //ProductoClas = new List<ProductoClas>(); 
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
            public Int32 IDCLASPADRE
            {
                get{ return Idclaspadre; }
                set
                {
                    if(value!=Idclaspadre)
                    {
                        
                        Idclaspadre = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public Int16 IDEMPRESA
            {
                get{ return Idempresa; }
                set
                {
                    if(value!=Idempresa)
                    {
                        
                        Idempresa = value;
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
            public Int16 IDTIPOUNIDAD
            {
                get{ return Idtipounidad; }
                set
                {
                    if(value!=Idtipounidad)
                    {
                        
                        Idtipounidad = value;
                    }
                }
            }
            public long IDREF
            {
                get { return IdRef; }
                set
                {
                    if (value != IdRef)
                    {
                        
                        IdRef = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public string NOMBRECLASIFICACION
            {
                get{ return Nombreclasificacion.ToString().Trim(); }
                set
                {
                    if(value!=Nombreclasificacion)
                    {
                        
                        Nombreclasificacion = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public string ABREVIATURA
            {
                get{ return Abreviatura.ToString().Trim(); }
                set
                {
                    if(value!=Abreviatura)
                    {
                        
                        Abreviatura = value;
                    }
                }
            }
            public string CODIGO
            {
                get{ return Codigo.ToString().Trim(); }
                set
                {
                    if(value!=Codigo)
                    {
                        
                        Codigo = value;
                    }
                }
            }
            public string INGRESO
            {
                get { return Ingreso.ToString().Trim(); }
                set
                {
                    if (value != Ingreso)
                    {

                        Ingreso = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public bool OBLIGATORIO
            {
                get{ return Obligatorio; }
                set
                {
                    if(value!=Obligatorio)
                    {
                        
                        Obligatorio = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public bool SOLICITAENDOC
        {
                get{ return Solicitaendoc; }
                set
                {
                    if(value!= Solicitaendoc)
                    {
                        
                    Solicitaendoc = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public bool MULTIPLESCLAS
            {
                get { return Multiplesclas; }
                set
                {
                    if (value != Multiplesclas)
                    {
                        
                    Multiplesclas = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public bool INCLUIRENNOMBRE
            {
                get { return Incluirennombre; }
                set
                {
                    if (value != Incluirennombre)
                    {
                        
                        Incluirennombre = value;
                    }
                }
            }
        [DataMember(IsRequired = true)]
        public bool MANEJACOSTO
        {
            get { return ManejaCosto; }
            set
            {
                if (value != ManejaCosto)
                {
                    
                    ManejaCosto = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public bool ASIGNAUNICO
        {
            get { return AsignaUnico; }
            set
            {
                if (value != AsignaUnico)
                {
                    
                    AsignaUnico = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public bool CERRADO
        {
            get { return Cerrado; }
            set
            {
                if (value != Cerrado)
                {
                    
                    Cerrado = value;
                }
            }
        }
        public bool HIJOS
        {
            get { return Hijos; }
            set
            {
                if (value != Hijos)
                {

                    Hijos = value;
                }
            }
        }
        public decimal FACTOR
            {
                get{ return Factor; }
                set
                {
                    if(value!=Factor)
                    {
                        
                        Factor = value;
                    }
                }
            }
            [DataMember(IsRequired = true)]
            public decimal ORDEN
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
        [DataMember(IsRequired = true)]
        public bool MOSTRARID
        {
            get { return MostrarId; }
            set
            {
                if (value != MostrarId)
                {

                    MostrarId = value;
                }
            }
        }
    }
}
