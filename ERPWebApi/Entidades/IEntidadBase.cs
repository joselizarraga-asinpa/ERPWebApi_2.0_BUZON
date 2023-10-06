using System;
//using System.Xml.Serialization;


namespace ERPWebApi.Entidades
{
	/// <summary>
	/// clase base para todas las entidades para manejar los estatus y 
    /// el registro de la bitacora de movimientos
	/// </summary>	
	//[Serializable]
	public abstract class IEntidadBase
	{
		private bool hasError;
		private string error;
        private string masterDetailKey;
        private Enumeradores.TypeAction transactionDetailType;		
		protected Enumeradores.Estatus estatusEntidad;

		protected IEntidadBase()
		{
			estatusEntidad= Enumeradores.Estatus.Agregado;
            masterDetailKey = "";
            transactionDetailType = Enumeradores.TypeAction.Detail;
        }
		
		public bool HasError
		{
			get{return hasError;}
			set{hasError=value;}
		}

		public string Error
		{
			get{return error;}
			set{error=value;}
		}

        public string MasterDetailKey
        {
            get { return masterDetailKey; }
            set { masterDetailKey = value; }
        }

        public Enumeradores.TypeAction TransactionDetailType
        {
            get { return transactionDetailType; }
            set { transactionDetailType = value; }
        }

        public void AcceptChanges()
		{
			estatusEntidad  = Enumeradores.Estatus.SinCambios ;			
		}

        public bool HasChanges()
		{
			if (estatusEntidad  == Enumeradores.Estatus.Agregado || estatusEntidad  == Enumeradores.Estatus.Modificado)
			{return true;}
			else
			{return false;}
		}
		
		//public void Set()
		//{
		//	//if (estatusEntidad != Entidades.Estatus.Agregado )
		//	//{
		//	//	estatusEntidad  = Entidades.Estatus.Modificado; 
		//	//}
		//}		
	}
}