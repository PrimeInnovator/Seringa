﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Siringa.Engine.Utils;

namespace Siringa.Engine.Interfaces
{
    public interface IProxyDetails
    {
        ProxyType ProxyType { get; set; }
        /// <summary>
        /// adress and port
        /// </summary>
        string FullProxyAddress { get; set; }
        string ProxyAddress { get; set; }
        int ProxyPort { get; set; }
        string ProxyUserName { get; set; }
        string ProxyPassword { get; set; }
    }
}
