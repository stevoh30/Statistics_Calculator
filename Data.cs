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
        private int _tempValue;
        private List<double> _datalist = new List<double>();
        private double _mean;
        private double _standardDeviation;
        private double _quartile1;
        private double _average;
        private double _quartile3;

        //constructors
        public Data()
        {
            //default list to avoid nullException error when 
            //class object is global
            _datalist = new List<double>(new double[0]);
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
        public double Average
        {
            get { return _average; }
        }
        public double Quartile1
        {
            get { return _quartile1; }
        }
        public double Quartile3
        {
            get { return _quartile3; }
        }

        //class methods
        public void CalculateProperties()
        {
            CalculateMean();
            CalculateSD();
            CalculateAverage();
            CalculateQuartile1();
            //CalculateQuartile3();
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
        public void CalculateAverage()
        {
            List<double> list = _datalist;
            list.Sort();
            _average = FindMidNumber(list);
        }
        public void CalculateQuartile1()
        {
            List<double> list = _datalist;
            for (int x = list.Count; x > _tempValue+1; x--)
            {
                list.RemoveAt(x-1);
            }
            _quartile1 = FindMidNumber(list);
        }
        //public void CalculateQuartile3()
        //{
        //    List<double> list = _datalist;
        //    for (int x = 0; x < _tempValue+1; x++)
        //    {
        //        list.RemoveAt(x);
        //    }
        //    _quartile3 = FindQuartiles(list);
        //}
        public double FindMidNumber(List<double> list)
        {
            double value = 0;
            int index = 0;
            int index2 = 0;
            if (list.Count % 2 != 0)
            {
                index = _datalist.Count/2;
                value = list[index];
                if (_tempValue == 0)
                {
                    _tempValue = index;//-1?
                }
            }
            else
            {
                index = _datalist.Count / 2-1;
                index2 = _datalist.Count / 2;
                value = Math.Round((list[index] + list[index2])/2, 2);
                //if (_tempValue == 0)
                //{
                //    _tempValue = index;
                //}
            }
            return value;
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