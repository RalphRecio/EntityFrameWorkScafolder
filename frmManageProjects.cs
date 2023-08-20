using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWorkScafolder
{
    public partial class frmManageProjects : Form
    {
        public frmManageProjects()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var currDir = Directory.GetCurrentDirectory();
            var temppath = Path.Combine(currDir, Path.Combine("Data", "localData.txt"));

            // Define the data to be saved
            string dataToSave = "\n"+textBox2.Text + ";"+ textBox1.Text + ";" + txtserver.Text +";" + txtdatabase.Text +";" + txtusername.Text+";" + txtpassword.Text;

            // Write the data to the file
            File.AppendAllText(temppath, dataToSave);


            MessageBox.Show("Save successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dotnet ef dbcontext scaffold "data source=core.private.fast.com.ph;initial catalog=COREDB;user id=empviewuser;password=empviewpassword;TrustServerCertificate=True;MultipleActiveResultSets=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models2
            DialogResult result = folderBrowserDialog1.ShowDialog();
            // If the user selected a folder and clicked OK
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                // The selected folder path can be accessed using the SelectedPath property
                string folderPath = folderBrowserDialog1.SelectedPath;

                textBox1.Text = folderPath;
            }
        }

        private void frmManageProjects_Load(object sender, EventArgs e)
        {
           DataGridView dataGridView1 = new DataGridView();


           // dataGridView1.Rows.Add("asd", "asd", "asds");
        }
    }
}
