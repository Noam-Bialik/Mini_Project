using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    class Tester : Person
    {
        private double experience;//how many years of experience the tester has 
        private int max_tests_per_week;
        private Vehicle speciality;
        private bool[][] schedule;
        private double max_range;
        
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


        public Tester(double experience, int max_tests_per_week, double max_range, Gender gender, Vehicle speciality, bool[][] schedule = null)
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
            return base.ToString();
        }
    }
}
