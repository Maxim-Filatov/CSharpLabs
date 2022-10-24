/*  8.Объект «Почтовое отправление», содержащий автоматические свойства адреса получателя:
 *  индекс, город, улица, дом, корпус, квартира, а также, тело письма (сообщение).
 *  Объект должен содержать метод Valid() выполняющий проверки заполнения всех полей,
 *  а также свойство Адрес, выводящее адрес в виде строки. */
class Mail
{
    // Properties
    private String? Index { get; set; }
    private String? City { get; set; }
    private String? Street { get; set; }
    private String? House { get; set; }
    public String? Building { get; set; }
    private String? Flat { get; set; }
    private String? Message { get; set; }  
    public String Address
    {
        get
        {
            return $"{Index}, {City}, {Street}, {House}/{Building}, {Flat}";
        }
    }

    // Empty constructor
    public Mail() { }

    // Constructor with params
    public Mail(String? index, String? city, String? street, String? house, String? building, String? flat, String? message)
    {
        Index = index;
        City = city;
        Street = street;
        House = house;
        Building = building;
        Flat = flat;
        Message = message;
    }

    // Copy constructor
    public Mail (Mail previousMail)
    {
        Index = previousMail.Index;
        City = previousMail.City;
        Street = previousMail.Street;
        House = previousMail.House;
        Building = previousMail.Building;  
        Flat = previousMail.Flat;
        Message = previousMail.Message;
    }

    // Clone method
    public Mail Clone()
    {
        return new Mail(Index, City, Street, House, Building, Flat, Message);
    }

    // Method Valid()
    public bool Valid()
    {
        return Index != null && City != null && Street != null && House != null && Building != null && Flat != null && Message != null;
    }
}

internal class Program
{
    public static void Main(String[] args)
    {
        Mail _1st = new (
            args.Length >= 1 ? args[0] : null,
            args.Length >= 2 ? args[1] : null,
            args.Length >= 3 ? args[2] : null,
            args.Length >= 4 ? args[3] : null,
            args.Length >= 5 ? args[4] : null,
            args.Length >= 6 ? args[5] : null,
            args.Length >= 7 ? args[6] : null);
        PrintMail(_1st);

        Mail _2nd = new ("191023", "Saint-Petersburg", "Nevskiy Avenue", "77", "1", "21", "Hello!");
        PrintMail(_2nd);

        Mail _3rd = new (_1st);
        PrintMail(_3rd);

        Mail _4th = _2nd.Clone();
        PrintMail(_4th);
    }

    private static void PrintMail(Mail mail)
    {
        Console.WriteLine("Address: '" + mail.Address + "' is valid: " + mail.Valid());
    }
}