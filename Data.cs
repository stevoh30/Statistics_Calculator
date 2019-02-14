using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics_Calculator
{
    public class Data
    {
        //fields
        private List<int> _datalist = new List<int>();
        private double _mean;

        //constructor
        public Data(List<int> datalist)
        {
            _datalist = datalist;
        }
        //property
        public List<int> Datalist
        {
            get
            {
                return _datalist;
            }
        } 

        //test methods
        
    }
}
