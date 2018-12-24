using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    class Tester
    {

        private string id;
        private string first_name;
        private string last_name;
        private DateTime birthdate;
        private Gender gender;
        private string phone_number;
        private Address address;
        private double experience;//how many years of experience the tester has 
        private int max_tests_per_week;
        private Vehicle speciality;
        private bool[][] schedule;
        private double max_range;
        
        public string Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Birthdate
        {
            get => birthdate;
            set
            {
                //check if the tester is in the right age
                //....
                birthdate = new DateTime(value.Year, value.Month, value.Day);
            }
        }
        public string Phone_number
        {
            get
            {
                //return the number in the format 05x-xxx-xxxx
                string ret = phone_number.Substring(0, 3) + '-';
                ret += phone_number.Substring(3, 3) + '-';
                ret += phone_number.Substring(6);
                return ret;
            }
            set
            {
                //check if the phone number contain only digits
                try
                {
                    int.Parse(value);
                }
                catch (Exception)
                {

                    throw new Exception("the phone number must contain only digits");
                }
                //check if the number in the format 05x-xxx-xxxx
                if (!(value.Length == 10 && value.Substring(0, 2) == "05"))
                    throw new Exception("the phone number must be in the format 05x-xxx-xxxx");
                //if the number correct save him
                phone_number = value;
            }
        }
        public Address Address { get => address; set => address = value; }
        public double Experience { get => experience; set => experience = value; }
        public int Max_tests_per_week { get => max_tests_per_week; set => max_tests_per_week = value; }
        public bool[][] Schedules
        {
            get => schedule;
            set
            {
                //check if the value in the correct size
                bool correct_size = true;
                if (value.Length == 5)
                {
                    for (int i = 0; i < 5; i++)
                        if(value[i].Length!=7)
                        {
                            correct_size = false;
                            break;
                        }
                }
                else
                    correct_size = false;
                if (!correct_size)
                    throw new Exception("the array dont on the right size it should have from the shape bool[5][7]");

                //if the input correct we copy it 
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 7; j++)
                        schedule[i][j] = value[i][j];

            }
        }
        public double Max_range { get => max_range; set => max_range = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public Vehicle Speciality { get => speciality; set => speciality = value; }


        public Tester(string id, string first_name, string last_name, DateTime birthdate, string phone_number, Address address, double experience, int max_tests_per_week, double max_range, Gender gender, Vehicle speciality, bool[][] schedule = null)
        {
            //create schedule array
            this.schedule = new bool[5][];
            for (int i = 0; i < 5; i++)
            {
                this.schedule[i] = new bool[7];
                for (int j = 0; j < 7; j++)
                    this.schedule[i][j] = false;
            }
            //try to initialize the variables
            try
            {
                Id = id;
                First_name = first_name;
                Last_name = last_name;
                Birthdate = birthdate;
                Address = address;
                Experience = experience;
                Max_tests_per_week = max_tests_per_week;
                Max_range = max_range;
                Gender = gender;
                Speciality = speciality;
                Phone_number = phone_number;
                if (schedule != null)
                    Schedules = schedule;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override string ToString()
        {
            return "id: "+Id + "\n"+"name: " + Last_name + " " + First_name;
        }
    }
}
