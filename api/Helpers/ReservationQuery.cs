using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helpers
{
    public class ReservationQuery
    {

        public bool isExpired { get; set; } = false;
        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 100;
    }
}