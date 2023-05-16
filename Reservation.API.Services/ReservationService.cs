using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService: IReservaitonService
    {
        private readonly IReservaitonService _reservaitonService;

        public ReservationService(IReservaitonService reservaitonService)
        {
            _reservaitonService = reservaitonService;
        }

        public ReservationDTO GetReservationByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO()
            {
                Id =  new Random().Next(100),
                Amount = (new Random().Next(10000)),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.AddDays(9),
                CheckoutDate = DateTime.Now.AddDays(12),
                BkgNumber = bkgNumber

            };
        }
    }
}
