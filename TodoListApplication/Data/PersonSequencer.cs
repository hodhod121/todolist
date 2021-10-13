using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApplication.Data
{
     class PersonSequencer
    {
        public static int personId { get; set; }
        public int nextPersonId()
        {
            return ++personId;
        }
        public static int reset()
        {
            personId = 0;
            return personId;
        }

    }
}
