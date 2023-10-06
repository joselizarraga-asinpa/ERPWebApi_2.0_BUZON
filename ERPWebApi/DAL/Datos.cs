using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.DAL
{
    public static class Datos
    {
        //ESPECIFICAR LA BASE DE DATOS A USAR
        public static ERPWebApi.DAL.CallBase Call = new SqlServer.Call();
        public static Int16 idPinCliente = 1;

        public static IEnumerable<Dictionary<string, object>> StoredProc(Procedimiento proc, string conexion = "")
        {
            return Call.StoredProc(proc, conexion);
        }

        public static IEnumerable<Dictionary<string, object>> Funcion(object element, string funcion, string conexion = "")
        {
            return Call.Funcion(element, funcion, conexion);
        }

        public static List<T> Consultar<T>(object element, bool parametrosSp, string conexion = "") where T : new()
        {
            return Call.Consultar<T>(element, parametrosSp, conexion);
        }

        public static List<T> Buscar<T>(object element, bool parametrosSp, string conexion = "") where T : new()
        {
            return Call.Buscar<T>(element, parametrosSp, conexion);
        }

        public static List<T> Consultar<T>(object element, object[] include, string conexion = "") where T : new()
        {
            return Call.Consultar<T>(element, include, conexion);
        }

        public static List<T> Buscar<T>(object element, object[] include, string conexion = "") where T : new()
        {
            return Call.Buscar<T>(element, include, conexion);
        }

        public static string Nuevo<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.Nuevo<T>(element, include, action, conexion);
        }
        
        public static string NuevoTrans<T>(object element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.NuevoTrans<T>(element, lent, action, conexion);
        }

        public static string NuevoTrans<T>(List<object> element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.NuevoTrans<T>(element, lent, action, conexion);
        }

        public static string Actualizar<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.Actualizar<T>(element, include, action, conexion);
        }

        public static string ActualizarTrans<T>(object element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.ActualizarTrans<T>(element, lent, action, conexion);
        }

        public static string ActualizarInsertarTrans<T>(object element, List<Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.ActualizarInsertarTrans<T>(element, lent, action, conexion);
        }

        public static string Copiar<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion = "") where T : new()
        {
            return Call.Copiar<T>(element, include, action, conexion);
        }

        public static string Eliminar<T>(object element, string conexion = "") where T : new()
        {
            return Call.Eliminar<T>(element, conexion);
        }
        
    }
}
