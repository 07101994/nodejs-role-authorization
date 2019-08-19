using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient.DataContracts
{
    public class AuthenticateUserRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
