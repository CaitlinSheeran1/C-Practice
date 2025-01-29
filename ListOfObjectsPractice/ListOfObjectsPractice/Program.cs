// Caitlin Sheeran
// 1/28/2025
// Lists of Objects Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ListOfObjectsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();


            players.Add(new Player("Chad"));
            players.Add(new Player("Mark"));
            players.Add(new Player("Karen"));


            foreach (Player player in players)
            {
                Console.WriteLine(player); // the ToString makes it so you can just put player instead of player.userName
            }

            Console.ReadKey();
        }
    }

    public class Player
    {
        public string userName;

        public Player(string userName)
        {
            this.userName = userName;
        }
        public override string ToString()
        {
            return userName;
        }
    }
}
