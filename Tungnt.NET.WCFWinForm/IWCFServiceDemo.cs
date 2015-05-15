using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tungnt.NET.WCFWinForm
{
    [ServiceContract]
    public interface IWCFServiceDemo
    {
        /// <summary>
        /// Get All Students From Database: Static List
        /// </summary>
        /// <returns>List of Student</returns>
        /// @Created by tungnt.net - 5/2015
        [OperationContract]
        List<Student> GetStudents();

        /// <summary>
        /// Add New Student To Static List
        /// </summary>
        /// <param name="newStudent">New Student To Add</param>
        /// <returns>True/False - Success/Failed</returns>
        /// @Created by tungnt.net - 5/2015
        [OperationContract]
        Boolean AddStudent(Student newStudent);

        /// <summary>
        /// Update Student To Static List
        /// </summary>
        /// <param name="updateStudent">Student to update</param>
        /// <returns>True/False - Success/Failed</returns>
        /// @Created by tungnt.net - 5/2015
        [OperationContract]
        Boolean UpdateStudent(Student updateStudent);

        /// <summary>
        /// Delete Student From Static List
        /// </summary>
        /// <param name="studentID">StudentID to delete</param>
        /// <returns>True/False - Success/Failed</returns>
        /// @Created by tungnt.net - 5/2015
        [OperationContract]
        Boolean DeleteStudent(int studentID);
    }
}
