using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace SqlServer
{
    public class Query
    {
        public static T Objeto<T>(string sql, string conexion = "") where T : new()
        {            
            var propiedades = typeof(T).GetProperties();
            T objeto = new T();
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    cmd.Connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                           
                            foreach (var propiedad in propiedades)
                            {
                                var nombreCampo = dr[propiedad.Name];
                                if (nombreCampo.GetType() != typeof(DBNull))
                                    propiedad.SetValue(objeto, nombreCampo, null);
                            }                           
                        }
                    }
                    cmd.Connection.Close();
                }

            }
            return objeto;
        }

        public static T Objeto<T>(string sql, List<SqlParameter> parametros, string conexion = "") where T : new()
        {
            var propiedades = typeof(T).GetProperties();
            T objeto = new T();
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Connection.Open();
                    foreach (var item in parametros)
                        cmd.Parameters.Add(item);                   
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            foreach (var propiedad in propiedades)
                            {
                                var nombreCampo = dr[propiedad.Name];
                                if (nombreCampo.GetType() != typeof(DBNull))
                                    propiedad.SetValue(objeto, nombreCampo, null);
                            }
                        }
                    }
                    cmd.Connection.Close();
                }

            }
            return objeto;
        }

        public static List<T> Coleccion<T>(string sql, string conexion = "") where T : new()
        {
            var propiedades = typeof(T).GetProperties();
            List<T> result = new List<T>();
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            T objeto = new T();
                            foreach (var propiedad in propiedades)
                            {
                                if (propiedad.PropertyType == typeof(Int16) || propiedad.PropertyType == typeof(Int32) || propiedad.PropertyType == typeof(Int64) ||
                                    propiedad.PropertyType == typeof(string) || propiedad.PropertyType == typeof(bool) || propiedad.PropertyType == typeof(decimal) ||
                                    propiedad.PropertyType == typeof(decimal) || propiedad.PropertyType == typeof(float) || propiedad.PropertyType == typeof(DateTime) ||
                                    propiedad.PropertyType == typeof(Int16?) || propiedad.PropertyType == typeof(Int32?) || propiedad.PropertyType == typeof(Int64?) ||
                                    propiedad.PropertyType == typeof(bool?) || propiedad.PropertyType == typeof(decimal?) || propiedad.PropertyType == typeof(decimal?) ||
                                    propiedad.PropertyType == typeof(float?) || propiedad.PropertyType == typeof(DateTime?))
                                {
                                    var nombreCampo = dr[propiedad.Name];
                                    if (nombreCampo.GetType() != typeof(DBNull))
                                        propiedad.SetValue(objeto, nombreCampo, null);
                                }

                            }
                            result.Add(objeto);
                        }
                    }
                    cmd.Connection.Close();
                }

            }
            return result;
        }
        public static List<T> Coleccion<T>(string sql, List<SqlParameter> parametros, string conexion = "") where T : new()
        {
            var propiedades = typeof(T).GetProperties();
            List<T> result = new List<T>();
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Connection.Open();
                    foreach (var item in parametros)
                        cmd.Parameters.Add(item);   
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            T objeto = new T();
                            foreach (var propiedad in propiedades)
                            {
                                if (propiedad.PropertyType == typeof(Int16) || propiedad.PropertyType == typeof(Int32) || propiedad.PropertyType == typeof(Int64) ||
                                    propiedad.PropertyType == typeof(string) || propiedad.PropertyType == typeof(bool) || propiedad.PropertyType == typeof(decimal) ||
                                    propiedad.PropertyType == typeof(decimal) || propiedad.PropertyType == typeof(float) || propiedad.PropertyType == typeof(DateTime) ||
                                    propiedad.PropertyType == typeof(Int16?) || propiedad.PropertyType == typeof(Int32?) || propiedad.PropertyType == typeof(Int64?) ||
                                    propiedad.PropertyType == typeof(bool?) || propiedad.PropertyType == typeof(decimal?) || propiedad.PropertyType == typeof(decimal?) ||
                                    propiedad.PropertyType == typeof(float?) || propiedad.PropertyType == typeof(DateTime?))
                                {
                                    var nombreCampo = dr[propiedad.Name];
                                    if (nombreCampo.GetType() != typeof(DBNull))
                                        propiedad.SetValue(objeto, nombreCampo, null);
                                }
                            }
                            result.Add(objeto);
                        }
                    }
                    cmd.Connection.Close();
                }

            }
            return result;
        }
        public static string Actualizar(string sql, List<SqlParameter> parametros, string conexion = "") 
        {
            string result = "0";
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Connection.Open();
                    foreach (var item in parametros)                       
                        cmd.Parameters.Add(item);
                   result =  Convert.ToString(cmd.ExecuteScalar());               
                }
            }
            return result;
        }

        public static string TransaccionActualizar(string sql, List<SqlParameter> parametros, string conexion = "")
        {
            string result = "0";
            using (SqlConnection con = new SqlConnection(conexion == "" ? Conexiones.SqlServer.conexion : conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Connection.Open();
                    foreach (var item in parametros)
                        cmd.Parameters.Add(item);
                    result = Convert.ToString(cmd.ExecuteScalar());
                }
            }
            return result;
        }

    }
}
