﻿namespace RestApiClient.DataContracts
{
    public class UserDetail
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }
}
