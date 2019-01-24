using System;
using System.Collections.Generic;
//system io allows use of collection
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

       public static List<TimePerson> GetPersons(int startYear, int endYear)
       {
           List<TimePerson> people = new List<TimePerson>();
       
           //finds file and reads it
           string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
       
           //use File.ReadAllLines (returns an array)
           var personData = File.ReadAllLines(path).Skip(1);

            foreach (var item in personData)
            {
                //sets the range of possible years
                if( startYear >= 1927 && endYear <= 2016)
                {
                    string[] field = item.Split(',');
                    TimePerson tperson = new TimePerson();
                    tperson.Year = (field[0] == "" ? 0 : Convert.ToInt32(field[0]));
                    tperson.Honor = field[1];
                    tperson.Name = field[2];
                    tperson.Country = field[3];
                    tperson.BirthYear = (field[4] == "" ? 0 : Convert.ToInt32(field[4]));
                    tperson.DeathYear = (field[5] == "" ? 0 : Convert.ToInt32(field[5]));
                    tperson.Title = field[6];
                    tperson.Category = field[7];
                    tperson.Context = field[8];
                    people.Add(tperson);
                }
            }
            //create the full list of people from the csv file
            //then to link query with lambda expression to filter
            List<TimePerson> listofPeople = people.Where(p => (p.Year >= startYear) && (p.Year <= endYear)).ToList();
            return listofPeople;
        }

    }
}
