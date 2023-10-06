using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using ERPWebApi.DAL;

namespace SqlServer
{
    public static class Base
    {
        public static SqlCommand LoadParameters(Object obj, bool update)
        {
            SqlCommand command = new SqlCommand();
            var propiedades = obj.GetType().GetProperties();
            foreach (var item in propiedades)
                if (item.PropertyType == typeof(Int16) || item.PropertyType == typeof(Int32) || item.PropertyType == typeof(Int64) ||
                    item.PropertyType == typeof(string) || item.PropertyType == typeof(float) || item.PropertyType == typeof(DateTime) ||
                    item.PropertyType == typeof(decimal) || item.PropertyType == typeof(decimal) || item.PropertyType == typeof(bool) ||
                    item.PropertyType == typeof(Int16?) || item.PropertyType == typeof(Int32?) || item.PropertyType == typeof(Int64?) ||
                    item.PropertyType == typeof(decimal?) ||  item.PropertyType == typeof(decimal?) ||  item.PropertyType == typeof(bool?) ||
                    item.PropertyType == typeof(float?) || item.PropertyType == typeof(DateTime?) )
                {
                    object objVal = item.GetValue(obj, null) ?? DBNull.Value;
                    //if (item.Name != "ID" || update)
                    command.Parameters.Add(new SqlParameter("@" + item.Name, item.GetValue(obj, null) ?? DBNull.Value));
                }
            return command;
        }

        public static SqlCommand LoadParametersSP(Object obj, string sp, string conexion, bool Lectura)
        {
            SqlCommand command = new SqlCommand();            
            var properties = obj.GetType().GetProperties();
            Procedimiento pro = GetParams(sp, conexion);
            if (pro!=null)
            {
                foreach (var param in pro.Parametros)
                {
                    string nameparam = param.Nombre.Replace('@', ' ').Trim(); 
                    System.Reflection.PropertyInfo propertie = properties.Where(c => c.Name.ToLower() == nameparam.ToLower()).FirstOrDefault();
                    object objVal = DBNull.Value;
                    if (propertie != null)
                    {
                        objVal = propertie.GetValue(obj, null) ?? DBNull.Value;
                        if (propertie.PropertyType == typeof(byte[]) && Lectura)
                            objVal = new byte[0];
                    }
                  
                    command.Parameters.Add(new SqlParameter(param.Nombre, objVal));
                }
            }
            return command;
        }

        public static SqlCommand LoadParametersSP(Procedimiento proc, string conexion)
        {
            SqlCommand command = new SqlCommand();            
            Procedimiento pro = GetParams(proc.NombreProcedimiento, conexion);
            if (pro != null)
            {
                foreach (var p in pro.Parametros)
                {
                    foreach (var param in proc.Parametros)
                    {
                        if (p.Nombre.ToLower() == param.Nombre.ToLower())
                        {
                            if (param.Valor != null)
                            {
                                command.Parameters.Add(new SqlParameter(p.Nombre, param.Valor));
                            }                            
                        }
                    }
                }
            }
            return command;
        }

        public static Procedimiento GetParams(string sp, string conexion)
        {
            try
            {
                Procedimiento p;
                using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion: conexion))
                {
                    SqlCommand cmd = new SqlCommand("select Nombre = PARAMETER_NAME, Tipo = DATA_TYPE, Longitud = CHARACTER_MAXIMUM_LENGTH from information_schema.parameters where specific_name = '"+ sp + "'");
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection.Open();
                    p = new Procedimiento() { Parametros = new List<Parameter>(), NombreProcedimiento = sp };
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Parameter param = new Parameter();
                            param.Nombre = dr.GetValue(dr.GetOrdinal("Nombre")).ToString().ToLower();
                            param.Tipo = dr.GetValue(dr.GetOrdinal("Tipo")).ToString();
                            param.Longitud = dr.GetValue(dr.GetOrdinal("Longitud")).ToString();
                            p.Parametros.Add(param);
                        }
                    }
                    cmd.Connection.Close();
                }
                return p;
            }
            catch
            {
                return null;
            }
        }
    }


    
}
