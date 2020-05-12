using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19v3.SD
{
    public class ClaseBase
    {

        public String CadenaConexion()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ConexionDB"].ToString();
        }
        public String EsquemaBaseDatos()
        {
            return System.Configuration.ConfigurationManager.AppSettings["EsquemaDB"].ToString();
        }

    }
}