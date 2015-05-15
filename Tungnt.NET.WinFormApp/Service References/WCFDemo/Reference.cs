﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tungnt.NET.WinFormApp.WCFDemo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/Tungnt.NET.WCFWinForm")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProfessionalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Class {
            get {
                return this.ClassField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassField, value) != true)) {
                    this.ClassField = value;
                    this.RaisePropertyChanged("Class");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Professional {
            get {
                return this.ProfessionalField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfessionalField, value) != true)) {
                    this.ProfessionalField = value;
                    this.RaisePropertyChanged("Professional");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFDemo.IWCFServiceDemo")]
    public interface IWCFServiceDemo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/GetStudents", ReplyAction="http://tempuri.org/IWCFServiceDemo/GetStudentsResponse")]
        Tungnt.NET.WinFormApp.WCFDemo.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/GetStudents", ReplyAction="http://tempuri.org/IWCFServiceDemo/GetStudentsResponse")]
        System.Threading.Tasks.Task<Tungnt.NET.WinFormApp.WCFDemo.Student[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/AddStudent", ReplyAction="http://tempuri.org/IWCFServiceDemo/AddStudentResponse")]
        bool AddStudent(Tungnt.NET.WinFormApp.WCFDemo.Student newStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/AddStudent", ReplyAction="http://tempuri.org/IWCFServiceDemo/AddStudentResponse")]
        System.Threading.Tasks.Task<bool> AddStudentAsync(Tungnt.NET.WinFormApp.WCFDemo.Student newStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/UpdateStudent", ReplyAction="http://tempuri.org/IWCFServiceDemo/UpdateStudentResponse")]
        bool UpdateStudent([System.ServiceModel.MessageParameterAttribute(Name="updateStudent")] Tungnt.NET.WinFormApp.WCFDemo.Student updateStudent1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/UpdateStudent", ReplyAction="http://tempuri.org/IWCFServiceDemo/UpdateStudentResponse")]
        System.Threading.Tasks.Task<bool> UpdateStudentAsync(Tungnt.NET.WinFormApp.WCFDemo.Student updateStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/DeleteStudent", ReplyAction="http://tempuri.org/IWCFServiceDemo/DeleteStudentResponse")]
        bool DeleteStudent(int studentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFServiceDemo/DeleteStudent", ReplyAction="http://tempuri.org/IWCFServiceDemo/DeleteStudentResponse")]
        System.Threading.Tasks.Task<bool> DeleteStudentAsync(int studentID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFServiceDemoChannel : Tungnt.NET.WinFormApp.WCFDemo.IWCFServiceDemo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFServiceDemoClient : System.ServiceModel.ClientBase<Tungnt.NET.WinFormApp.WCFDemo.IWCFServiceDemo>, Tungnt.NET.WinFormApp.WCFDemo.IWCFServiceDemo {
        
        public WCFServiceDemoClient() {
        }
        
        public WCFServiceDemoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFServiceDemoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceDemoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceDemoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Tungnt.NET.WinFormApp.WCFDemo.Student[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<Tungnt.NET.WinFormApp.WCFDemo.Student[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
        
        public bool AddStudent(Tungnt.NET.WinFormApp.WCFDemo.Student newStudent) {
            return base.Channel.AddStudent(newStudent);
        }
        
        public System.Threading.Tasks.Task<bool> AddStudentAsync(Tungnt.NET.WinFormApp.WCFDemo.Student newStudent) {
            return base.Channel.AddStudentAsync(newStudent);
        }
        
        public bool UpdateStudent(Tungnt.NET.WinFormApp.WCFDemo.Student updateStudent1) {
            return base.Channel.UpdateStudent(updateStudent1);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStudentAsync(Tungnt.NET.WinFormApp.WCFDemo.Student updateStudent) {
            return base.Channel.UpdateStudentAsync(updateStudent);
        }
        
        public bool DeleteStudent(int studentID) {
            return base.Channel.DeleteStudent(studentID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStudentAsync(int studentID) {
            return base.Channel.DeleteStudentAsync(studentID);
        }
    }
}
