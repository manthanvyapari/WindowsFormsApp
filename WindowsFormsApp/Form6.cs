using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.dat" ,FileMode.Create, FileAccess.Write);
            try
            {

                Student std = new Student();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Marks = Convert.ToInt32(txtmarks.Text);
                std.Percentage = Convert.ToDouble(txtPercentage.Text);

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, std);
                fs.Close();
               
                MessageBox.Show("Student Record Adde to the file");
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.dat", FileMode.Open, FileAccess.Read);


                Student std = new Student();


                BinaryFormatter binaryFormatter = new BinaryFormatter();
                std = (Student)binaryFormatter.Deserialize(fs);
                fs.Close();
                txtid.Text = std.Id.ToString();
                txtname.Text =std.Name;
                txtmarks.Text = std.Marks.ToString();
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentXML.xml", FileMode.Create, FileAccess.Write);
            try
            {

                Student std = new Student();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Marks = Convert.ToInt32(txtmarks.Text);
                std.Percentage = Convert.ToDouble(txtPercentage.Text);

                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Student Record Added to the XML file");
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentXML.xml", FileMode.Open, FileAccess.Read);


                Student std = new Student();


                XmlSerializer xml = new XmlSerializer(typeof(Student));
                std = (Student)xml.Deserialize(fs);
                fs.Close();
                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtmarks.Text = std.Marks.ToString();
                txtPercentage.Text = std.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentSOAP.soap", FileMode.Create, FileAccess.Write);
            try
            {

                Student std = new Student();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Marks = Convert.ToInt32(txtmarks.Text);
                std.Percentage = Convert.ToDouble(txtPercentage.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Students record Added to the SOAP file");
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try

            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentSOAP.soap", FileMode.Open, FileAccess.Read);


                Student std = new Student();


                SoapFormatter soapFormatter = new SoapFormatter();
                std = (Student)soapFormatter.Deserialize(fs);
                fs.Close();
                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtmarks.Text = std.Marks.ToString();
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentJSON.json", FileMode.Create, FileAccess.Write);
            try
            {

                Student std = new Student();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Marks = Convert.ToInt32(txtmarks.Text);
                std.Percentage = Convert.ToDouble(txtPercentage.Text);

                JsonSerializer.Serialize<Student>(fs,std);


                fs.Close();
                MessageBox.Show("Student JSON RECORD ADDEDD TO THE FILE");
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentJSON.json", FileMode.Open, FileAccess.Read);


                Student std = new Student();


                std = JsonSerializer.Deserialize<Student>(fs);
                fs.Close();

                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtmarks.Text = std.Marks.ToString();
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtmarks.Clear();
            txtPercentage.Clear();
        }
    }
}
