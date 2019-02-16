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
        private List<double> _datalist = new List<double>();
        private double _mean;
        private double _standardDeviation;

        //constructors
        public Data()
        {
            //default list to avoid nullException error when 
            //class object is global
            _datalist = new List<double>(new double[10]);
        }
        public Data(List<double> datalist)
        {
            _datalist = datalist;
        }
        //properties
        public List<double> Datalist
        {
            get { return _datalist; }
            set { _datalist = value; }
        }
        public double Mean
        {
            get { return _mean; }
        }
        public double StandardDeviation
        {
            get { return _standardDeviation; }
        }

        //class methods
        public void CalculateProperties()
        {
            CalculateMean();
            CalculateSD();
        }
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
        public void RemoveValue(int index)
        {
            _datalist.RemoveAt(index);
        }
        public void AddValue(int index, double value)
        {
            _datalist.Insert(index, value);
        }
    }
}


// Add multiple lists to select from. 2-3 different lists?