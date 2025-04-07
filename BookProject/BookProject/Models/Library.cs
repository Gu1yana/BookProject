using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.Models;

class Library
{
    public string Name { get; set; }
    public Book[] Books = new Book[0];
    public Library(string _name)
    {
        Name = _name;
    }
    public void AddBook(Book newbook)
    {
        Array.Resize(ref Books, Books.Length + 1);
        Books[^1] = newbook;
        Console.WriteLine("Successfly added");
    }
    public void GetBookById(int id)
    {
        foreach (var c in Books)
        {
            if (c.Id == id)
            {
               Console.WriteLine(c);
            }
        }Console.WriteLine("bu Id-li kitab yoxdur");
    }
    public void RemoveBook(int id)
    {
        for (int i=0;i<Books.Length;i++)
        {
            if (Books[i].Id== id)
            {
                Books[i] = Books[i + 1];
                Array.Resize(ref Books,Books.Length - 1);
            }
        }
        Console.WriteLine($"Removed book\n{Books}");
    }
    public void GetBook(string name)
    {
        foreach (var item in Books)
        {
            if (item.Name.Contains(name))
            {
                Console.WriteLine($"ID:{item.Id}. {item.Name}, {item.AuthorName},{item.Price}");
            }
        }
    }
    public void GetAllBook()
    {
        foreach (var b in Books)
        {
            Console.WriteLine(b);

        }
    }
}