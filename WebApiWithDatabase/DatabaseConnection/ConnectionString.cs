
using OfficeOpenXml;
using ExcelDataReader;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data;


namespace WebApiWithDatabase.DatabaseConnection
{
    public class ConnectionString
    {
        private string serverName;
        private string databaseName;
        private string username;
        private string password;

        private List<int> databaseId = new List<int>();


        public ConnectionString(string servername, string databaseName, string username, string password)
        {
            this.serverName = servername;
            this.databaseName = databaseName;
            this.username = username;
            this.password = password;
        }



        public string getConnectionString()
        {
            return "Server=" + this.serverName + "; Database=" + this.databaseName + "; User Id=" + this.username + "; Password=" + this.password;   
        }
    }
}



