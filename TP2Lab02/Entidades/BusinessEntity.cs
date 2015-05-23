using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        int _ID;
        enum States
        {
            New,
            Modified,
            Unmodified,
            Deleted
        }

        public int ID { get { return _ID; } 
                        set { _ID = value; } }
        public States State { get;set;}

        public BusinessEntity()
        {
            this.State = States.New;
        }
    }
}
