using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Dts;
using Microsoft.SqlServer.Dts.Runtime;
//PublicKeyToken=66fbcab7959cb3df
namespace ECPT
{
    [DtsTask(
        TaskType = "DTS150", 
        DisplayName = "Execute Catalog Package Task", 
        Description ="A task to execute packages stored in a SSIS catalog v1",
        UITypeName = "ExecuteCatalogPackageTaskUI.ExecuteCatalogPackageTaskUI, ExecuteCatalogPackageTaskUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=ca065971ab7c9709",
        IconResource = "ECPT.Resources.favicon.ico")]
    public class ExecuteCatalogPackageTask : Task
    {
        public string ServerName { get; set; } = String.Empty;
        public string PackageCatalog { get; } = "SSISDB";
        public string PackageFolder { get; set; } = String.Empty;
        public string PackageProject { get; set; } = String.Empty;
        public string PackageName { get; set; } = String.Empty;

        public override void InitializeTask(
            Connections connections, 
            VariableDispenser variableDispenser, 
            IDTSInfoEvents events, 
            IDTSLogging log, 
            EventInfos eventInfos, 
            LogEntryInfos logEntryInfos, 
            ObjectReferenceTracker refTracker)
        {
            base.InitializeTask(connections, variableDispenser, events, log, eventInfos, logEntryInfos, refTracker);
        }

        public override DTSExecResult Validate(
            Connections connections, 
            VariableDispenser variableDispenser, 
            IDTSComponentEvents componentEvents, 
            IDTSLogging log)
        {
            return DTSExecResult.Success;
        }

        public override DTSExecResult Execute(
            Connections connections, 
            VariableDispenser variableDispenser, 
            IDTSComponentEvents componentEvents, 
            IDTSLogging log, 
            object transaction)
        {
            
            return DTSExecResult.Success;
        }
    }
}
