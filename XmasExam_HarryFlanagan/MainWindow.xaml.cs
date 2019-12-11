using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XmasExam_HarryFlanagan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Lists*/
        List<Player> allPlayers = new List<Player>();

        //Name Arrays
        string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


        string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Create Players*/
            CreateRandomPlayer();
            CreatePlayers();

           
           


      
        }
        private void CreateRandomPlayer()
        {
            // Create a Random object  
            Random rand = new Random();
            // Generate a random index less than the size of the array.  
            int fNameIndex = rand.Next(firstNames.Length);
            // Generate a random index less than the size of the array.  
            int lNameIndex = rand.Next(lastNames.Length);

            DateTime RandomDay()
            {
                DateTime start = new DateTime(1990, 1, 1);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(rand.Next(range));
            }

            Player p1 = new Player(firstNames[fNameIndex], lastNames[lNameIndex], Position.GoalKeeper, RandomDay());

            /*Add Player to List*/
            allPlayers.Add(p1);
        }
        public void CreatePlayers()
        {
            Player p2 = new Player("Sophie", "O'Neill", Position.GoalKeeper, new DateTime(1993, 06, 03));
            Player p3 = new Player("Grace", "Walsh", Position.GoalKeeper, new DateTime(1992, 07, 03));
            Player p4 = new Player("Harry", "Lynch", Position.Defender, new DateTime(1999, 08, 03));
            Player p5 = new Player("Luke", "Browne", Position.Defender, new DateTime(1998, 09, 03));
            Player p6 = new Player("Simon", "Thomas", Position.Defender, new DateTime(1991, 10, 03));
            Player p7 = new Player("Jack", "Hull", Position.Defender, new DateTime(1997, 11, 03));
            Player p8 = new Player("Abigail", "Baker", Position.Defender, new DateTime(2000, 11, 03));
            Player p9 = new Player("Shaina", "McGovern", Position.Defender, new DateTime(1989, 11, 03));
            Player p10 = new Player("Jamie", "Flanagan", Position.Midfielder, new DateTime(1990, 11, 03));
            Player p11 = new Player("James", "Collet", Position.Midfielder, new DateTime(1994, 02, 03));
            Player p12 = new Player("Gary", "Eaton", Position.Midfielder, new DateTime(1995, 03, 03));
            Player p13 = new Player("Paige", "Smith", Position.Midfielder, new DateTime(1996, 04, 03));
            Player p14 = new Player("Jessica", "Carter", Position.Midfielder, new DateTime(1990, 05, 03));
            Player p15 = new Player("Evan", "Doherty", Position.Midfielder, new DateTime(1999, 05, 03));
            Player p16 = new Player("Peter", "Bell", Position.Forward, new DateTime(1999, 05, 03));
            Player p17 = new Player("Harrison", "Ford", Position.Forward, new DateTime(1999, 10, 13));
            Player p18 = new Player("Vicotor", "Emmanual", Position.Forward, new DateTime(1997, 05, 10));
            Player p19 = new Player("Suzy", "Smith", Position.Forward, new DateTime(1996, 06, 03));

            /*Add Player to List*/

        }

    }
}
