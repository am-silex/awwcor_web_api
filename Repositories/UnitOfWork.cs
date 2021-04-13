using awwcor_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awwcor_web_api.Repositories
{
    public class UnitOfWork
    {
        private readonly DatabaseContext _dbContext;
        private readonly AdsRepository<Ad> _ads;
        private readonly AdsRepository<Photo> _photo;

        public UnitOfWork(DatabaseContext DbContext)
        {
            _dbContext = DbContext;
            _ads = new AdsRepository<Ad>(_dbContext);
            _photo = new AdsRepository<Photo>(_dbContext);
        }
        public AdsRepository<Ad> Ads => _ads;
        public AdsRepository<Photo> Photo => _photo;
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
