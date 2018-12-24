using System;

namespace BE
{
    public class Person
    {

        private string id;
        private string first_name;
        private string last_name;
        private DateTime birthdate;
        private Gender gender;
        private string phone_number;
        private Address address;

        public string Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public Address Address { get => address; set => address = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}