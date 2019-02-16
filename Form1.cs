using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics_Calculator
{
    public partial class Form1 : Form
    {
        // need to fix this global class
        Data data = new Data();

        public Form1()
        {
            InitializeComponent();
        }

        // Button creates a list of data
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            string list = richTxtData.Text;
            data.Datalist = (ReturnList(list));
            richTxtData.Clear();
            tabControl.SelectedTab = tabPage2;
            DisplayValues(data);     
        }

        // Method parses the data string into a list
        public List<double> ReturnList(string list)
        {
            string[] l1 = list.Split(' ');
            List<double> data = new List<double>();
            for(int i = 0; i <= l1.Length-1; i++)
            {
                data.Add(double.Parse(l1[i]));
            }
            return data;
        }

        // Button adds user value into selected index
        private void btnAddValue_Click(object sender, EventArgs e)
        {
            AddValue(data);
        }
        public void AddValue(Data data)
        {
            double value = Convert.ToDouble(txtAddValue.Text);
            data.AddValue(listBox.SelectedIndex, value);
            DisplayValues(data);
        }

        // Method displays values in list of Data class object
        public void DisplayValues(Data data)
        {
            listBox.Items.Clear();
            foreach (double i in data.Datalist)
            {
                listBox.Items.Add(i);
            }
        }

        // Button displays properties of list in Data class object
        private void btnDispAvg_Click(object sender, EventArgs e)
        {
            DisplayProperties(data);
        }
        public void DisplayProperties(Data data)
        {
            richTxtDataDisplay.Clear();
            data.CalculateProperties();
            richTxtDataDisplay.AppendText("Mean = " + data.Mean.ToString() + "\n");
            richTxtDataDisplay.AppendText("Standard Deviation = " + data.StandardDeviation.ToString());
        }

        // Remove value from selected index of Data object
        private void btnRemoveValue_Click(object sender, EventArgs e)
        {
            RemoveValue(data);
        }
        private void RemoveValue(Data data)
        {
            int index = listBox.SelectedIndex;
            data.RemoveValue(index);
            DisplayValues(data);
        }
    }
}
