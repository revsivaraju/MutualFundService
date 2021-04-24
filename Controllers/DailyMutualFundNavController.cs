using Microsoft.AspNetCore.Mvc;
using DailyMutualFund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DailyMutualFund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyMutualFundNavController : ControllerBase
    {
        
        private IMutualFundDb MutualFundDbObj;

        public DailyMutualFundNavController(IMutualFundDb obj)
        {
            MutualFundDbObj = obj;
        }

        
        [HttpGet("{mutualFundName}")]
        public ActionResult Get(string mutualFundName)
        {
            if (mutualFundName == null)
            {
                return BadRequest();
            }
            if (MutualFundDbObj.MutualFundNav(mutualFundName) == null)
            {
                return BadRequest();
            }


            return Ok(MutualFundDbObj.MutualFundNav(mutualFundName));
        }
    }
}
