using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class KhachHang_DTO
    {
        private string idCustomer;

        public string IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        private string nameCustomer;

        public string NameCustomer
        {
            get { return nameCustomer; }
            set { nameCustomer = value; }
        }
        private string idCardCustomer;

        public string IdCardCustomer
        {
            get { return idCardCustomer; }
            set { idCardCustomer = value; }
        }
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private string emailCustomer;

        public string EmailCustomer
        {
            get { return emailCustomer; }
            set { emailCustomer = value; }
        }
        private string addressCustomer;

        public string AddressCustomer
        {
            get { return addressCustomer; }
            set { addressCustomer = value; }
        }
    }
}
