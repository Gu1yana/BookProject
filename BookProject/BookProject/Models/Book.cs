using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.Models;

class Book : Object
{
    public static int _count = 0;
    public int Id { get;}
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public decimal Price { get; set; }

    public Book(string name, string authorName, decimal price)
    {
        Id = ++_count;
        Name = name;
        AuthorName = authorName;
        Price = price;
    }
    public void ShowInfo()
    {
        Console.WriteLine(this);
    }
    public override string ToString()
    {
        return $"Id:{Id}. Name:{Name}, Authorname:{AuthorName}, Price:{Price}";
    }
}
