using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace sluttest
{
    public class Member
    {
        private string username;
        private string realName;
        public BindingList<TaskList> tasks = new BindingList<TaskList>();
        

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



    }
    

    
}
