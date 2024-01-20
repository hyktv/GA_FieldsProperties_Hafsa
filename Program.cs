namespace GA_FieldsProperties_Hafsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John Doe"; //testing setter
            Console.WriteLine(person.Name); //testing getter
            Console.WriteLine(person.ReadOnlyName); //testing readonly property
        }//main

    }//class


}//namespace