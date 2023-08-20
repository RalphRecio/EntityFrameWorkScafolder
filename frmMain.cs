using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWorkScafolder
{

  
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        string path = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {

            button3.PerformClick();

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/k " + rchoutconnection.Text,
                WorkingDirectory = path
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };

            process.Start();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rchoutconnection_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chcktrustcert_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chcMultiActRes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            var forceScaffold = string.Empty;
            if (chckforce.Checked)
            {
                forceScaffold = " -f";
            }


            rchoutconnection.Text = "dotnet ef dbcontext scaffold \"data source=" + txtserver.Text
                + ";initial catalog=" + txtdatabase.Text
                + ";user id=" + txtusername.Text
                + ";password=" + txtpassword.Text
                + ";TrustServerCertificate=" + chcktrustcert.Checked.ToString()
                + ";MultipleActiveResultSets=" + chcMultiActRes.Checked + ";\" Microsoft.EntityFrameworkCore.SqlServer -o " + txtfldname.Text + forceScaffold;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManageProjects manageProj = new frmManageProjects();


            manageProj.ShowDialog();
        }

        List<ProjectCredentials> project = new List<ProjectCredentials>();

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            var currDir = Directory.GetCurrentDirectory();
            var temppath = Path.Combine(currDir, Path.Combine("Data", "localData.txt"));

            string dataFromFile = File.ReadAllText(temppath);



            var perlines = dataFromFile.Split("\n");

            foreach (var perline in perlines)
            {


                comboBox1.Items.Add(perline.Split(";")[0]);

                project.Add(new ProjectCredentials
                {
                    templatename = perline.Split(";")[0],
                    path = perline.Split(";")[1],
                    servername = perline.Split(";")[2],
                    database = perline.Split(";")[3],
                    username = perline.Split(";")[4],
                    password = perline.Split(";")[5],

                });
            }


            comboBox1.SelectedItem = project.Select(e => e.templatename).First().ToString();
            //textBox1.Text = project.Select(e => e.path).First().ToString();
            /*txtserver.Text = project.Select(e => e.servername).First().ToString();
            txtdatabase.Text = project.Select(e => e.database).First().ToString();
            txtusername.Text = project.Select(e => e.username).First().ToString();
            txtpassword.Text = project.Select(e => e.password).First().ToString();*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            path = project.Where(e => e.templatename == comboBox1.Text).Select(e => e.path).FirstOrDefault();
            txtserver.Text = project.Where(e => e.templatename == comboBox1.Text).Select(e => e.servername).FirstOrDefault();
            txtdatabase.Text = project.Where(e => e.templatename == comboBox1.Text).Select(e => e.database).FirstOrDefault();
            txtusername.Text = project.Where(e => e.templatename == comboBox1.Text).Select(e => e.username).FirstOrDefault();
            txtpassword.Text = project.Where(e => e.templatename == comboBox1.Text).Select(e => e.password).FirstOrDefault();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class ProjectCredentials
    {

        public string templatename { get; set; }
        public string path { get; set; }
        public string database { get; set; }
        public string servername { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
