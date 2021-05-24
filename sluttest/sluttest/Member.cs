using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sluttest
{
    public class Member
    {
        private string username;
        private string realName;
        private List<string> tasks;
        private List<DateTime> taskDueTime;
        

        //Add new member
        public Member(string username, string realName)
        {
            this.username = username;
            this.realName = realName;
        }
        public override string ToString()
        {
            return $"{realName} ({username})";
        }
        public Member() { }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string RealName
        {
            get
            {
                return realName;
            }

            set
            {
                realName = value;
            }
        }

        public List<string> Tasks
        {
            get
            {
                return tasks;
            }

            set
            {
                tasks = value;
            }
        }

        public List<DateTime> TaskDueTime
        {
            get
            {
                return taskDueTime;
            }

            set
            {
                taskDueTime = value;
            }
        }

    }

    
}
