using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ContactosMySQLConDataAdapter:Contactos
    {
        public string connectionString { get { return "server=isi;database=net;uid=net;pwd=net"; } }
        public ContactosMySQLConDataAdapter():base()
        {
            //this.
        }
    }
}
