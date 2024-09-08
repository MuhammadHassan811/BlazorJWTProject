using BlazorJWTProject.Models;

namespace BlazorJWTProject.Services
{
    public interface IReviewRepository
    {
        Task<IEnumerable<BookReview>> GetReviewsAsync();
        Task<IEnumerable<BookReview>> GetReviewSummariesAsync();
    }
}
