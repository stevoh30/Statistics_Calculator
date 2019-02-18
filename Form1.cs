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
        Data data2 = new Data();

        public Form1()
        {
            InitializeComponent();
        }

        // Button creates a list of data
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            try{
                string list = richTxtData.Text;
                if (radioBtnCList1.Checked == true)
                {
                    data.Datalist = (ReturnList(list));
                    DisplayValues(data);
                }
                else if(radioBtnCList2.Checked == true)
                {
                    data2.Datalist = (ReturnList(list));
                    DisplayValues(data2);
                }
                tabControl.SelectedTab = tabPage2;
                richTxtData.Clear();
            }
            catch{
                MessageBox.Show("No data to create list!");
            }
        }

        // Method parses the data string into a list
        public List<double> ReturnList(string list)
        {
            string[] l1 = list.Split(' ');
            List<double> data = new List<double>();
            for(int i = 0; i <= l1.Length-1; i++)
            {
                data.Add(Convert.ToDouble(l1[i]));
            }
            return data;
        }

        // Button adds user value into selected index
        private void btnAddValue_Click(object sender, EventArgs e)
        {
            if(radioBtnSelect1.Checked == true)
                AddValue(data);
            else if(radioBtnSelect2.Checked==true)
                AddValue(data2);
        }
        public void AddValue(Data d)
        {
            double value = Convert.ToDouble(txtAddValue.Text);
            if (d == data)
                data.AddValue(listBox1.SelectedIndex, value);
            else
                data2.AddValue(listBox2.SelectedIndex, value);
            DisplayValues(d);
        }

        // Method displays values in list of Data class object
        public void DisplayValues(Data d)
        {
            if (d == data)
            {
                listBox1.Items.Clear();
                foreach (double i in d.Datalist)
                {
                    listBox1.Items.Add(i);
                }
            }
            else if(d == data2)
            {
                listBox2.Items.Clear();
                foreach (double i in d.Datalist)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        // Button displays properties of list in Data class object
        private void btnDispAvg_Click(object sender, EventArgs e)
        {
            if (radioBtnDisplay1.Checked == true)
                DisplayProperties(data);
            else
                DisplayProperties(data2);
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
            int index = listBox1.SelectedIndex;
            data.RemoveValue(index);
            DisplayValues(data);
        }
    }
}


//Fix the add values method to target specific list based off selection
//Add functionality to remove value button (same as add value)
//Display list properties based on selected list radio button
//Add functionality to delete button