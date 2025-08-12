using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerTab.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public DateTime Expected_Date { get; set; }

        public DateTime Task_Date { get; set; }
        public string Expected_Hours { get; set; }
        public int AssigneeID { get; set; }

        public string AssigneeName { get; set; }
    }
}
