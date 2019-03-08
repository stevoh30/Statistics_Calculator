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
            //error message if data already exists within a list based off
            //radio button selection.
            try{
                string list = richTxtData.Text;
                if (radioBtnCList1.Checked == true)
                {
                    if(data.Datalist.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("There is already a List 1, do you wish to overwrite?", 
                            "List 1 already exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            data.Datalist = (ReturnList(list));
                    }
                    else
                        data.Datalist = (ReturnList(list));
                }
                else if(radioBtnCList2.Checked == true)
                {
                    if (data2.Datalist.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("There is already a List 2, do you witsh to overwrite?", 
                            "List 2 already exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            data2.Datalist = (ReturnList(list));
                    }
                    else
                        data2.Datalist = (ReturnList(list));
                }
                //Switched selected tab and displays data values of lists
                DisplayValues(data);
                DisplayValues(data2);
                tabControl.SelectedTab = tabPage2;
                richTxtData.Clear();
            }
            catch{
                MessageBox.Show("There is either no data or an unneeded space within the data present.");
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
            try{
                if (radioBtnSelect1.Checked == true)
                    AddValue(data);
                else if (radioBtnSelect2.Checked == true)
                    AddValue(data2);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
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
            if (d == data){
                listBox1.Items.Clear();
                foreach (double i in d.Datalist)
                    listBox1.Items.Add(i);
            }
            else if(d == data2){
                listBox2.Items.Clear();
                foreach (double i in d.Datalist)
                    listBox2.Items.Add(i);
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
            richTxtDataDisplay.AppendText("Standard Deviation = " + data.StandardDeviation.ToString() + "\n");
            richTxtDataDisplay.AppendText("1st Quartile = " + data.Quartile1.ToString() + "\n");
            richTxtDataDisplay.AppendText("Average = " + data.Average.ToString() + "\n");
            //richTxtDataDisplay.AppendText("3rd Quartile = " + data.Quartile3.ToString() + "\n");
        }

        // Remove value from selected index of Data object
        private void btnRemoveValue_Click(object sender, EventArgs e)
        {
            try{
                if (radioBtnSelect1.Checked == true)
                    RemoveValue(data, listBox1.SelectedIndex);
                else if (radioBtnSelect2.Checked == true)
                    RemoveValue(data2, listBox2.SelectedIndex);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveValue(Data data, int index)
        {
            data.RemoveValue(index);
            DisplayValues(data);
        }
    }
}

//add functionality to delete list button