using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsApp.ViewModel
{
    class Acccounts_Manager
    {
        public Model.Account MainAccount { get; set; }
        public Model.Account[] Bills = new Model.Account[10];

        public Acccounts_Manager()
        {

            MainAccount = new Model.Account("Main",100.00f);


            for (int i = 0; i < Bills.Length; i++)
            {
                Bills[i] = new Model.Account(string.Format("Bill {0}", i), 0.00f);
            }
        }


    }
}
