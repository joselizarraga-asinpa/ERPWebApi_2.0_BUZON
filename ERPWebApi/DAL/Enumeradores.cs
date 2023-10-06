namespace Enumeradores
{

  public enum TipoFuncion
  {
      Select,
      Insert,
      Delete,
      Update,
      UpdateInsert,
      Buscar,    
      Copiar,  
      Otro,
      Ninguno
  }

  public enum TipoBaseDatos
  {
      SQLServer,
      SQLCompact,
      SQLite,
      Postgres
  }

  public enum TypeAction
  {
      None,
      Detail,
      DetailRef,
      Main
  }
    
    public enum SucursalConfigValores
    {
        TimbradoSW_user,
        TimbradoSW_pwd,
        TimbradoRFC
    }

    public enum LogAction
    {
        Cancelar = 0,
        Timbrar = 1,
        Status = 2,
        SolicitudesPendientes = 3,
        AceptarRechazar = 4,
        SaldoTimbres = 5,
        ValidaRFC = 6,
        ValidaXML = 7
    }


    public enum TipoDato
    {
        Texto,
        Numero,
        Fecha,
        Booleano
    }

    public enum Estatus
    {
        Borrado,
        Agregado,
        Modificado,
        SinCambios
    }

    public enum TipoTimbrado
    {
        Factura = 1,
        Nota = 2,
        Traslado = 4,
        Nota_de_Cargo = 201,
        Nota_de_Credito = 202,
        Pago_Parcial = 204,
        Recibo_de_Pagos = 205,
    }

    public enum CFDIStatus
    {
        Vigente = 0,
        En_proceso = 1,
        Cancelado = 2,
        NoEncontrado = 3,
        ExpresionNoValida = 4,
        No_Especificado = 5
    }

    public enum CFDICancelable
    {
        no_cancelable = 0,
        cancelable_sin_aceptación = 1,
        cancelable_con_aceptación = 2,
        ExpresionNoValida = 3,
        No_Especificado = 4
    }
        public enum CFDIAceptarRechazar
    {
        Aceptacion,
        Rechazo
    }
}