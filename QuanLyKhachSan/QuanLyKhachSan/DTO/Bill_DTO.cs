using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Bill_DTO
    {
        private string idBill;

        public string IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }
        private string idBooking;

        public string IdBooking
        {
            get { return idBooking; }
            set { idBooking = value; }
        }
        private DateTime dateBilling;

        public DateTime DateBilling
        {
            get { return dateBilling; }
            set { dateBilling = value; }
        }
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
