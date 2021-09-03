using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class BookingDetails_DTO
    {
        private string idBooking;

        public string IdBooking
        {
            get { return idBooking; }
            set { idBooking = value; }
        }
        private string idRoom;

        public string IdRoom
        {
            get { return idRoom; }
            set { idRoom = value; }
        }
    }
}
