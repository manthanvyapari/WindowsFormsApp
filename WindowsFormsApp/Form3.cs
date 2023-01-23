using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {

            string path = @"C:\SkillMineDoc";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\SkillMineDoc\manthan.text";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {

            string path = @"C:\SkillMineDoc\manthan.text";

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File is Deleted");
                }
                else
                {

                    MessageBox.Show("File is Not Found");

                }       
                        
                       
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\vyapari.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtid.Text));
                bw.Write(txtname.Text);
                bw.Write(Convert.ToDouble(txtsalary.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data save to File");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\vyapari.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtsalary.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirectoryInfo_Click(object sender, EventArgs e)
        {
           
            
                DirectoryInfo info = new DirectoryInfo(@"C:\SkillMineDoc");

                try
                {
                    if (info.Exists)
                    {
                        MessageBox.Show("Directory is already exists");
                    }
                    else
                    {
                        info.Create();
                        MessageBox.Show("Directory created..");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

        }

        private void btnFileinfo_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(@"C:\SkillMineDoc\manthan.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    fileinfo.Create();
                    MessageBox.Show("File created");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(@"C:\SkillMineDoc\manthan.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    fileinfo.Delete();
                    MessageBox.Show("File has been removed");
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

    

