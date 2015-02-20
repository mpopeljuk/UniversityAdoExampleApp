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
            showTableGrid.DataSource = da.GetTable("Groups");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTableGrid.Columns[0].Visible = false;
            adjustWorkTable();
            workingGrid.Columns[0].Visible = false;
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupToSubjectPanel.Visible = false;
            showTableGrid.DataSource = da.GetTable(tableComboBox.Text);

            if (tableComboBox.Text == "GroupToSubject")
            {
                groupToSubjectPanel.Visible = true;
            }
            adjustWorkTable();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void showIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showTableGrid.Columns[0].Visible = showIdCheckBox.Checked;
            workingGrid.Columns[0].Visible = showIdCheckBox.Checked;
        }

        /// <summary>
        /// Adjusts workingDataGridView to some template.
        /// Template depends on current table.
        /// </summary>
        private void adjustWorkTable()
        {
            workingGrid.Columns.Clear();

            workingGrid.ColumnCount = showTableGrid.ColumnCount;
            FormUpdateHelper fh = new FormUpdateHelper(da);

            switch (tableComboBox.Text)
            {
                case "Students":
                    workingGrid.Columns.Add(fh.getRelationComboBox("Groups"));
                    break;

                case "GroupToSubject":
                    workingGrid.ColumnCount = 1;
                    workingGrid.Columns.Add(fh.getRelationComboBox("Groups"));
                    workingGrid.Columns.Add(fh.getRelationComboBox("Subjects"));
                    break;

                default:
                    
                    break;
            }
            workingGrid.Columns[0].Visible = showIdCheckBox.Checked;
        }
    }
}
