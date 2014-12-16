using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApps
{
    public partial class Form1 : Form
    {
        private string afile = @"E:\employee";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = enterNameTextBox.Text;
            string id = idTextBox.Text;
            string amount = salaryAmountTextBox.Text;

            string alldata = name + "," + id + "," + amount;

            FileStream aFileStream = new FileStream(afile, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(alldata);
            enterNameTextBox.Text = String.Empty;
            idTextBox.Text = String.Empty;
            salaryAmountTextBox.Text = String.Empty;
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aStreamWriter.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(afile, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            showListBox.Items.Clear();
           double totalSalary = 0;
            while (!aStreamReader.EndOfStream)
            {
                string allData = aStreamReader.ReadLine();
                showListBox.Items.Add(allData);

                string[] empInfo = allData.Split(',');
                totalSalary += Convert.ToDouble(empInfo[2]);
            }
            totalAmountTextBox.Text = totalSalary.ToString();
            aStreamReader.Close();
        }
    }
}
