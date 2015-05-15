using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tungnt.NET.WCFWinForm
{
    /// <summary>
    /// Student Manager Demo Using WCF in Winform Application
    /// @Created by tungnt.net - 5/2015
    /// </summary>
    public class WCFServiceDemo : IWCFServiceDemo
    {
        //For demo purpose so we use a static list instead of database
        private static List<Student> studentList = new List<Student>() { new Student { StudentID = 1, StudentName = "Nguyễn Văn A", Class = "CNTT", Professional = "Công nghệ phần mềm" }, new Student { StudentID = 2, StudentName = "Nguyễn Văn B", Class = "ĐTVT", Professional = "Mạng máy tinh" } };

        public List<Student> GetStudents()
        {
            return studentList;
        }

        public bool AddStudent(Student newStudent)
        {
            bool Result = false;
            try
            {
                studentList.Add(newStudent);
                Result = true;
            }
            catch (Exception)
            {
                Result = false;
            }
            return Result;
        }

        public bool UpdateStudent(Student updateStudent)
        {
            bool Result = false;
            try
            {
                var originalStudent = studentList.Where(e => e.StudentID == updateStudent.StudentID).FirstOrDefault();
                if (originalStudent != null)
                {
                    studentList.Remove(originalStudent);
                    studentList.Add(updateStudent);
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }
            return Result;
        }

        public bool DeleteStudent(int studentID)
        {
            bool Result = false;
            try
            {
                var deleteStudent = studentList.Where(e => e.StudentID == studentID).FirstOrDefault();
                if (deleteStudent != null)
                {
                    studentList.Remove(deleteStudent);
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }
            return Result;
        }
    }
}
