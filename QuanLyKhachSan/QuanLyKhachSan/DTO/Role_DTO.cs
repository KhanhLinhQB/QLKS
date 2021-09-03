using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Role_DTO
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private string permission;

        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }
       
    }
}
