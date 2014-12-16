using CSVLib;
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

namespace StudentsCSV
{
    public partial class Form1 : Form
    {
       private String path = @"E:\StudentRecord.CSV";
        public Form1()
        {
            InitializeComponent();
        }
        
           
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            if (File.Exists(path))
            {
                FileStream aStream = new FileStream(path, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);

                List<String> regNo = new List<String>();
                while (aReader.ReadRow(regNo))
                {
                    string id = regNo[0];
                    if (regText.Text == id)
                    {
                        isvalid = false;
                        break;
                    }
                }
                aStream.Close();
            }
            if (isvalid)
            {
                FileStream bStream = new FileStream(path, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(bStream);

                List<string> aStudentRecord = new List<string>();
                aStudentRecord.Add(regText.Text);
                aStudentRecord.Add(nameText.Text);
                aWriter.WriteRow(aStudentRecord);
                bStream.Close();
            }
            else
            {
                MessageBox.Show("Duplicate Reg. No.");
            }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aStudentRecord = new List<string>();
            showText.Items.Clear();
            while (aReader.ReadRow(aStudentRecord))
            {
                string regNo = aStudentRecord[0];
                string name = aStudentRecord[1];
                showText.Items.Add(regNo + " " + name+ "\n");
            }
            aStream.Close();


        }

    }
}
