using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using ERPWebApi.DAL;


namespace SqlServer
{    

    public static class Procedure
    {
        public static bool hasError = false;
        public static string error = "";

        public static IEnumerable<Dictionary<string, object>> ExecuteReadAction(string sp, SqlCommand command, string conexion)
        {
            hasError = false;
            error = "";
            IEnumerable<Dictionary<string, object>> result;
            try
            {
                using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
                {
                    SqlCommand cmd = command;
                    cmd.CommandTimeout = 120;
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        result = Funciones.Serialize(dr);
                    }
                    cmd.Connection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                hasError = true;
                error = ex.Message;
            }
            return null;
        }

        public static List<T> ExecuteReadAction<T>(string sp, SqlCommand command, string conexion) where T : new()
        {
            hasError = false;
            error = "";
            var propiedades = typeof(T).GetProperties();
            List<T> result = new List<T>();
            try
            {
                using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
                {
                    SqlCommand cmd = command;
                    cmd.CommandTimeout = 120;
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            T obj = new T();
                            foreach (var propiedad in propiedades)
                            {
                                if (HasColumn(dr, propiedad.Name))
                                {
                                    var NameField = dr[propiedad.Name];
                                    if (NameField.GetType() != typeof(DBNull))
                                        propiedad.SetValue(obj, NameField, null);
                                }
                            }
                            result.Add(obj);
                        }
                    }
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                hasError = true;
                error += ex.Message + ";";
            }
            return result;
        }

        public static List<T> ExecuteReadAction<T>(string sp, object[] include, SqlCommand command, string conexion) where T : new()
        {
            hasError = false;
            error = "";
            List<IncludesObject> refer = new List<IncludesObject>();
            T Obj = new T();
            foreach (var p in typeof(T).GetProperties())
            {
                refer.Add(new IncludesObject() { Entity = Obj, TypeEntity = typeof(T).Name, Property = p });
            }
            if (include != null)
            {
                foreach (var item in include)
                {
                    foreach (var p in item.GetType().GetProperties())
                    {
                        refer.Add(new IncludesObject() { Entity = item, TypeEntity = item.GetType().Name, Property = p });
                    }
                }
            }
            var assembly = ERPWebApi.DAL.AppDomain.CurrentDomain.GetAssemblies().Where(c => c.FullName == "ERPWebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null").FirstOrDefault();
            List<T> result = new List<T>();
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                SqlCommand cmd = command;
                cmd.CommandTimeout = 120;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        T newElement = new T();
                        for (int x = 0; x < dr.FieldCount; x++)
                        {                            
                            string nameColumn = dr.GetName(x);                            
                            IncludesObject data = refer.Where(c => c.Property.Name.ToLower() == nameColumn.ToLower()).FirstOrDefault();
                            if (data != null)
                            {
                                var valBd = dr[nameColumn];
                                try {
                                    if (valBd.GetType() != typeof(DBNull))
                                    {
                                        if (data.TypeEntity == newElement.GetType().Name)
                                            newElement.GetType().GetProperty(data.Property.Name).SetValue(newElement, valBd, null);
                                        else
                                        {
                                            object subEntity = newElement.GetType().GetProperty(data.TypeEntity).GetValue(newElement, null);
                                            if (subEntity == null)
                                            {
                                                Type magicType = assembly.GetType("ERPWebApi.Entidades." + data.TypeEntity);
                                                ConstructorInfo magicConstructor = magicType.GetConstructor(Type.EmptyTypes);
                                                subEntity = magicConstructor.Invoke(new object[] { });
                                                newElement.GetType().GetProperty(data.TypeEntity).SetValue(newElement, subEntity, null);
                                            }
                                            subEntity.GetType().GetProperty(data.Property.Name).SetValue(subEntity, valBd, null);       
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    hasError = true;
                                    error += ex.Message + ";";
                                }
                            }                            
                        }
                        result.Add(newElement);
                    }                    
                }
                cmd.Connection.Close();
            }
            return result;
        }

        //public static string ExecuteTransaction<T>(string sp, object[] include, SqlCommand command, Enumeradores.TypeAction action, string conexion) where T : new()
        //{
        //    string result = "0";
        //    SqlTransaction transaction=null;
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion: conexion))
        //        {
        //            con.Open();
        //            string g = Guid.NewGuid().ToString().Substring(5);
        //            transaction = con.BeginTransaction(g);
        //            SqlCommand cmd = command;
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.Connection = con;
        //            cmd.Transaction = transaction;
        //            if (action == Enumeradores.TypeAction.None)
        //                result = ExecuteTransactionNone(cmd);
        //            if (action == Enumeradores.TypeAction.Main)
        //            {
        //                foreach (var d in include)
        //                {
        //                    if (d != null)
        //                    {
        //                        string keyResult = ExecuteTransactionMain(d, cmd);
        //                        string nameObj = "@ID" + d.GetType().Name.ToString();
        //                        if (!string.IsNullOrEmpty(result))
        //                            cmd.Parameters[nameObj].Value = keyResult;
        //                    }
        //                }
        //                result = ExecuteTransactionNone(cmd);
        //            }
        //            if (action == Enumeradores.TypeAction.Detail)
        //            {
        //                result = ExecuteTransactionNone(cmd);
        //                string masterKey = "@ID" + typeof(T).Name;
        //                foreach (var d in include)
        //                {
        //                    if (d != null)
        //                    {
        //                        string keyResult = ExecuteTransactionDetail(d, masterKey, result, cmd, conexion);
        //                        string nameObj = "@ID" + d.GetType().Name.ToString();
        //                        if (!string.IsNullOrEmpty(result))
        //                            cmd.Parameters[nameObj].Value = keyResult;
        //                    }
        //                }
        //            }
        //            transaction.Commit();
        //        }   
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        return result;
        //    }
        //}

        public static string ExecuteTransaction<T>(string sp, object[] include, SqlCommand command, Enumeradores.TypeAction action, string conexion) where T : new()
        {
            hasError = false;
            error = "";
            string result = "0";
            SqlTransaction transaction = null;
            try
            {
                using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
                {
                    con.Open();
                    string g = Guid.NewGuid().ToString().Substring(5);
                    transaction = con.BeginTransaction(g);
                    SqlCommand cmd = command;
                    cmd.CommandTimeout = 120;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Transaction = transaction;
                    if (action == Enumeradores.TypeAction.None) // Solo si la insersion no depende  de insertar datos en otra tabla
                        result = ExecuteTransactionNone(cmd);
                    if (action == Enumeradores.TypeAction.Main) // Solo si el id del elemento icluido corresponte al elemento base 
                    {
                        foreach (var d in include)
                        {
                            if (d != null)
                            {
                                string keyResult = ExecuteTransactionMain(d, cmd, "", conexion);
                                string nameObj = "@ID" + d.GetType().Name.ToString();
                                if (!string.IsNullOrEmpty(result))
                                    cmd.Parameters[nameObj].Value = keyResult;
                            }
                        }
                        result = ExecuteTransactionNone(cmd);
                    }
                    if (action == Enumeradores.TypeAction.Detail) // Para operaciones con maestro detalle
                    {
                        result = ExecuteTransactionNone(cmd);
                        if (include.Count() > 0)
                        {                            
                            string masterKey = "@ID" + typeof(T).Name;
                            foreach (var d1 in include)
                            {
                                if (d1 != null)
                                {
                                    string keyResult = ExecuteTransactionDetail(d1, masterKey, result, cmd, conexion);
                                    if (ERPWebApi.Funciones.StringToLong(keyResult) == 0)
                                    {
                                        transaction.Rollback();
                                        con.Close();
                                        return keyResult;
                                    }                                    
                                }                              
                            }
                        }
                    }
                    if (action == Enumeradores.TypeAction.DetailRef) // Para operaciones con maestro detalle con IdRef
                    {
                        result = ExecuteTransactionNone(cmd);
                        if (include.Count() > 0)
                        {                            
                            string masterKey = "@IDREF";
                            foreach (var d1 in include)
                            {
                                if (d1 != null)
                                {
                                    string keyResult = ExecuteTransactionDetail(d1, masterKey, result, cmd, conexion);
                                    if (ERPWebApi.Funciones.StringToLong(keyResult) == 0)
                                    {
                                        transaction.Rollback();
                                        con.Close();
                                        return keyResult;
                                    }                                    
                                }
                            }
                        }
                    }
                    transaction.Commit();
                    con.Close();
                }                
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                hasError = true;
                error += ex.Message + ";";
                return result;
            }
        }

        public static string ExecuteMultiTransaction<T>(string sp, List<ERPWebApi.Entidades.Entidad> lent, SqlCommand command, Enumeradores.TypeAction action, string conexion, Enumeradores.TipoFuncion nTipoFuncion = Enumeradores.TipoFuncion.Ninguno) where T : new()
        {
            hasError = false;
            error = "";
            string result = "0";
            SqlTransaction transaction = null;
            try
            {
                using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
                {
                    con.Open();
                    string g = Guid.NewGuid().ToString().Substring(5);
                    transaction = con.BeginTransaction(g);
                    SqlCommand cmd = command;
                    cmd.CommandTimeout = 120;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Transaction = transaction;
                    if (action == Enumeradores.TypeAction.None) // Solo si la insersion no depende  de insertar datos en otra tabla
                    {
                        //result = ExecuteTransactionNone(cmd);
                        foreach (ERPWebApi.Entidades.Entidad e in lent)
                        {
                            if (e != null)
                            {                                
                                foreach (var d in e.include)
                                {
                                    if (d != null)
                                    {
                                        result = ExecuteTransactionMain(d, cmd, e.TypeName, conexion, nTipoFuncion);
                                        if (result == null || ERPWebApi.Funciones.StringToLong(result) == 0)
                                        {
                                            transaction.Rollback();
                                            con.Close();
                                            return result;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (action == Enumeradores.TypeAction.Main) // Solo si el id del elemento icluido corresponte al elemento base 
                    {
                        foreach (ERPWebApi.Entidades.Entidad e in lent)
                        {
                            if (e != null)
                            {
                                string keyResult = ExecuteTransactionMain(e.include, cmd, e.TypeName, conexion);
                                string nameObj = "@ID" + e.TypeName;
                                if (!string.IsNullOrEmpty(result))
                                    cmd.Parameters[nameObj].Value = keyResult;
                            }
                        }
                        result = ExecuteTransactionNone(cmd);
                    }
                    if (action == Enumeradores.TypeAction.Detail) // Para operaciones con maestro detalle
                    {
                        result = ExecuteTransactionNone(cmd);
                        if (ERPWebApi.Funciones.StringToLong(result) == 0)
                        {
                            transaction.Rollback();
                            con.Close();
                            return result;
                        }
                        else
                        {
                            if (lent.Count() > 0)
                            {
                                string masterKey;
                                foreach (ERPWebApi.Entidades.Entidad e1 in lent)
                                {
                                    string keyResult1;
                                    if (e1.MasterDetailKey != "")
                                        masterKey = e1.MasterDetailKey;
                                    else
                                        masterKey = "@ID" + typeof(T).Name;
                                    foreach (var d1 in e1.include)
                                    {
                                        if (d1 != null)
                                        {
                                            if (e1.TransactionDetailType == Enumeradores.TypeAction.Main)
                                                keyResult1 = ExecuteTransactionMain(d1, cmd, e1.TypeName, conexion);
                                            else
                                                keyResult1 = ExecuteTransactionDetail(d1, masterKey, result, cmd, e1.TypeName, conexion);
                                            if (ERPWebApi.Funciones.StringToLong(keyResult1) == 0)
                                            {
                                                transaction.Rollback();
                                                con.Close();
                                                return keyResult1;
                                            }
                                            else
                                            {
                                                foreach (ERPWebApi.Entidades.Entidad e2 in e1.lEntidad)
                                                {
                                                    List<Param> lparam = new List<Param>();
                                                    if (e2.ParamValueFirstParent)
                                                    {
                                                        string masterKey1 = (e1.MasterDetailKey != "" ? e1.MasterDetailKey : "@ID" + e1.TypeName);
                                                        lparam.Add(new Param() { Key = masterKey1, Value = keyResult1 });
                                                    }
                                                    string keyResult2;
                                                    if (e2.MasterDetailKey != "" && e2.ParamValueFirstParent)
                                                    {
                                                        lparam.Add(new Param() { Key = e2.MasterDetailKey, Value = result });
                                                    }
                                                    else
                                                    {
                                                        lparam.Add(new Param() { Key = e2.MasterDetailKey, Value = keyResult1 });
                                                    }
                                                    foreach (var d2 in e2.include)
                                                    {
                                                        if (d2 != null)
                                                        {
                                                            keyResult2 = ExecuteTransactionDetail(d2, lparam, cmd, e2.TypeName, conexion);
                                                            if (ERPWebApi.Funciones.StringToLong(keyResult2) == 0)
                                                            {
                                                                transaction.Rollback();
                                                                con.Close();
                                                                return keyResult2;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }                    
                    transaction.Commit();
                    con.Close();
                }                
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                hasError = true;
                error += ex.Message + ";";
                return result;
            }
        }

        public static string ExecuteTransactionNone(SqlCommand cmd) 
        {
            hasError = false;
            error = "";
            string result = null;
            try
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                        result = Convert.ToString(dr.GetValue(0));
            }
            catch(Exception ex)
            {
                result = ex.Message;
                hasError = true;
                error += ex.Message + ";";
            }
            return result;
        }

        public static string ExecuteTransactionDetail(object objectInclude, string MasterKey, string MasterValue, SqlCommand command, string TypeName = "", string conexion = "")
        {
            SqlCommand cmd = CommandTransactionMain(objectInclude, command, TypeName, conexion);
            cmd.Parameters[MasterKey].Value = MasterValue;           
            return ExecuteTransactionNone(cmd);
        }

        public static string ExecuteTransactionDetail(object objectInclude, List<Param> lparam, SqlCommand command, string TypeName = "", string conexion = "")
        {
            SqlCommand cmd = CommandTransactionMain(objectInclude, command, TypeName, conexion);
            foreach(Param p in lparam)
            {
                cmd.Parameters[p.Key].Value = p.Value;                
            }
            return ExecuteTransactionNone(cmd);
        }

        public static string ExecuteTransactionMain(object objectInclude, SqlCommand command, string TypeName = "", string conexion = "", Enumeradores.TipoFuncion enTipoFuncion = Enumeradores.TipoFuncion.Ninguno) 
        {
            SqlCommand cmd = CommandTransactionMain(objectInclude, command, TypeName, conexion, enTipoFuncion);
            return ExecuteTransactionNone(cmd);
        }

        public static SqlCommand CommandTransactionMain(object objectInclude, SqlCommand command, string TypeName = "", string conexion = "", Enumeradores.TipoFuncion enTipoFuncion = Enumeradores.TipoFuncion.Ninguno)
        {
            string sp = "sp_" + (TypeName == "" ? objectInclude.GetType().Name.ToString() : TypeName);
            SqlCommand cmd = Base.LoadParametersSP(objectInclude, sp, conexion, false);
            cmd.CommandText = sp;
            if (enTipoFuncion == Enumeradores.TipoFuncion.Ninguno)
            {
                System.Reflection.PropertyInfo propertie = objectInclude.GetType().GetProperties().Where(c => c.Name.ToLower() == "id").FirstOrDefault();
                if (Convert.ToInt64(propertie.GetValue(objectInclude, null)) == 0)
                    cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Insert.ToString().ToLower();
                if (Convert.ToInt64(propertie.GetValue(objectInclude, null)) != 0)
                    cmd.Parameters["@Funcion"].Value = Enumeradores.TipoFuncion.Update.ToString().ToLower();
            }
            else
            {
                cmd.Parameters["@Funcion"].Value = enTipoFuncion.ToString().ToLower();
            }
            cmd.Connection = command.Connection;
            cmd.Transaction = command.Transaction;
            cmd.CommandType = command.CommandType;
            return cmd;
        }

        public static bool HasColumn(this System.Data.IDataRecord r, string columnName)
        {
            hasError = false;
            error = "";
            try
            {
                return r.GetOrdinal(columnName) >= 0;
            }
            catch (IndexOutOfRangeException)
            {
                hasError = true;                
                return false;
            }
        }

        public static T Instance<T>() where T : new()
        {
            return new T();
        }

        

    }

    public class Param
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    

    public class IncludesObject
    {
        public object Entity { get; set; }

        public string TypeEntity { get; set; }

        public System.Reflection.PropertyInfo Property { get; set; }
    }


}
