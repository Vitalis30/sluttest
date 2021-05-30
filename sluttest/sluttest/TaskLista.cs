using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sluttest
{
    public class TaskLista
    {
        private string task;
        private DateTime dueDate;
        public TaskLista(string task, DateTime duedate)
        {
            this.task = task;
            this.dueDate = duedate;
        }

        public string Task
        {
            get
            {
                return task;
            }

            set
            {
                task = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }

            set
            {
                dueDate = value;
            }
        }
    }
}


