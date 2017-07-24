using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace APITest.Models
{
    public class ConfigReader
    {
        #region global vars
        private readonly ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = "APITest.dll.config" };

        //Only supports username and password but more could be added
        public string username { get; }
        public string password { get; }
        public string orgId { get; }
        public string Authorization { get; }
        #endregion global vars

        public ConfigReader()
        {
            Configuration path = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None); //Opens the config file from the mapped path
            username = path.AppSettings.Settings["username"].Value; //Key value pair transform
            password = path.AppSettings.Settings["password"].Value;
            orgId = path.AppSettings.Settings["orgId"].Value;
            Authorization = path.AppSettings.Settings["authorization"].Value;
        }
    }
}