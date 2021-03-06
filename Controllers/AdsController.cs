using awwcor_web_api.Models;
using awwcor_web_api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace awwcor_web_api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AdsController
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<AdsController> _logger;
        public AdsController(UnitOfWork unitOfWork, ILogger<AdsController> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllAdDTOs()
        {
            try
            {
                return new JsonResult(_unitOfWork.GetAllAdDTOs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,$"Error invoking GetAll - {ex.Message}");
                return new StatusCodeResult(500);
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAd(int id, [FromQuery] string fields = "")
        {
            try
            {
                var ad = _unitOfWork.GetAdDTOById(id);
                return new JsonResult(ad);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error invoking GetAd - {ex.Message}");
                return new StatusCodeResult(500);
            }
        }
        [HttpPost]
        public IActionResult PostAd(AdFullDTO newAd)
        {
            try
            {
                string message = "";
                int newAdID = _unitOfWork.SaveNewAd(newAd, out message);

                var res = new
                {
                    AdID = newAdID,
                    Message = message 
                };

                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error invoking PostAd - {ex.Message}");
                return new StatusCodeResult(500);
            }
        }

    }
}
