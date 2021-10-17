using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApplication.Data
{
     public class PersonSequencer
    {
        private static int personId;
        public static int nextPersonId()
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
