namespace CollegeApp.Model
{
    public static class Collegerepository
    {
        public static List<Student> GetAllStudents { get; set; }= new List<Student>()
        {
            
                new Student
                {
                    id = 1, StudentName = "John Doe", StudentEmail = "john@gmail.com", StudentPhone = "1234567890"
                },
                new Student
                {
                    id = 2, StudentName = "Jane Smith", StudentEmail = "jane@gmail.com", StudentPhone = "0987654321"
                }
         };
     }
}


