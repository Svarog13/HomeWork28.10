class Website
{
    private string name;
    private string url;
    private string description;
    private string ipAddress;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string IpAddress
    {
        get { return ipAddress; }
        set { ipAddress = value; }
    }

    public void EnterData()
    {
        Console.Write("Enter the name of the website: ");
        Name = Console.ReadLine();
        Console.Write("Enter the URL of the website: ");
        Url = Console.ReadLine();
        Console.Write("Enter the description of the website: ");
        Description = Console.ReadLine();
        Console.Write("Enter the IP address of the website: ");
        IpAddress = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Website Information: ");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("URL: " + Url);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("IP Address: " + IpAddress);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Website website = new Website();
        website.EnterData();
        website.DisplayData();
    }
}