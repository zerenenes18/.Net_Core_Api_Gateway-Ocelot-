using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {

        IReservaitonService _reservationService;

        public ReservationController(IReservaitonService reservaitonService)
        {
            _reservationService = reservaitonService;
        }


        [HttpGet("{bkg}")]

        public ReservationDTO Get(int bkg)
        {
            return _reservationService.GetReservationByBkgNumber(bkg);
        }

    }
}
