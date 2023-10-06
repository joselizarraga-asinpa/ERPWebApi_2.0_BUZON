using System;
using System.Collections.Generic;

namespace ERPWebApi.DAL
{
    public class Procedimiento
    {
        public string NombreProcedimiento { get; set; }
        public List<Parameter> Parametros { get; set; }

        public Procedimiento()
        {
            NombreProcedimiento = "";
            Parametros = new List<Parameter>();
        }

        public Procedimiento(string nombreprocedimiento)
        {
            NombreProcedimiento = nombreprocedimiento;
            Parametros = new List<Parameter>();
        }

        public void AgregaParametro(string nombre, object valor)
        {
            Parametros.Add(new Parameter() { Nombre = nombre, Tipo = "", Longitud = "", Valor = valor });
        }

        public void AgregaParametro(string nombre, object valor, string tipo)
        {            
            Parametros.Add(new DAL.Parameter() { Nombre = nombre, Tipo = tipo, Longitud = "", Valor = valor });                       
        }

        public void LimpiaParametros()
        {
            Parametros.Clear();
        }
    }

    public class Parameter
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Longitud { get; set; }
        public object Valor { get; set; }

        public Parameter()
        {
            Nombre = "";
            Tipo = "";
            Longitud = "0";
            Valor = DBNull.Value;
        }        
    }
    

    public class CallBase
    {

        public virtual IEnumerable<Dictionary<string, object>> StoredProc(Procedimiento proc, string conexion = "")
        {
            IEnumerable<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            return result;
        }

        public virtual IEnumerable<Dictionary<string, object>> Funcion(object element, string Funcion, string conexion = "")
        {
            IEnumerable<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            return result;
        }

        public virtual List<T> Consultar<T>(object element, bool parametrosSp, string conexion = "") where T : new()
        {
            List<T> result = new List<T>();
            return result;
        }

        public virtual List<T> Buscar<T>(object element, bool parametrosSp, string conexion = "") where T : new()
        {
            List<T> result = new List<T>();
            return result;
        }

        public virtual List<T> Consultar<T>(object element, object[] include, string conexion = "") where T : new()
        {
            List<T> result = new List<T>();
            return result;
        }

        public virtual List<T> Buscar<T>(object element, object[] include, string conexion = "") where T : new()
        {
            List<T> result = new List<T>();
            return result;
        }

        public virtual string Nuevo<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {            
            return "Funcion Nuevo No Implementada";
        }

        public virtual string NuevoTrans<T>(object element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return "Funcion Nuevo No Implementada";
        }

        public virtual string Actualizar<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return "Funcion Actualizar No Implementada";
        }

        public virtual string ActualizarTrans<T>(object element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return "Funcion Actualizar No Implementada";
        }

        public virtual string ActualizarInsertarTrans<T>(object element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return "Funcion Actualizar No Implementada";
        }

        public virtual string Copiar<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return "Funcion Copiar No Implementada";
        }

        public virtual string Eliminar<T>(object element, string conexion = "") where T : new()
        {
            return "Funcion Eliminar No Implementada";
        }
    }
}
