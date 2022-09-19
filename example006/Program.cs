Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "anton") {
    Console.WriteLine("Yo, ANTON!");
} else {
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
