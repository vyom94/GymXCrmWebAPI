using CRM.Infrastructure.Settings.Section;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Infrastructure.Settings
{
    public interface ISettings
    {
        ConnectionStringSettings ConnectionString { get; }
    }
}
