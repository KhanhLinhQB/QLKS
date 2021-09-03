using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Booking_DTO
    {
        private string idBooking;

        public string IdBooking
        {
            get { return idBooking; }
            set { idBooking = value; }
        }
        private string idEmployee;

        public string IdEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        private string idCustomer;

        public string IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        private string roomName;

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        private DateTime dateBook;

        public DateTime DateBook
        {
            get { return dateBook; }
            set { dateBook = value; }
        }
        private DateTime dateCheckIn;

        public DateTime DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        private DateTime dateCheckOut;

        public DateTime DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private int moneyDeposit;

        public int MoneyDeposit
        {
            get { return moneyDeposit; }
            set { moneyDeposit = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
