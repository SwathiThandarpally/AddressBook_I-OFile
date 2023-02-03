namespace AddressBook_FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dispalaying File Input Output Stream Reader ");

            string path = @"C:\Users\sai\source\repos\RFP-244\AddressBook_FileIO\AddressBook_I-OFile\AddressBook_FileIO\ContactDetails.txt";

            PersonDetails details = new PersonDetails();
            Console.WriteLine("\nEnter your First Name : ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            details.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            details.Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            details.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            details.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            details.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            details.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            details.Email = Console.ReadLine();

            InputOutputFile inputOutput = new InputOutputFile();
            inputOutput.CheckIfExist();
            inputOutput.WriteDetailsInFile(path, details );
            inputOutput.ReadDetailsFromFile(path);


        }
    }
}