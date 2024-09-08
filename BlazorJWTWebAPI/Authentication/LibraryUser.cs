using Microsoft.AspNetCore.Identity;
using BlazorJWTWebAPI.DataAccess.Entities;

namespace BlazorJWTWebAPI.Authentication
{
    public class LibraryUser : IdentityUser
    {
        public bool RatingsAllowed { get; set; }
        public required ICollection<BookReview> Reviews { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiry { get; set; }
    }
}
