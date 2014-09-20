using System;

class Person
{
    private int age;
    private string email;
    private string name;

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
        // Reusing parent constructor
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("age");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                this.email = "";
            }
            else if (value.IndexOf("@") == -1 || value.Length < 5)
            {
                throw new ArgumentException("Not valid Email format");
            }

            this.email = value;
        }
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty name variable");
            }

            this.name = value;
        }
    }

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
    public static void Main()
    {
        Person anton = new Person(24, "Anton", "asd@");

        Console.WriteLine(anton);
    }
}