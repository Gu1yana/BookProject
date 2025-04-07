using BookProject.Exceptions;
using BookProject.Models;
using System.Linq.Expressions;

namespace BookProject;

class Program
{
    static void Main(string[] args)
    {
        Library lib = new Library("Merkezi kitabxana");
        
        bool davam = true;
        while (davam)
        {
            Console.WriteLine($"~{lib}~\r\nSechim edin:\r\n1.Add book\r\n2.Get book by id\r\n3.Remove book\r\n4.Get all books\r\n0.Quick\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Kitab adi daxil edin:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Yazici ad ve soyadi daxil edin:");
                    string authorname = Console.ReadLine();
                    Console.WriteLine("Kitabin qiymetini daxil edin:");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Book newbook = new(name, authorname, price);
                    newbook.ShowInfo();
                    lib.AddBook(newbook);
                    break;
                case 2:
                    Console.WriteLine("");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(lib.GetBookById(n));
                    break;
                case 3:
                    Console.WriteLine("Silmek istediyiniz kitab Id-sini daxil edin:");
                    int a = int.Parse(Console.ReadLine());
                    lib.RemoveBook(a);
                    try
                    {
                        lib.RemoveBook(a);
                    }
                    catch (NotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    lib.GetAllBook();
                    break;
                case 0:
                    davam = false;
                    break;
                default:
                    Console.WriteLine("Basqa reqem daxil edin");
                    break;
            }
        }
    }
}