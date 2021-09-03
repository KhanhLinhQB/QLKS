using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Room_DTO
    {
        private string idRoom;

        public string IdRoom
        {
            get { return idRoom; }
            set { idRoom = value; }
        }
        private string roomName;

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
