using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Data
{
    public class Job
    {
        public int id_Job { set; get; }
        public string namejob {set;get;}
        public DateTime starttime { set; get; }
        public DateTime endtime { set; get; }
        public string status { set; get; }
    }
}
