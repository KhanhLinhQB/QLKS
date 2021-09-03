using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Employee_DTO
    {
        private string idEmployee;

        public string IdEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        private string idPosition;

        public string IdPosition
        {
            get { return idPosition; }
            set { idPosition = value; }
        }
        private string nameEmployee;

        public string NameEmployee
        {
            get { return nameEmployee; }
            set { nameEmployee = value; }
        }
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private string genderEmployee;

        public string GenderEmployee
        {
            get { return genderEmployee; }
            set { genderEmployee = value; }
        }
        private string PhoneNumber;

        public string phoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private string idCardEmployee;

        public string IdCardEmployee
        {
            get { return idCardEmployee; }
            set { idCardEmployee = value; }
        }
        private string addressEmployee;

        public string AddressEmployee
        {
            get { return addressEmployee; }
            set { addressEmployee = value; }
        }
        private string emailEmployee;

        public string EmailEmployee
        {
            get { return emailEmployee; }
            set { emailEmployee = value; }
        }

    }
}
