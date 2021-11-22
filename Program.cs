using System;

namespace mis221_compLab_Lcmims1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create An Author 
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());
            Console.WriteLine("\n");
            //Create A Book Class
            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine("\n");
            //Access the Author
            Console.WriteLine(myBook.GetAuthor().ToString());
            Console.WriteLine("\n");
            //Anonymous Object pt.1
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());
            //Anonymous Object pt.2
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());

        }
    }
}
