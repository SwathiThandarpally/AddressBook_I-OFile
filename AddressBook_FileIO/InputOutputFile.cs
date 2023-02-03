using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_FileIO
{
    public  class InputOutputFile
    {
        public string path;
        public InputOutputFile()
        {
            path = @"C:\Users\sai\source\repos\RFP-244\AddressBook_FileIO\AddressBook_I-OFile\AddressBook_FileIO\ContactDetails.txt";
        }
        public void CheckIfExist()
        {
            if(!File.Exists(path))
            {
                return;
            }
        }
        public  void WriteDetailsInFile(string path, PersonDetails person)
        {

            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("\nFirst Name : " + person.FirstName);
                sw.WriteLine("Last Name : " + person.LastName);
                sw.WriteLine("Address : " + person.Address);
                sw.WriteLine("City : " + person.City);
                sw.WriteLine("State : " + person.State);
                sw.WriteLine("Email : " + person.Email);
                sw.WriteLine("Zip code : " + person.Zip);
                sw.WriteLine("PhoneNumber : " + person.PhoneNumber);
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("\nPerson Details Added SuccessFully In File");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
        public void ReadDetailsFromFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
    }
}
