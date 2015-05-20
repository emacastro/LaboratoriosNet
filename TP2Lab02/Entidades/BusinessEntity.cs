using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        enum States
        {
            New,
            Modified,
            Unmodified,
            Deleted
        }

        public int ID { get; set; }
        public States State { get;set;}

        public BusinessEntity()
        {
            this.State = States.New;
        }
    }
}
