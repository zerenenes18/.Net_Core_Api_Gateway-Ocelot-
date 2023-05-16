using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Infrastructure
{
    public interface IReservaitonService
    {

        public ReservationDTO GetReservationByBkgNumber(int id);

    }
}
