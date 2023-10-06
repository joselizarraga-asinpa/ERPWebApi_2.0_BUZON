using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace SqlServer
{    
    public class Call: ERPWebApi.DAL.CallBase 
    {
      
        public override IEnumerable<Dictionary<string, object>> StoredProc(Procedimiento proc, string conexion)
        {            
            SqlCommand cmd = new SqlCommand();
            cmd = Base.LoadParametersSP(proc, conexion);           
            cmd.CommandText = proc.NombreProcedimiento;            
            return Procedure.ExecuteReadAction(proc.NombreProcedimiento, cmd, conexion);
        }

        public override IEnumerable<Dictionary<string, object>> Funcion(object element, string Funcion, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd;
            cmd = Base.LoadParametersSP(element, sp, conexion, true);
            cmd.Parameters["@Funcion"].Value = Funcion.ToLower();
            cmd.CommandText = sp;
            return Procedure.ExecuteReadAction(sp, cmd, conexion);
        }

        public override List<T> Consultar<T>(object element, bool parametrosSp, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd;
            if (parametrosSp)
                cmd = Base.LoadParametersSP(element, sp, conexion, true);
            else
                cmd = Base.LoadParameters(element, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Select.ToString().ToLower();
            cmd.CommandText = sp;
            return Procedure.ExecuteReadAction<T>(sp,cmd, conexion);
        }

        public override List<T> Buscar<T>(object element, bool parametrosSp, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd;
            if (parametrosSp)
                cmd = Base.LoadParametersSP(element, sp, conexion, true);
            else
                cmd = Base.LoadParameters(element, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Buscar.ToString().ToLower();
            cmd.CommandText = sp;
            return Procedure.ExecuteReadAction<T>(sp, cmd, conexion);
        }

        public override List<T> Consultar<T>(object element, object[] include, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd;
            cmd = Base.LoadParametersSP(element, sp, conexion, true);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Select.ToString().ToLower();
            cmd.CommandText = sp;            
            return Procedure.ExecuteReadAction<T>(sp, include, cmd, conexion);
        }

        public override List<T> Buscar<T>(object element, object[] include, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd;
            cmd = Base.LoadParametersSP(element, sp, conexion, true);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Buscar.ToString().ToLower();
            cmd.CommandText = sp;
            return Procedure.ExecuteReadAction<T>(sp, include, cmd, conexion);
        }

        public override string Nuevo<T>(object element,object[] include, Enumeradores.TypeAction action, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Insert.ToString().ToLower();            
            cmd.CommandText = sp;
            object var = Procedure.ExecuteTransaction<T>(sp,include, cmd, action, conexion);
            return var.ToString();
        }

        public override string NuevoTrans<T>(object element, List<ERPWebApi.Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Insert.ToString().ToLower();
            cmd.CommandText = sp;
            object var = Procedure.ExecuteMultiTransaction<T>(sp, lent, cmd, action, conexion);
            return var.ToString();
        }

        public override string Actualizar<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Update.ToString().ToLower();
            cmd.CommandText = sp;
            object var = Procedure.ExecuteTransaction<T>(sp, include, cmd, action, conexion);
            return var.ToString();
        }

        public override string ActualizarTrans<T>(object element, List<ERPWebApi.Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Update.ToString().ToLower();
            cmd.CommandText = sp;
            object var = Procedure.ExecuteMultiTransaction<T>(sp, lent, cmd, action, conexion);
            return var.ToString();
        }

        public override string ActualizarInsertarTrans<T>(object element, List<ERPWebApi.Entidades.Entidad> lent, Enumeradores.TypeAction action, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, false);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.UpdateInsert.ToString().ToLower();
            cmd.CommandText = sp;
            object var = Procedure.ExecuteMultiTransaction<T>(sp, lent, cmd, action, conexion, Enumeradores.TipoFuncion.UpdateInsert);
            return var.ToString();
        }

        public override string Copiar<T>(object element, object[] include, Enumeradores.TypeAction action, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, true);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Copiar.ToString().ToLower();
            cmd.CommandText = sp;
            object var = Procedure.ExecuteTransaction<T>(sp, include, cmd, action, conexion);
            return var.ToString();
        }

        public override string Eliminar<T>(object element, string conexion) //where T : new()
        {
            string sp = "sp_" + element.GetType().Name.ToString();
            SqlCommand cmd = Base.LoadParametersSP(element, sp, conexion, true);
            cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Delete.ToString().ToLower();
            cmd.CommandText = sp;
            object var = Procedure.ExecuteTransaction<T>(sp, null, cmd, Enumeradores.TypeAction.None, conexion);
            return var.ToString();
        }

        

    }


}