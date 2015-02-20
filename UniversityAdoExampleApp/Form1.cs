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
        private FormUpdateHelper fh;

        public Form1()
        {
            InitializeComponent();

            da = new DataAccess(ConfigurationManager.ConnectionStrings["UniversityConnection"].ConnectionString);
            fh = new FormUpdateHelper(da);

            showTableGrid.DataSource = da.GetTable("Groups");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTableGrid.Columns[0].Visible = false;
            adjustWorkTable();
            workingGrid.Columns[0].Visible = false;
            tableComboBox.Text = "Groups";
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTable();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (fh.isValidDataEntered(workingGrid))
            {
                int result = fh.addRows(tableComboBox.Text, workingGrid);
                showTable();
                MessageBox.Show(
                    String.Format(Properties.Resources.M_AFFECTED_ROWS, result));
            }
            else
            {
                MessageBox.Show(Properties.Resources.M_CELLS_MUST_BE_NOT_EMPTY);
            }
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.M_DELETE_CONFIRM_TEXT,
                        Properties.Resources.M_DELETE_CONFIRM_HEADER,
                        MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int affRows = fh.deleteRow(tableComboBox.Text,
                        int.Parse(showTableGrid.CurrentRow.Cells[0].Value.ToString()));
                showTable();
                MessageBox.Show( 
                    String.Format(Properties.Resources.M_AFFECTED_ROWS, affRows) );
            }
        }

        private void changeSelectedButton_Click(object sender, EventArgs e)
        {
            if (!fh.isInChangeList(workingGrid, showTableGrid.CurrentRow.Cells[0].Value))
            {
                workingGrid.Rows.Add(fh.CloneWithValues(showTableGrid.CurrentRow));
            }
            workingGrid.AllowUserToAddRows = false;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (fh.isValidDataEntered(workingGrid))
            {
                int result = fh.updateRows(tableComboBox.Text, workingGrid);
                showTable();
                MessageBox.Show(
                    String.Format(Properties.Resources.M_AFFECTED_ROWS, result));
            }
            else
            {
                MessageBox.Show(Properties.Resources.M_CELLS_MUST_BE_NOT_EMPTY);
            }
        }

        private void showIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showTableGrid.Columns[0].Visible = showIdCheckBox.Checked;
            workingGrid.Columns[0].Visible = showIdCheckBox.Checked;
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTableGrid.DataSource = da.GetGroupsForSubject(fh.GetIdFromString(subjectComboBox.Text));
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                showTableGrid.DataSource = da.GetSubjectsForGroup(fh.GetIdFromString(groupComboBox.Text));
        }

        /// <summary>
        /// Adjusts workingDataGridView to some template.
        /// Template depends on current table.
        /// </summary>
        private void adjustWorkTable()
        {
            workingGrid.Columns.Clear();

            workingGrid.ColumnCount = showTableGrid.ColumnCount;

            //Set headers for workingGrid
            for (int i = 0; i < workingGrid.ColumnCount; i++)
			{
                workingGrid.Columns[i].HeaderText = showTableGrid.Columns[i].HeaderText;
			}

            switch (tableComboBox.Text)
            {
                case "Students":
                    workingGrid.ColumnCount -= 1;
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

        /// <summary>
        /// Shows a table, with some pre-work.
        /// Table name is set from comboBox.
        /// </summary>
        private void showTable()
        {
            if (!changeSelectedButton.Enabled)
            {
                changeSelectedButton.Enabled = true;
                saveChangeButton.Enabled = true;
            }

            groupToSubjectPanel.Visible = false;
            showTableGrid.DataSource = da.GetTable(tableComboBox.Text);

            if (tableComboBox.Text == "GroupToSubject")
            {
                changeSelectedButton.Enabled = saveChangeButton.Enabled = false;
                groupToSubjectPanel.Visible = true;
                groupComboBox.DataSource = fh.getRelationComboBox("Groups").Items;
                subjectComboBox.DataSource = fh.getRelationComboBox("Subjects").Items;
            }

            workingGrid.AllowUserToAddRows = true;

            adjustWorkTable();
        }

    }
}
