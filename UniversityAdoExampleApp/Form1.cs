using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Configuration;

namespace UniversityAdoExampleApp
{
    public partial class Form1 : Form
    {
        private DataAccess da;

        public Form1()
        {
            InitializeComponent();

            da = new DataAccess(ConfigurationManager.ConnectionStrings["UniversityConnection"].ConnectionString);
            dataGridView1.DataSource = da.GetTable("Groups");
            //dfgdfgdfgdfg
        }
    }
}
