using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsApp
{
    public class Account 
    {
        public string Name { get; set; }
        private float currAmount;

        public string CurrentAmount 
        {
            get { return string.Format("{0:c}",currAmount); } 
            set {currAmount = Convert.ToSingle(value); }
        }
        public Account() { }

        public Account(string name, float currAmount)
        {
            Name = name;

            this.currAmount = currAmount;
        }
    }

}
