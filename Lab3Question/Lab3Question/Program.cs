// See https://aka.ms/new-console-template for more information
using System;

public class Member
{
    private int MemberID;
    private string name;

    public int memberID
    {
        get { return MemberID; }
        set { MemberID = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Member(int MemberID,string name)
    {
        this.MemberID = MemberID;
        this.name = name;
    }

    public void DisplayMember()
    {
        Console.WriteLine("Member ID: " + MemberID + ", Name: " + name);
    }
}

public class Book
{
    private string title;
    private bool isborrowed;

    public string Title
    { get { return title; }
        set { title = value; }
    }

    public bool isBorrowed
    { get { return isborrowed; }
        set { isborrowed = value; }
    }

    public Book(string title)
    {
        this.title = title;
        isborrowed = false;
    }
}

public class Library
{
    public void BorrowBook(Member member, Book b)
    {
        if (!b.isBorrowed)
        {
            b.isBorrowed = true;
            Console.WriteLine(member.Name + " has borrowed the book: " + b.Title);
        }
        else
        {
            Console.WriteLine("Book already borrwed");
        }
    }
}

class Program
{
    static void Main()
    {
        Member member1 = new Member(1, "ali");
        Book book1 = new Book("C# programming");
        Library lib = new Library();

        lib.BorrowBook(member1, book1);
    }
}
