using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Position_DTO
    {
        private string idPosition;

        public string IdPosition
        {
            get { return idPosition; }
            set { idPosition = value; }
        }
        private string namePosition;

        public string NamePosition
        {
            get { return namePosition; }
            set { namePosition = value; }
        }
    }
}
