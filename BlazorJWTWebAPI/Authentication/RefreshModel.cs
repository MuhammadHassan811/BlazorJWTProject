﻿namespace BlazorJWTWebAPI.Authentication
{
    public class RefreshModel
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}
