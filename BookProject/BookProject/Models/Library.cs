using BookProject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.Models;
class Library
{
    public string Name { get; set; }
    public Book[] Books = [];
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
    public Book GetBookById(int id)
    {
        foreach (Book c in Books)
        {
            if (c.Id == id)
                return c;
        }
        throw new NotFoundException("Book is not found");
    }
    public void RemoveBook(int id)
    {
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Id == id)
            {
                for (int j = i; j < Books.Length - 1; j++)
                {
                    Books[j] = Books[j + 1];
                }
                Books[Books.Length - 1] = null;
                Array.Resize(ref Books, Books.Length - 1);
                Console.WriteLine("Book successfuly removed");
                return;
            }
        }
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
    public override string ToString()
    {
        return $"{Name}";
    }
}
