using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/lane")]
    [ApiController]
    public class LaneController : ControllerBase
    {
        private readonly ILaneRepository _laneRepo;
        public LaneController(ILaneRepository laneRepo)
        {
            _laneRepo = laneRepo;
        }
    }
}