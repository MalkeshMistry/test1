using System.Collections.ObjectModel;

namespace StudentCRUD.Models
{
    public class StudentDetails
    {
        public Collection<Student> Students { get; set; }
        public Collection<Student> Address { get; set; }
    }
}