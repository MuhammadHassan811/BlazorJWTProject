using BlazorJWTWebAPI.DataAccess.Entities;

namespace BlazorJWTWebAPI.DataAccess.Repositories
{
    public interface IReviewRepository
    {
        public IQueryable<BookReview> AllReviews { get; }

        void Create(BookReview review);
        void Remove(BookReview result);
        void SaveChanges();
    }
}
