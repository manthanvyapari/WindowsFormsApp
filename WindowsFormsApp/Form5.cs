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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFormsApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Basicsalary_Click(object sender, EventArgs e)
        {

        }

        private void Employename_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employeid_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);
            try
            {

                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToInt32(txtsalary.Text);

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("EMPLOYEE RECORD ADDEDD TO THE FILE");
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);


                Employee emp = new Employee();


                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.ID.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
            try
            {

                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToInt32(txtsalary.Text);

                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("EMPLOYEE RECORD ADDEDD TO THE FILE");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);


                Employee emp = new Employee();


                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.ID.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
            try
            {

                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToInt32(txtsalary.Text);

                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("EMPLOYEE XML RECORD ADDEDD TO THE FILE");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeXML.xml", FileMode.Open, FileAccess.Read);


                Employee emp = new Employee();


                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.ID.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
            try
            {

                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToInt32(txtsalary.Text);

                JsonSerializer.Serialize<Employee>(fs, emp);


                fs.Close();
                MessageBox.Show("EMPLOYEE JSON RECORD ADDEDD TO THE FILE");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeJSON.json", FileMode.Open, FileAccess.Read);


                Employee emp = new Employee();


                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                txtid.Text = emp.ID.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

