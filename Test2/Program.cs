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
    public Mail(Mail previousMail)
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
        List<Mail> mails = new List<Mail>();

        for (int i = 0; i < 4; i++)
        {
            mails.Add(new Mail("Индекс-"+i, "Город-"+i, "Улица-"+i, "Дом-"+i, "Корпус-"+i, "Квартира-"+i, "Сообщение-"+i));
        }
        PrintMails(mails);
        Console.WriteLine("\n");
        // Remove 2nd and 4th objects
        /* mails.RemoveAt(1)
         * mails.RemoveAt(2) */
        mails.RemoveAt(3);
        mails.RemoveAt(1);
        PrintMails(mails);
    }

    private static void PrintMail(Mail mail)
    {
        Console.WriteLine("Address: '" + mail.Address + "' is valid: " + mail.Valid());
    }

    private static void PrintMails(List<Mail> mails)
    {
        foreach (Mail mail in mails)
        {
            PrintMail(mail);
        }
    }
}