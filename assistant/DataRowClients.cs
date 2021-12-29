using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assistant
{
    class DataRowClients //класс описывает одну строку данных
    {
        //поля, указанные в базе данных
        public object id { get; set; }

        public object firstname { get; set; }

        public object lastname { get; set; }

        public object patronymuc { get; set; }

        public object birthday { get; set; }

        public object telephone { get; set; }

        public object email { get; set; }

        //конструкторы класса (задаём нужные параметры)
        public DataRowClients() { }
        public DataRowClients(object _id, object _firstname, object _lastname, object _patronymuc, object _birthday, object _telephone, object _email)
        {
            id = _id;
            firstname = _firstname;
            lastname = _lastname;
            patronymuc = _patronymuc;
            birthday = _birthday;
            telephone = _telephone;
            email = _email;
        }

        //методы класса
        public void DataChange(object _id, object _firstname, object _lastname, object _patronymuc, object _birthday, object _telephone, object _email)
        {
            id = _id;
            firstname = _firstname;
            lastname = _lastname;
            patronymuc = _patronymuc;
            birthday = _birthday;
            telephone = _telephone;
            email = _email;
        }
    }

    
}
