using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;



namespace Auto_Scre.Data.EF.Context
{
    public class AppDbContext
    {
        public  string GetConnectString()
        {
            var configBuilder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())      
                       .AddJsonFile("appconfig.json");
         var configurationroot = configBuilder.Build();                
            return configurationroot["csdl:db01"];

        }
     
        public SqlConnection Connectiondb()
        {
            String sqlConnectString = GetConnectString();
            var connection = new SqlConnection(GetConnectString());
            connection.StatisticsEnabled = true;
            connection.FireInfoMessageEventOnUserErrors = true;
            return connection;
        }

    }
}
