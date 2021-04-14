﻿using awwcor_web_api.Models;
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
        public List<AdDTO> GetAllAdDTOs { get {
                var adsDTO = from a in _dbContext.Ad
                             let mainPhoto = a.Photos.FirstOrDefault(l => l.Ad == a)
                             orderby a.Price
                             select new AdDTO()
                             {
                                 Id = a.Id,
                                 Title = a.Title,
                                 MainPhotoLink = mainPhoto.PhotoURL,
                                 Price = a.Price
                             };
                return adsDTO.ToList();
            } }

        public AdDTO GetAdDTOById(int id) {
            var ad = _dbContext.Ad.Find(id);
            if (ad != null)
            {
                return new AdDTO { Id = ad.Id, Title = ad.Title, Price = ad.Price, MainPhotoLink = _dbContext.Photo.FirstOrDefault(x => x.Ad == ad)?.PhotoURL};
            }
            else
                return null;
            }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
