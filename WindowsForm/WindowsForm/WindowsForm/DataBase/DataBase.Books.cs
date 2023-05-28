using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsForm
{
    public partial class DataBase
    {
        public static class Books
        {
            private const string _nameTable = "Books.txt";

            public static int EndID
            {
                get
                {
                    int endID = 0;
                    using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] sp = line.Split('~');
                            Book book = new Book(sp[3], int.Parse(sp[1]), sp[5], int.Parse(sp[7]));
                            endID = book.ID;
                        }
                    }
                    return endID;
                }
            }
            public static void AddBook(int id, string name, string autor, int count)
            {
               
                File.AppendAllText($"{_nameBase}/{_nameTable}", "~" + (EndID + 1) + "~ ~" + name + "~ ~" + autor + "~ ~" + count + "~\n");
            }
            public static List<Book> GetBooks()
            {
                List<Book> books = new List<Book>();
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) 
                    {
                        string[] sp = line.Split('~');
                        books.Add(new Book(sp[3], int.Parse(sp[1]), sp[5], int.Parse(sp[7])));
                    }
                }
                return books;
            }
            public static void DeleteRecord(int iD)
            {
                List<Book> books = GetBooks();
                File.WriteAllText($"{_nameBase}/{_nameTable}", null);
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].ID != iD)
                    {
                        AddBook(books[i].ID, books[i].Name, books[i].Autor, books[i].Price);
                    }
                }
            }
            public static Book GetBook(int id)
            {
                Book book;
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        book = new Book(sp[3], int.Parse(sp[1]), sp[5], int.Parse(sp[7]));
                        if(book.ID == id)
                            return book;
                    }
                }
                throw new Exception("Книга не найдена");
            }
        }
    }
}
