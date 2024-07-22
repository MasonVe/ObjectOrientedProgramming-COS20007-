namespace _1._2;

class Program
{
    static void Main(string[] args)
    {
        Message myMessage = new Message ("Hello World - Name Rater");
        myMessage.Print();

        Message[] message = new Message[4];
        message[0] = new Message("Welcome back oh great educator!");
        message[1] = new Message("What a lovely name");
        message[2] = new Message("Great name");
        message[3] = new Message("That is a silly name");


        Console.WriteLine("Enter name: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "yongrui")
        {
            message[0].Print();
        }
        else if (input.ToLower() == "mason")
        {
            message[1].Print();
        }
        else if (input.ToLower() == "josh")
        {
            message[2].Print();
        }
        else
        {
            message[3].Print();
        }


        Console.ReadLine();
    }
}
