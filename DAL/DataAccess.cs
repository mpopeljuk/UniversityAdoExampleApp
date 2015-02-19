using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        private string connString;

        public DataAccess(string conn)
        {
            connString = conn;
        }

        public DataTable GetTable(string tableName)
        {
            string query = string.Format("SELECT * FROM [{0}]", tableName);
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                var sqlCommand = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(dr);
            }
            return dt;
        }

        public int AddGroup(string name)
        {
            var insertGroup = "INSERT INTO Groups (Name) VALUES (@GROUP_NAME)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(insertGroup, conn);

                var parameter = new SqlParameter("@GROUP_NAME", SqlDbType.NVarChar);
                parameter.Value = name;

                sqlCommand.Parameters.Add(parameter);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int AddStudent(string firstName, string lastName, int age, int groupId)
        {
            var insertStudent = "INSERT INTO Students (FirstName, LastName, Age, GroupId) VALUES (@FIRST_NAME, @LAST_NAME, @AGE, @GROUP_ID)";
            var fnPar = new SqlParameter("@FIRST_NAME", SqlDbType.NVarChar);
            fnPar.Value = firstName;

            var lnPar = new SqlParameter("@FIRST_NAME", SqlDbType.NVarChar);
            lnPar.Value = lastName;

            var agePar = new SqlParameter("@AGE", SqlDbType.Int);
            agePar.Value = age;

            var gIdPar = new SqlParameter("@GROUP_ID", SqlDbType.Int);
            gIdPar.Value = groupId;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(insertStudent, conn);

                sqlCommand.Parameters.Add(fnPar);
                sqlCommand.Parameters.Add(lnPar);
                sqlCommand.Parameters.Add(age);
                sqlCommand.Parameters.Add(gIdPar);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int AddSubject(string name)
        {
            var insertSubj = "INSERT INTO Subjects (Name) VALUES (@SUBJ_NAME)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(insertSubj, conn);

                var parameter = new SqlParameter("@SUBJ_NAME", SqlDbType.NVarChar);
                parameter.Value = name;

                sqlCommand.Parameters.Add(parameter);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int AddGroupToSubject(int groupId, int subjectId)
        {
            var insertGtS = "INSERT INTO GroupToSubject (GroupId, SubjectId) VALUES (@GROUP_ID, @SUBJ_ID)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(insertGtS, conn);

                var grId = new SqlParameter("@GROUP_ID", SqlDbType.Int);
                grId.Value = groupId;

                var subjId = new SqlParameter("@GROUP_ID", SqlDbType.Int);
                subjId.Value = groupId;

                sqlCommand.Parameters.Add(grId);
                sqlCommand.Parameters.Add(subjId);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        /*public int DeleteRow(string tableName, string colName, dynamic colVal)
        {
            var insertSubj = "INSERT INTO Subjects (Name) VALUES (@SUBJ_NAME)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(insertSubj, conn);

                var parameter = new SqlParameter("@SUBJ_NAME", SqlDbType.NVarChar);
                parameter.Value = name;

                sqlCommand.Parameters.Add(parameter);

                return sqlCommand.ExecuteNonQuery();
            }
        }*/
    }
}
