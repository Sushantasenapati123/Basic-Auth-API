using Exam.Domain.Sports;
using Exam.Irepository.ISport;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        private readonly SpotInterface _SportService;
        public SportsController(SpotInterface prodService)
        {
            _SportService = prodService;
        }

        [HttpGet("{clubid}")]
        public async Task<ActionResult<IEnumerable<Spot>>> GetallSubCategoryByid(int clubid)
        {
            return await _SportService.BindSportByClubId(clubid);
        }


        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Spot>>> GetallSubCategorybyid([FromQuery] int clubid)
        //{
        //    return await _SportService.BindSportByClubId(clubid);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Spot>>> GetallSubCategorybyid(int clubid)
        {
            return await _SportService.BindSportByClubId(clubid);
        }

     
       
        [HttpGet("{clubid},{sportsId}")]
        public async Task<ActionResult<IEnumerable<Spot>>> GetAllSubCategoryByIdAndTypee(int clubid, int sportsId)
        {
            return await _SportService.getDetails(clubid, sportsId);
        }
        [HttpGet("GetAllByIdAndTypee")]
        public async Task<ActionResult<IEnumerable<Spot>>> GetAllByIdAndTypee(int clubid, int sportsId)
        {
            return await _SportService.getDetails(clubid, sportsId);
        }


    }
}
