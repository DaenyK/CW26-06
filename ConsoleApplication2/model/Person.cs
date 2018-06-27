using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.model
{
    public class Person : Human
    {
        readonly int m = 56;//  не меняется вообще кроме
        public Person()
        {
            m = 89; //readonly меняется только в конструкторе
        }



        public DateTime dob { get; set; }
        public int Age { get; set; }
        private int iin;

        public void HaveBrain()
        {
            Console.WriteLine(Brain);
        }
    }


    public class Human
    {
        public bool Brain { get; protected set; }
    }
}
