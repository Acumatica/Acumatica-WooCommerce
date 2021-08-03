using System.Collections.Generic;

namespace ACSC.Tests.Entity.ConnectorEntity
{
    public class ConnectorEntity
    {
        public ConnectorEntity()
        {
            ImportMapping = new List<ImportMapping>();
            ExportMapping = new List<ExportMapping>();
            ExportFiltering = new List<ExportFiltering>();
            ImportFiltering = new List<ImportFiltering>();
        }

        public string Store { get; set; }
        public string EntityType { get; set; }
        public List<ImportMapping> ImportMapping { get; set; }
        public List<ExportMapping> ExportMapping { get; set; }
        public List<ExportFiltering> ExportFiltering { get; set; }
        public List<ImportFiltering> ImportFiltering { get; set; }

    }

    public class ImportMapping
    {
        public string TargetObj { get; set; }
        public string TargetField { get; set; }
        public string SourceObj { get; set; }
        public string SourceField { get; set; }
    }

    public class ExportMapping
    {
        public string TargetObj { get; set; }
        public string TargetField { get; set; }
        public string SourceObj { get; set; }
        public string SourceField { get; set; }
    }

    public class ExportFiltering
    {
        public string OpenBrackets { get; set; }
        public string FieldName { get; set; }
        public string Condition { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }
        public string CloseBrackets { get; set; }
        public string Operator { get; set; }
    }

    public class ImportFiltering
    {
        public string OpenBrackets { get; set; }
        public string FieldName { get; set; }
        public string Condition { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }
        public string CloseBrackets { get; set; }
        public string Operator { get; set; }
    }
}