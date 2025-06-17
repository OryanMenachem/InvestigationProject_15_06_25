using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject_15_06_25
{
    internal class IranianAgentsNames
    {

        public string FullName()
        {
            Random random = new Random();

            string fullName = FirstName(random.Next(0,20)) +" "+ 
                              LastName(random.Next(0,20));   

            return fullName;


        }




        private string FirstName(int rand) {
            
            string[] firstName  = {
                    "Mohammad", "Fatemeh", "Zahra", "Ali", "Reza",
                    "Sara", "Maryam", "Masoud", "Nima", "Omid",
                    "Arash", "Parvīz", "Farhad", "Babak", "Kaveh",
                    "Darius", "Ehsan", "Kamran", "Amin", "Hossein" };

            return firstName[rand];
        }

        private string LastName(int rand)
        {

            string[] lastName = {
                    "Mohammadi", "Hosseini", "Ahmadi", "Ali", "Moradi",
                    "Karimi", "Mousavi", "Jafari", "Rahimi", "Ebrahimi",
                    "Abbasi", "Gholami", "Ghasemi", "Ghorbani", "Akbari",
                    "Sadeghi", "Gholami", "Shirazi", "Tehrani", "Sharifi"};

            return lastName[rand];

        }

    }
}
