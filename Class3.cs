using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_test
{
    abstract class Introduction
    {
        
        public virtual void Welcome()
        {
            Console.WriteLine("You are welcome");//It may be overridden or just inherited
        }
        public abstract void Thank_you();//It must be overriden
        
            
       
    }
}
