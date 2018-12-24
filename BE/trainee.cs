using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        private string id;
        private string first_name;
        private string last_name;
        private DateTime birthdate;
        private Gender gender;
        private string phone_number;
        private Address address;

        //we need to add more properies

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
