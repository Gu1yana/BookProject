using BookProject.Models;

namespace BookProject;

class Program
{
    static void Main(string[] args)
    {
        Library lib = new Library("Merkezi kitabxana");
        
        bool davam = true;
        while (davam)
        {
            Console.WriteLine("\nSechim edin:\r\n1.Add book\r\n2.Get book by id\r\n3.Remove book\r\n4.Get all books\r\n5.Quick\n");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("ad daxil edin:");
                    string name = Console.ReadLine();
                    Console.WriteLine("yazici daxil edin:");
                    string authorname = Console.ReadLine();
                    Console.WriteLine("qiymet daxil edin:");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Book newbook = new(name, authorname, price);
                    Console.WriteLine(newbook);
                    lib.AddBook(newbook);
                    break;
                case 2:
                    Console.WriteLine("");
                    int n = int.Parse(Console.ReadLine());
                    lib.GetBookById(n);
                    break;
                case 3:
                    int f = int.Parse(Console.ReadLine());
                    lib.RemoveBook(f);
                    break;
                case 4:
                    lib.GetAllBook();
                    break;
                case 0:
                    davam = false;
                    break;
                default:
                    Console.WriteLine("basqa reqem daxil edin");
                    break;
            }
        }
    }
}
