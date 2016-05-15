using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GitCandy.Models
{
    public class StatsModel
    {
        public WorkingDayModel[] WorkingDay { get; set; }
        public DataTable CommitsTable { get; set; }
    }

    public class WorkingDayModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}