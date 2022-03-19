using CRM.Infrastructure.Settings.Section;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Infrastructure.Settings
{
    public class Settings : ISettings
    {
        public ConnectionStringSettings ConnectionString { get; }
        public Settings(IConfiguration configuration)
        {
            ConnectionString = configuration.GetSection("ConnectionStrings").Get<ConnectionStringSettings>();
            //AllowedHosts = configuration.GetValue<string>("AllowedHosts");

            if (ConnectionString == null) { ConnectionString = new ConnectionStringSettings(); }
            //if (AllowedHosts == null) { AllowedHosts = ""; }

        }
       
    }

}
