using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Fathym;
using Fathym.Design.Singleton;
using LCU.Graphs;
using LCU.Graphs.Registry.Enterprises;
using LCU.Runtime;
using LCU.State.API.Devices.ConfigManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace LCU.State.API.Devices.ConfigManager.Harness
{
    public class DevicesConfigManagerStateHarness : LCUStateHarness<DevicesConfigManagerState>
    {
        #region Fields
        #endregion

        #region Properties

        #endregion

        #region Constructors
        public DevicesConfigManagerStateHarness(HttpRequest req, ILogger log, DevicesConfigManagerState state)
            : base(req, log, state)
        { }
        #endregion

        #region API Methods
        public virtual async Task<DevicesConfigManagerState> Ensure()
        {
            return state;
        }
        #endregion

        #region Helpers

        #endregion
    }
}