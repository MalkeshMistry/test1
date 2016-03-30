
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace StudentCRUD.Models
{
    public class StudentMain
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ToString());

      
        public string AddStudent(Student student)
        {
            string query = "insert into Student (FirstName,LastName,Standard)"
                           + "values(@FirstName,@LastName,@Standard)";

            con.Execute(query, new { student.FirstName, student.LastName, student.Standard });

            return "Success";
        }

        public IEnumerable<Student> GetAllStudent()
        {
            string query = "select * from Student";
            return con.Query<Student>(query);
        }

        public Student GetStudent(string studentId)
        {
            string query = "Select * from Student where StudentID = " + studentId;
            return con.Query<Student>(query).Single<Student>();
        }

        public string UpdateStudent(Student student)
        {
            string query = "update Student set FirstName = @FirstName,LastName = @LastName,Standard = @Standard"
                           + " Where StudentID = @StudentID";
            con.Execute(query, new { student.FirstName, student.LastName, student.Standard, student.StudentID });
            return "Updated";
        }

        public string DeleteStudent(Student student)
        {
            string query = "Delete from student where Student.StudentID = @StudentID";
            con.Execute(query, new { student.StudentID });
            return "Deleted";
        }

        //public StudentDetails GetStudentDetails(string studentId)
        //{
        //    StudentDetails studentDetails = new StudentDetails();
        //    string query = "select * from student where StudentID = @StudentID ; select * from Address where StudentID = @StudentID";
        //    using (var multipleResult = con.QueryMultiple(query, new { studentId }))
        //    {
        //        var kk = multipleResult()
        //        studentDetails.Students = multipleResult.Read<Student>.SingleOrDefault();
        //        studentDetails.Address = multipleResult.Read<Address>().ToList();
        //    }
        //    return studentDetails;
        //}
    }

}