using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assistant
{
    class DataRowStaff //класс описывает одну строку данных
    {
        //поля, указанные в базе данных
        public object id { get; set; }

        public object login { get; set; }

        public object password { get; set; }

        public object mailS { get; set; }


        //конструкторы класса (задаём нужные параметры)
        public DataRowStaff() { }
        public DataRowStaff(object _login, object _password, object _mailS, object _id)
        {
            id = _id;
            login = _login;
            password = _password;
            mailS = _mailS;
        }

        //методы класса
        public void DataChangeStaff(object _login, object _password, object _mailS, object _id)
        {
            id = _id;
            login = _login;
            password = _password;
            mailS = _mailS;
            
        }
    }


}
