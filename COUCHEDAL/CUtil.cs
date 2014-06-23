using System;
using System.Configuration;
using System.Data.SqlClient;

namespace COUCHEDAL
{
    public static class CUtil
    {
        public static String GetConnexion()
        {
            string connexion = ConfigurationManager.ConnectionStrings["HOST.Settings.MyConnectionString"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(connexion);
            return builder.ConnectionString;
        }
    }
}
