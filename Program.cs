public class Program
{
    public static void Main()
    {
        Post post = new Post("How to implement a stack?", "I'm trying to implement a stack in C#. Can someone provide an example?");
        
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Up-vote");
            Console.WriteLine("2. Down-vote");
            Console.WriteLine("3. Display vote count");
            Console.WriteLine("4. Display post details");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    post.UpVote();
                    Console.WriteLine("Post up-voted!");
                    break;
                case "2":
                    post.DownVote();
                    Console.WriteLine("Post down-voted!");
                    break;
                case "3":
                    Console.WriteLine($"Current vote value: {post.GetVotes()}");
                    break;
                case "4":
                    post.DisplayPost();
                    break;
                case "5":
                    return; // Exit the loop and program
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}