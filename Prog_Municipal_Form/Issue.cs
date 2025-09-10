using System;

namespace Prog_Municipal_Form
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public DateTime ReportedAt { get; set; }

        public override string ToString()
        {
            return $"{Category} issue at {Location} reported on {ReportedAt}";
        }
    }
}
