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
        private double _standardDeviation;

        //constructor
        public Data(List<int> datalist)
        {
            _datalist = datalist;
        }
        //property
        public List<int> Datalist
        {
            get { return _datalist; }
        }
        public double Mean
        {
            get { return _mean; }
        }
        public double StandardDeviation
        {
            get { return _standardDeviation; }
        }

        //test methods
        public void CalculateMean()
        {
            double total = 0;
            foreach(var i in _datalist)
            {
                total += i;
            }
            _mean = Math.Round(total /_datalist.Count(), 2);     
        }
        public void CalculateSD()
        {
            double total = 0;
            foreach (var i in _datalist)
            {
                total += Math.Pow(i - _mean, 2);
            }
            _standardDeviation = Math.Round(Math.Sqrt(total / (_datalist.Count()-1)),2);
        }
        
    }
}
