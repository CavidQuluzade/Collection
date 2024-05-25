namespace TaskPhonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phonebook phonebook = new Phonebook();
            phonebook.AddContact("Cavid", "0509999999");
            phonebook.AddContact("AAA", "0551111111");
            phonebook.FindContactByName("AAA");
            

            phonebook.GetAllContacts();

        }
    }
}
