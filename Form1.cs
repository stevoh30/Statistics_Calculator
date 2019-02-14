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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            // Button creates a list of data
            string list = richTxtData.Text;
            Data d1 = new Data(ReturnList(list));

            foreach (int i in d1.Datalist)
            {
                richTxtDataDisplay.AppendText(i.ToString() + "\n");
            }
        }

        public List<int> ReturnList(string list)
        {
            // Parses the data string into a list
            string[] l1 = list.Split(' ');
            List<int> data = new List<int>();
            for(int i = 0; i <= l1.Length-1; i++)
            {
                data.Add(int.Parse(l1[i]));
            }
            return data;
        }

        private void btnDisplayList_Click(object sender, EventArgs e)
        {

        }
    }
}
