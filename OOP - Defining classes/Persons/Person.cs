using System;


class Person
{
    private int age;
    private string email;
    private string name;

    // Constructors
    public Person(int age, string name, string email = "N/A")
    {
        this.Age = age;
        this.Name = name;
        if (email != "N/A")
        {
            this.Email = email;
        } 
    }

    public Person(int age, string name) : this(age, name, "N/A")
    {
        //reusing constructor
    }

    //      Properties
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("age");
            }

            age = value;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                email = "";
            }
            //I know that`s not the correct way to validate an email...please check this article: 
            // http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx
            // :) there`s no 100% safe way to validate a mail so for the purpose of the task I`m just checking a few basic things 
            else if (value.IndexOf("@") == -1 || value.Length < 5)
            {
                throw new ArgumentException("Not valid Email format");
            }
            else
            {
                email = value;
            }
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty name variable");
            }

            name = value;
        }
    }

    //      Formatting method
    public override string ToString()
    {
        string fullFormat =  string.Format("Name: {0}\n" +
                             "Email: {1}\n" +
                             "Age: {2}",
                             this.name, this.email, this.age);
        string mailless = string.Format("Name: {0}\n" +
                                        "Age: {1}",
                                        this.name, this.age);
        return String.IsNullOrEmpty(this.email) ? mailless : fullFormat;
    }
}

class TestPerson
{
    //for testing purposes
    public static void Main()
    {
        Person anton = new Person(24, "Anton", "asd@");

        Console.WriteLine(anton);
    }
}