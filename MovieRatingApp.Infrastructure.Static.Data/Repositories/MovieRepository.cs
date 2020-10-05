using MovieRatingApp.Core.DomainService;
using MovieRatingApp.Core.Entity;
using System;
using System.Collections.Generic;

namespace MovieRatingApp.Infrastructure.Static.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public IEnumerable<Rating> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
