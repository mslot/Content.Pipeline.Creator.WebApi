using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Pipeline.Creator.Core
{
    public class ServicebusOptions
    {
        public string ConnectionString { get; set; }
        public string DefaultSharedAccessPolicyPrimaryKey { get; set; }
        public string TopicName { get; set; }
    }
}
