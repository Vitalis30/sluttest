using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sluttest
{
    class TaskList
    {
            private string task;
            private DateTime dueDate;
            public TaskList(string task, DateTime duedate)
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

