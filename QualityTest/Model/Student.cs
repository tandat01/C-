using System;

namespace QualityTest.Model
{
    public class Student
    {

        public string RollNumber;
        public string FullName;
        public DateTime Birthday;
        public string Email;
        public string Phone;
        public DateTime CreatedAt;
        public StudentStatus Status;
        public enum StudentStatus{
            Deactive=0,
            Active=1
        }

        public Student(string rollNumber, string fullName, DateTime birthday, string email, string phone, DateTime createdAt, StudentStatus status)
        {
            RollNumber = rollNumber;
            FullName = fullName;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            CreatedAt = createdAt;
            Status = status;
        }

        public bool IsNewStudent()
        {
            if (DateTime.Now.Subtract(this.CreatedAt).TotalDays <=60 )
            {
                return true;  
            }
            return false;
        }

        public bool IsDeactive()
        {
            
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
     
    }
    
    
}