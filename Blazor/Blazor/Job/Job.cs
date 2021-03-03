using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Job
{
    public partial class Job
    {
        public int IdJob { get; set; }
        public string Namejob { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public string Status { get; set; }
    }
}
