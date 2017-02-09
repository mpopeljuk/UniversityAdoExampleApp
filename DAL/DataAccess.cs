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
		// Method to get table
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

                sqlCommand.Parameters.Add("@GROUP_NAME", SqlDbType.NVarChar).Value = name;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int AddStudent(string firstName, string lastName, 
                int age, int groupId)
        {
            var insertStudent = "INSERT INTO Students (FirstName, LastName, Age, GroupId)" +
                " VALUES (@FIRST_NAME, @LAST_NAME, @AGE, @GROUP_ID)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(insertStudent, conn);

                sqlCommand.Parameters.Add("@FIRST_NAME", SqlDbType.NVarChar).Value = firstName;
                sqlCommand.Parameters.Add("@LAST_NAME", SqlDbType.NVarChar).Value = lastName;
                sqlCommand.Parameters.Add("@AGE", SqlDbType.Int).Value = age;
                sqlCommand.Parameters.Add("@GROUP_ID", SqlDbType.Int).Value = groupId;

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

                sqlCommand.Parameters.Add("@SUBJ_NAME", SqlDbType.NVarChar).Value = name;

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

                sqlCommand.Parameters.Add("@GROUP_ID", SqlDbType.Int).Value = groupId;
                sqlCommand.Parameters.Add("@SUBJ_ID", SqlDbType.Int).Value = subjectId;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteGroupRecord(int groupId)
        {
            var deleteGroup = "DELETE FROM Groups WHERE Id = @GROUP_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(deleteGroup, conn);

                sqlCommand.Parameters.Add("@GROUP_ID", SqlDbType.Int).Value = groupId;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteStudentRecord(int studId)
        {
            var deleteStud = "DELETE FROM Students WHERE Id = @STUD_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(deleteStud, conn);

                sqlCommand.Parameters.Add("@STUD_ID", SqlDbType.Int).Value = studId;


                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteSubjectRecord(int subjId)
        {
            var deleteSubj = "DELETE FROM Subjects WHERE Id = @SUBJ_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(deleteSubj, conn);

                sqlCommand.Parameters.Add("@SUBJ_ID", SqlDbType.Int).Value = subjId;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteGroupToSubj(int rowId)
        {
            var deleteGtS = "DELETE FROM GroupToSubject WHERE Id = @ROW_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(deleteGtS, conn);

                sqlCommand.Parameters.Add("@ROW_ID", SqlDbType.Int).Value = rowId;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateGroupRecord(int groupId, string name)
        {
            var updateGroup = "UPDATE Groups " +
                        "SET Name = @NAME " +
                        "WHERE Id = @GROUP_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(updateGroup, conn);

                sqlCommand.Parameters.Add("@GROUP_ID", SqlDbType.Int).Value = groupId;
                sqlCommand.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = name;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateStudentRecord(int studId, string firstName, 
                string lastName, int age, int groupId)
        {
            var updateStudent = "UPDATE Students " +
                       "SET FirstName = @FIRST_NAME, LastName = @LAST_NAME, " +
                       "Age = @AGE, groupId = @GROUP_ID " +
                       "WHERE Id = @STUD_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(updateStudent, conn);

                sqlCommand.Parameters.Add("@FIRST_NAME", SqlDbType.NVarChar).Value = firstName;
                sqlCommand.Parameters.Add("@LAST_NAME", SqlDbType.NVarChar).Value = lastName;
                sqlCommand.Parameters.Add("@AGE", SqlDbType.Int).Value = age;
                sqlCommand.Parameters.Add("@GROUP_ID", SqlDbType.Int).Value = groupId;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateSubjectRecord(int subjId, string name)
        {
            var updateSubject = "UPDATE Subjects " +
                       "SET Name = @NAME " +
                       "WHERE Id = @SUBJ_ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var sqlCommand = new SqlCommand(updateSubject, conn);

                sqlCommand.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = name;
                
                return sqlCommand.ExecuteNonQuery();
            }
        }
        
        public DataTable GetIdNameVals(string tableName)
        {
            string query = string.Format("SELECT Id, Name FROM [{0}]", tableName);
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

        public DataTable GetSubjectsForGroup(int groupId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT gts.Id, s.Name " +
                    "FROM Groups g " +
                    "JOIN GroupToSubject gts ON g.Id = gts.GroupId " +
                    "JOIN Subjects s ON gts.SubjectId = s.Id " +
                    "WHERE g.Id = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                var sqlCommand = new SqlCommand(query, conn);

                conn.Open();

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = groupId;

                SqlDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(dr);
            }
            return dt;
        }

        public DataTable GetGroupsForSubject(int subjId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT gts.Id, g.Name " +
                    "FROM Groups g " +
                    "JOIN GroupToSubject gts ON g.Id = gts.GroupId " +
                    "JOIN Subjects s ON gts.SubjectId = s.Id " +
                    "WHERE s.Id = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                var sqlCommand = new SqlCommand(query, conn);

                conn.Open();

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = subjId;

                SqlDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(dr);
            }
            return dt;
        }

        /*public DataTable GetStudents()
        {
            string query = string.Format("SELECT s.FirstName, s.LastName, s.Age, g.Name " +
                    "FROM [Students] s " +
                    "JOIN Groups g ON s.GroupId = g.Id");
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                var sqlCommand = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(dr);
            }
            return dt;
        }*/
    }
}
