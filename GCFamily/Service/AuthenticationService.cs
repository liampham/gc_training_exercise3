using GCFamily.Constants;
using GCFamily.DTO;
using GCFamily.Providers;
using GCFamily.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCFamily.Service

 {
    public  class AuthenticationService
    {

        public class AuthenticationResponse {
            private int resultCode;
            private string message;
            public AuthenticationResponse(int resultCode, string message)
            {
                this.ResultCode = resultCode;
                this.Message = message;
            }

            public int ResultCode { get => resultCode; set => resultCode = value; }
            public string Message { get => message; set => message = value; }
        }

        /*
         * Authenticate that user with given name and password has access permission for this app.
         * 
         * 
         */
        public static AuthenticationResponse Authenticate(string username, string password) {
            // Check if username or password is empty.
            if (Utils.isEmptyString(username) || Utils.isEmptyString(password)) {return new AuthenticationResponse(ResultCode.FAIL, Messages.EMPTY_INPUT);}
            
            // Check if account existed with given username
            Employee employee = DataProvider.GetInstance().getEmployee(username);
            if(employee == null)
            {
                return new AuthenticationResponse(ResultCode.FAIL, Messages.WRONG_PASSWORD_OR_NOT_EXIST_ACCOUNT);
            }

            // Check private key matching with given password
            if (!password.Equals(employee.PrivateKey))
            {
                return new AuthenticationResponse(ResultCode.FAIL, Messages.WRONG_PASSWORD_OR_NOT_EXIST_ACCOUNT);
            }

            return new AuthenticationResponse(ResultCode.SUCCESS,Messages.LOGIN_SUCCESS);
        }
    }
}
