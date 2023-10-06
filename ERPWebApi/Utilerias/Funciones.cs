using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
//using SIMAC.Formas;


namespace ERPWebApi
{
    class Funciones
    {

        private static Funciones instance;

        public static Funciones Instance()
        {
            if (instance == null)
            {
                instance = new Funciones();
            }
            return instance;
        }

        public static async void Delay(int nMilisegundos)
        {
            await Task.Delay(nMilisegundos);                       
        }

        public static string StringRepeat(char sCaracter, int Cuantos)
        {
            try
            {
                string s = new string(sCaracter, Cuantos);
                return s;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static decimal StringTodecimal(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return decimal.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static decimal StringToDecimal(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return decimal.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static Single StringToSingle(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return Single.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static Single StringToFloat(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return Single.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static int StringToInt(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return int.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }
        public static Int16 StringToInt16(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return Int16.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }
        public static Int16 StringToShort(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return Int16.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }
        public static long StringToLong(string sCadena)
        {
            try
            {
                if (sCadena == null)
                    return 0;
                else
                {
                    if (sCadena == "")
                        return 0;
                    else
                        return long.Parse(sCadena.Replace(",", "").Replace(" ", ""), System.Globalization.NumberStyles.Any);
                }
            }
            catch
            {
                return 0;
            }
        }
        public static byte[] StringToByteArray(string sCadena)
        {
            try
            {
                if (sCadena == "")
                    return Convert.FromBase64String("");
                else
                    return Convert.FromBase64String(sCadena);
            }
            catch
            {
                return Convert.FromBase64String("");
            }
        }

        public static string QuitaAcentos(string Cadena)
        {
            Cadena = Cadena.Replace('á', 'a');
            Cadena = Cadena.Replace('é', 'e');
            Cadena = Cadena.Replace('í', 'i');
            Cadena = Cadena.Replace('ó', 'o');
            Cadena = Cadena.Replace('ú', 'u');
            Cadena = Cadena.Replace('Á', 'A');
            Cadena = Cadena.Replace('É', 'E');
            Cadena = Cadena.Replace('Í', 'I');
            Cadena = Cadena.Replace('Ó', 'O');
            Cadena = Cadena.Replace('Ú', 'U');
            return Cadena;
        }

        public static string FechaSQL(DateTime dtFecha)
        {
            string Sql = "";
            Sql = dtFecha.Year.ToString();
            if (dtFecha.Month < 10)
                Sql += '0' + dtFecha.Month.ToString();
            else
                Sql += dtFecha.Month.ToString();
            if (dtFecha.Day < 10)
                Sql += '0' + dtFecha.Day.ToString();
            else
                Sql += dtFecha.Day.ToString();
            return Sql;
        }

        public static string FechaHoraSQL(DateTime dtFecha)
        {
            string Sql = "";
            Sql = dtFecha.Year.ToString();
            if (dtFecha.Month < 10)
                Sql += '0' + dtFecha.Month.ToString();
            else
                Sql += dtFecha.Month.ToString();
            if (dtFecha.Day < 10)
                Sql += '0' + dtFecha.Day.ToString();
            else
                Sql += dtFecha.Day.ToString();
            Sql += " ";
            if (dtFecha.Hour < 10)
                Sql += '0' + dtFecha.Hour.ToString();
            else
                Sql += dtFecha.Hour.ToString();
            Sql += ":";
            if (dtFecha.Minute < 10)
                Sql += '0' + dtFecha.Minute.ToString();
            else
                Sql += dtFecha.Minute.ToString();
            return Sql;
        }

        public static string encrypt(string strClave)
        {
            byte[] b;
            if (strClave != null)
            {
                b = System.Text.Encoding.UTF8.GetBytes(strClave);
                return System.Convert.ToBase64String(b);
            }
            else
                return "";
        }

        public static string decrypt(string strClave)
        {
            byte[] b;
            if (strClave != null)
            {
                b = System.Convert.FromBase64String(strClave);
                return System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            else
                return "";
        }
                
    }
}
