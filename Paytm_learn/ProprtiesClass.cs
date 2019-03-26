using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paytm_learn
{
     class ProprtiesClass
    {
         private string _mobilenumber;
         private string _amount;
         public string Mobilenumber
         {
             get
             {
                 return _mobilenumber;
             }
             set
             {
                 _mobilenumber = "8296865364";
             }
         }
        public  string amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = "448";
            }
        }
    }
}
