using System.Collections.Generic;

namespace Nudge.APM.Tracer
{
    public class TransactionData
    {
        // Transaction
        public string MethodName { get; set; }
        public string ControllerName { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public string UserAgent { get; set; }
        public string ContentType { get; set; }
        // SQL Layer
        public bool IsSqlData { get; set; }
        public List<object> SqlQueries { get; set; }
        public string CodeSql { get; set; }
        public long TimeStartSql { get; set; }
        public long TimeSql { get; set; }
        // DB information
        public string SqlConnectionString { get; set; }
        public string NameDatabase { get; set; }
        public string Servertype { get; set; }
        public string ServerVersion { get; set; }
    }
}