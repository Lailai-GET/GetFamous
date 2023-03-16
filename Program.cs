namespace GetFamous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sheep1 = new Sheeple("Kurt", true, "I hate all your enemies, and pray nightly for their deaths", 1337);
            var sheep2 = new Sheeple("Wanja", false, "I hope you die. I hope we both die.", 0);
            var sheep3 = new Sheeple("Katty", true, "Let's hang out and drink whiskey at the arcade", 9000);
            Console.WriteLine("Username:");
            var userName = Console.ReadLine();
            var fans = Sheeple.ReadFans();
            var user = new Star(userName, fans, readFunds());
            Console.WriteLine("Welcome, " + userName + "! You arrive on the scene like a message from God");
            

        }

        
    }
}