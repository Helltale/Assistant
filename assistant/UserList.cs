using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assistant
{
    class UserList
    {
        private static string _userName;
        public string userName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (userName != "")
                    _userName = userName;
            }
        }

        public UserList() { } // конструктор без параметра
        public UserList(string user) // конструктор с параментром
        {
            _userName = user;
        }
    }
}
