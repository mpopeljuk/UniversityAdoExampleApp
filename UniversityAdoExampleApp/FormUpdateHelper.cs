using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace UniversityAdoExampleApp
{
    class FormUpdateHelper
    {
        private DataAccess da;

        public FormUpdateHelper(DataAccess _da)
        {
            da = _da;
        }

        public DataGridViewComboBoxColumn getRelationComboBox(string tableName)
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            if (tableName == "Groups" || tableName == "Subjects")
            {
                cmb.HeaderText = "Select " + tableName;

                DataTable dt = da.GetIdNameVals(tableName);

                foreach (DataRow item in dt.Rows)
                {
                    cmb.Items.Add(item["Id"] + "," + item["Name"]);
                }
                    
            }
            else
            {
                cmb.HeaderText = "Empty";
            }

            cmb.FlatStyle = FlatStyle.Flat;
            return cmb;
        }


        public int GetIdFromString(string s)
        {
            int result;

            string[] splitted = s.Split(',');

            if (!int.TryParse(splitted[splitted.Length - 1], out result))
            {
                result = 0;
            }

            return result;
        } 
    }
}
