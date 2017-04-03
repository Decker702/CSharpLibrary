using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModiifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                public: Access is not restricted.
             
                protected: Access is limited to the containing class or types derived from the containing class.

                Internal: Access is limited to the current assembly.

                protected internal: Access is limited to the current assembly or types derived from the containing class.

                private: Access is limited to the containing type.
             
             * /
            
            /******Keyword***************Applicable To***************Meaning******************************************		
             public 			    Class, Member			No restrictions
             protected			    Member					Access limited to the class and derived classes
             private		        Member					Access limited to the class.

             internal               Class, Member			Access limited to the current assembly		
             protected internal 	Member					Access limited to current assembly and derived types

            **********************************************************************************************************/






        }
    }
}
