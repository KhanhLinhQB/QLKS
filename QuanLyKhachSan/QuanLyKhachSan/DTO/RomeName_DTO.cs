using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class RomeName_DTO
    {
        private string roomName;

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private int priceRoom;

        public int PriceRoom
        {
            get { return priceRoom; }
            set { priceRoom = value; }
        }
    }
}
