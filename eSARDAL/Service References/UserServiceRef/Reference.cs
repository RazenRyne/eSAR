﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSARDAL.UserServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/eSARService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeactivatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTypeCodeField;
        
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
        public bool Deactivated {
            get {
                return this.DeactivatedField;
            }
            set {
                if ((this.DeactivatedField.Equals(value) != true)) {
                    this.DeactivatedField = value;
                    this.RaisePropertyChanged("Deactivated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserTypeCode {
            get {
                return this.UserTypeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTypeCodeField, value) != true)) {
                    this.UserTypeCodeField = value;
                    this.RaisePropertyChanged("UserTypeCode");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/eSARService")]
    [System.SerializableAttribute()]
    public partial class UserType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTypeCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsersTypeField;
        
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
        public string UserTypeCode {
            get {
                return this.UserTypeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTypeCodeField, value) != true)) {
                    this.UserTypeCodeField = value;
                    this.RaisePropertyChanged("UserTypeCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsersType {
            get {
                return this.UsersTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersTypeField, value) != true)) {
                    this.UsersTypeField = value;
                    this.RaisePropertyChanged("UsersType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceRef.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AuthenticateUser", ReplyAction="http://tempuri.org/IUserService/AuthenticateUserResponse")]
        eSARDAL.UserServiceRef.AuthenticateUserResponse AuthenticateUser(eSARDAL.UserServiceRef.AuthenticateUserRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AuthenticateUser", ReplyAction="http://tempuri.org/IUserService/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.AuthenticateUserResponse> AuthenticateUserAsync(eSARDAL.UserServiceRef.AuthenticateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUser", ReplyAction="http://tempuri.org/IUserService/GetUserResponse")]
        eSARDAL.UserServiceRef.User GetUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUser", ReplyAction="http://tempuri.org/IUserService/GetUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.User> GetUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateUser", ReplyAction="http://tempuri.org/IUserService/CreateUserResponse")]
        eSARDAL.UserServiceRef.CreateUserResponse CreateUser(eSARDAL.UserServiceRef.CreateUserRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateUser", ReplyAction="http://tempuri.org/IUserService/CreateUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.CreateUserResponse> CreateUserAsync(eSARDAL.UserServiceRef.CreateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        eSARDAL.UserServiceRef.UpdateUserResponse UpdateUser(eSARDAL.UserServiceRef.UpdateUserRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.UpdateUserResponse> UpdateUserAsync(eSARDAL.UserServiceRef.UpdateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
        eSARDAL.UserServiceRef.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeactivateUser", ReplyAction="http://tempuri.org/IUserService/DeactivateUserResponse")]
        eSARDAL.UserServiceRef.DeactivateUserResponse DeactivateUser(eSARDAL.UserServiceRef.DeactivateUserRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeactivateUser", ReplyAction="http://tempuri.org/IUserService/DeactivateUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.DeactivateUserResponse> DeactivateUserAsync(eSARDAL.UserServiceRef.DeactivateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ActivateUser", ReplyAction="http://tempuri.org/IUserService/ActivateUserResponse")]
        eSARDAL.UserServiceRef.ActivateUserResponse ActivateUser(eSARDAL.UserServiceRef.ActivateUserRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ActivateUser", ReplyAction="http://tempuri.org/IUserService/ActivateUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.ActivateUserResponse> ActivateUserAsync(eSARDAL.UserServiceRef.ActivateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        eSARDAL.UserServiceRef.DeleteUserResponse DeleteUser(eSARDAL.UserServiceRef.DeleteUserRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.DeleteUserResponse> DeleteUserAsync(eSARDAL.UserServiceRef.DeleteUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUserTypes", ReplyAction="http://tempuri.org/IUserService/GetAllUserTypesResponse")]
        eSARDAL.UserServiceRef.UserType[] GetAllUserTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUserTypes", ReplyAction="http://tempuri.org/IUserService/GetAllUserTypesResponse")]
        System.Threading.Tasks.Task<eSARDAL.UserServiceRef.UserType[]> GetAllUserTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetCurrentSy", ReplyAction="http://tempuri.org/IUserService/GetCurrentSyResponse")]
        string GetCurrentSy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetCurrentSy", ReplyAction="http://tempuri.org/IUserService/GetCurrentSyResponse")]
        System.Threading.Tasks.Task<string> GetCurrentSyAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public AuthenticateUserRequest() {
        }
        
        public AuthenticateUserRequest(string username, string password, string message) {
            this.username = username;
            this.password = password;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool AuthenticateUserResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public AuthenticateUserResponse() {
        }
        
        public AuthenticateUserResponse(bool AuthenticateUserResult, string message) {
            this.AuthenticateUserResult = AuthenticateUserResult;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public eSARDAL.UserServiceRef.User user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public CreateUserRequest() {
        }
        
        public CreateUserRequest(eSARDAL.UserServiceRef.User user, string message) {
            this.user = user;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CreateUserResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public eSARDAL.UserServiceRef.User user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public CreateUserResponse() {
        }
        
        public CreateUserResponse(bool CreateUserResult, eSARDAL.UserServiceRef.User user, string message) {
            this.CreateUserResult = CreateUserResult;
            this.user = user;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public eSARDAL.UserServiceRef.User user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateUserRequest() {
        }
        
        public UpdateUserRequest(eSARDAL.UserServiceRef.User user, string message) {
            this.user = user;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateUserResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public eSARDAL.UserServiceRef.User user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public UpdateUserResponse() {
        }
        
        public UpdateUserResponse(bool UpdateUserResult, eSARDAL.UserServiceRef.User user, string message) {
            this.UpdateUserResult = UpdateUserResult;
            this.user = user;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeactivateUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeactivateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public DeactivateUserRequest() {
        }
        
        public DeactivateUserRequest(int userId, string message) {
            this.userId = userId;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeactivateUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeactivateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool DeactivateUserResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public DeactivateUserResponse() {
        }
        
        public DeactivateUserResponse(bool DeactivateUserResult, string message) {
            this.DeactivateUserResult = DeactivateUserResult;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ActivateUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ActivateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public ActivateUserRequest() {
        }
        
        public ActivateUserRequest(int userId, string message) {
            this.userId = userId;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ActivateUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ActivateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool ActivateUserResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public ActivateUserResponse() {
        }
        
        public ActivateUserResponse(bool ActivateUserResult, string message) {
            this.ActivateUserResult = ActivateUserResult;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeleteUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public DeleteUserRequest() {
        }
        
        public DeleteUserRequest(int userId, string message) {
            this.userId = userId;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeleteUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool DeleteUserResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public DeleteUserResponse() {
        }
        
        public DeleteUserResponse(bool DeleteUserResult, string message) {
            this.DeleteUserResult = DeleteUserResult;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : eSARDAL.UserServiceRef.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<eSARDAL.UserServiceRef.IUserService>, eSARDAL.UserServiceRef.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSARDAL.UserServiceRef.AuthenticateUserResponse eSARDAL.UserServiceRef.IUserService.AuthenticateUser(eSARDAL.UserServiceRef.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUser(request);
        }
        
        public bool AuthenticateUser(string username, string password, ref string message) {
            eSARDAL.UserServiceRef.AuthenticateUserRequest inValue = new eSARDAL.UserServiceRef.AuthenticateUserRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.message = message;
            eSARDAL.UserServiceRef.AuthenticateUserResponse retVal = ((eSARDAL.UserServiceRef.IUserService)(this)).AuthenticateUser(inValue);
            message = retVal.message;
            return retVal.AuthenticateUserResult;
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.AuthenticateUserResponse> AuthenticateUserAsync(eSARDAL.UserServiceRef.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUserAsync(request);
        }
        
        public eSARDAL.UserServiceRef.User GetUser(string username) {
            return base.Channel.GetUser(username);
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.User> GetUserAsync(string username) {
            return base.Channel.GetUserAsync(username);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSARDAL.UserServiceRef.CreateUserResponse eSARDAL.UserServiceRef.IUserService.CreateUser(eSARDAL.UserServiceRef.CreateUserRequest request) {
            return base.Channel.CreateUser(request);
        }
        
        public bool CreateUser(ref eSARDAL.UserServiceRef.User user, ref string message) {
            eSARDAL.UserServiceRef.CreateUserRequest inValue = new eSARDAL.UserServiceRef.CreateUserRequest();
            inValue.user = user;
            inValue.message = message;
            eSARDAL.UserServiceRef.CreateUserResponse retVal = ((eSARDAL.UserServiceRef.IUserService)(this)).CreateUser(inValue);
            user = retVal.user;
            message = retVal.message;
            return retVal.CreateUserResult;
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.CreateUserResponse> CreateUserAsync(eSARDAL.UserServiceRef.CreateUserRequest request) {
            return base.Channel.CreateUserAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSARDAL.UserServiceRef.UpdateUserResponse eSARDAL.UserServiceRef.IUserService.UpdateUser(eSARDAL.UserServiceRef.UpdateUserRequest request) {
            return base.Channel.UpdateUser(request);
        }
        
        public bool UpdateUser(ref eSARDAL.UserServiceRef.User user, ref string message) {
            eSARDAL.UserServiceRef.UpdateUserRequest inValue = new eSARDAL.UserServiceRef.UpdateUserRequest();
            inValue.user = user;
            inValue.message = message;
            eSARDAL.UserServiceRef.UpdateUserResponse retVal = ((eSARDAL.UserServiceRef.IUserService)(this)).UpdateUser(inValue);
            user = retVal.user;
            message = retVal.message;
            return retVal.UpdateUserResult;
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.UpdateUserResponse> UpdateUserAsync(eSARDAL.UserServiceRef.UpdateUserRequest request) {
            return base.Channel.UpdateUserAsync(request);
        }
        
        public eSARDAL.UserServiceRef.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSARDAL.UserServiceRef.DeactivateUserResponse eSARDAL.UserServiceRef.IUserService.DeactivateUser(eSARDAL.UserServiceRef.DeactivateUserRequest request) {
            return base.Channel.DeactivateUser(request);
        }
        
        public bool DeactivateUser(int userId, ref string message) {
            eSARDAL.UserServiceRef.DeactivateUserRequest inValue = new eSARDAL.UserServiceRef.DeactivateUserRequest();
            inValue.userId = userId;
            inValue.message = message;
            eSARDAL.UserServiceRef.DeactivateUserResponse retVal = ((eSARDAL.UserServiceRef.IUserService)(this)).DeactivateUser(inValue);
            message = retVal.message;
            return retVal.DeactivateUserResult;
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.DeactivateUserResponse> DeactivateUserAsync(eSARDAL.UserServiceRef.DeactivateUserRequest request) {
            return base.Channel.DeactivateUserAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSARDAL.UserServiceRef.ActivateUserResponse eSARDAL.UserServiceRef.IUserService.ActivateUser(eSARDAL.UserServiceRef.ActivateUserRequest request) {
            return base.Channel.ActivateUser(request);
        }
        
        public bool ActivateUser(int userId, ref string message) {
            eSARDAL.UserServiceRef.ActivateUserRequest inValue = new eSARDAL.UserServiceRef.ActivateUserRequest();
            inValue.userId = userId;
            inValue.message = message;
            eSARDAL.UserServiceRef.ActivateUserResponse retVal = ((eSARDAL.UserServiceRef.IUserService)(this)).ActivateUser(inValue);
            message = retVal.message;
            return retVal.ActivateUserResult;
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.ActivateUserResponse> ActivateUserAsync(eSARDAL.UserServiceRef.ActivateUserRequest request) {
            return base.Channel.ActivateUserAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSARDAL.UserServiceRef.DeleteUserResponse eSARDAL.UserServiceRef.IUserService.DeleteUser(eSARDAL.UserServiceRef.DeleteUserRequest request) {
            return base.Channel.DeleteUser(request);
        }
        
        public bool DeleteUser(int userId, ref string message) {
            eSARDAL.UserServiceRef.DeleteUserRequest inValue = new eSARDAL.UserServiceRef.DeleteUserRequest();
            inValue.userId = userId;
            inValue.message = message;
            eSARDAL.UserServiceRef.DeleteUserResponse retVal = ((eSARDAL.UserServiceRef.IUserService)(this)).DeleteUser(inValue);
            message = retVal.message;
            return retVal.DeleteUserResult;
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.DeleteUserResponse> DeleteUserAsync(eSARDAL.UserServiceRef.DeleteUserRequest request) {
            return base.Channel.DeleteUserAsync(request);
        }
        
        public eSARDAL.UserServiceRef.UserType[] GetAllUserTypes() {
            return base.Channel.GetAllUserTypes();
        }
        
        public System.Threading.Tasks.Task<eSARDAL.UserServiceRef.UserType[]> GetAllUserTypesAsync() {
            return base.Channel.GetAllUserTypesAsync();
        }
        
        public string GetCurrentSy() {
            return base.Channel.GetCurrentSy();
        }
        
        public System.Threading.Tasks.Task<string> GetCurrentSyAsync() {
            return base.Channel.GetCurrentSyAsync();
        }
    }
}
