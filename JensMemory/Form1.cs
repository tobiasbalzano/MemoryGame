using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JensMemory
{
    public partial class GameWindow : Form
    {
        // Bildvektor som håller alla bilder på korten. Denna kommer hålla 60st kort till VG-uppgiften
        private Image[] picVector = { Properties.Resources.card1, Properties.Resources.card2,
                                      Properties.Resources.card3, Properties.Resources.card4,
                                      Properties.Resources.card5, Properties.Resources.card6,
                                      Properties.Resources.card7, Properties.Resources.card8};

        // bildvektor för omslag/baksida. kommer hålla 3st olika för VG
        private Image[] coverVector = { Properties.Resources.cover };
        public static List<Player> players = new List<Player>(); // Lista som håller spelarna
        public static List<Player> playerTurn = new List<Player>(); // Lista som håller spelarordningen
        private List<Card> cards = new List<Card>(); //Lista som håller alla kort(objekt)
        private List<Card> flippedCards = new List<Card>(); //Lista som håller de 2st kort som skall jämföras
        private List<Player> winnerList = new List<Player>(); // Lista som skall hålla vinnare
        int drawPlayer = 0;
        Random rand = new Random();
        int chooseTurn;
        Player activePlayer;
        int totalPoints;
        int endGame;

        private int rows = 4, columns = 4; //intar som håller värde för spelplanens storlek. Användaren skall sedan sätta dessa själv

        public GameWindow() //Konstruktor för spelfönstret. Här ligger nu oxå kod för att rita upp spelplanen
        {
            InitializeComponent();

            //Nya kort instansieras och argument skickas med i för position på spelplanen
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Card card = new Card(j, i, card_Click);
                    cards.Add(card);
                    this.pnlCardHolder.Controls.Add(card);
                }
            }
            randomizeIdInCardList(rows * columns); //konstruktorn ropar på metod för att blanda kortens id
            endGame = cards.Count() / 2;
            totalPoints = 0;
            //lägger till testkommentar här
        }

        private void randomizeIdInCardList(int numberOfCards) //metod för att blanda kortens id
        {
            List<int> shuffledIntList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < (numberOfCards / 2); i++)
            {
                // Skapa två likadana id:n och slumpa in dom i listan.
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
            }
            for (int i = 0; i < numberOfCards; i++)
            {
                // id delas ut till korten i listan cards
                cards[i].id = shuffledIntList[i];
                //  Här kan man stoppa in bildreferens i Card:
                cards[i].Image = coverVector[0];
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //Här kan vi lägga lägga kod för att skapa användare och rita ut planen mm..
            // istället för att göra det i spelfönstrets konstruktor..
            PopUp popUp = new PopUp();

            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                chooseTurn = rand.Next(0, players.Count);
                players[chooseTurn].turn = true;
                activePlayer = playerTurn[0];
                foreach (Card card in cards)
                {
                    card.Enabled = true;
                }
                GetInfo();
            }
        }


        private void card_Click(object sender, EventArgs e) // Metoden som skall köras när man klickar på korten
        {
            // Vi castar om object sender till Card sender så att kompilatorn känner att
            // avsändaren av klick-eventet är av typen Card : PictureBox
            Card card = (Card)sender;
            flipCards(card);
        }
        // Metod som körs när timern räknat ned.
        private void timerCompare_Tick(object sender, EventArgs e)
        {
            //Ändrar tillbaka bild till baksidan mm..
            foreach (Card flippedcard in flippedCards.ToList())
            {
                // vid olida ändras kortens bild till baksida och listan töms
                flippedcard.Image = coverVector[0];
                flippedcard.flipped = false;
                flippedCards.Remove(flippedcard);
            }
            // Gör alla kort klickbara igen
            foreach (Card c in cards)
            {
                c.Enabled = true;
            }

            //Stoppar timern...
            timerCompare.Stop();
            NewTurn();
            GetInfo();
        }
        public void NewTurn()
        {
            playerTurn.RemoveAt(0);
            playerTurn.Add(activePlayer);
            activePlayer = playerTurn[0];
        }


        public void GetInfo() //Metod föra att skriva ut poäng mm
        {
            string info = "";
            foreach (Player p in players)
            {
                info += p.name + " - " + p.points + " poäng.\r\n";
                /*if (p.turn)
                {
                    lblWhosTurn.Text = p.name;
                }*/

                lblWhosTurn.Text = activePlayer.name;
            }
            tbxInfo.Text = info;

        }


        public static void CreatePlayer(string name)
        {
            Player player = new Player(name);
            players.Add(player);
            playerTurn.Add(player);

        }

        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            bool win = WhoWon();
            timerEndGame.Stop();
            // Adams kod 
            string message;
            string caption = "Memory Game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon question = MessageBoxIcon.Question;
            DialogResult result;


            if (win)
            {

                message = "Grattis " + winnerList[0].name + ", du vann med " + winnerList[0].points.ToString()
                    + " poäng \nVill ni spela igen?";
                result = MessageBox.Show(message, caption, buttons, question);
            }

            else
            {
                message = "Det blev oavgjort!\nVill ni spela igen?";
                result = MessageBox.Show(message, caption, buttons, question);
            }
            if (result == DialogResult.Yes)
            {
                PlayAgain();
            }
            else
            {
                Application.Exit();
            }


        }

        public void PlayAgain()
        {
            //Adams Kod
            foreach (Player p in players)
            {
                p.points = 0;
                chooseTurn = rand.Next(0, players.Count);
            }
            randomizeIdInCardList(cards.Count);
            foreach (Card c in cards)
            {
                c.flipped = false;
            }
            totalPoints = 0;
            GetInfo();
        }

        public bool WhoWon()
        {
            bool winner = false;

            //winnerList = players;
            foreach(Player p in players)
            {
                winnerList.Add(p);
            }
            while (winnerList.Count>1)
            {
                if(winnerList[0].points==winnerList[1].points)
                {
                    drawPlayer = winnerList[0].points;
                    winnerList.Remove(winnerList[0]);
                }
                else if (winnerList[0].points < winnerList[1].points)
                {
                    winnerList.Remove(winnerList[0]);
                }
                else if (winnerList[0].points > winnerList[1].points)
                {
                    winnerList.Remove(winnerList[1]);
                }
                
            }
            if (winnerList[0].points > drawPlayer)
            {
                winner = true;
            }
            


            return winner;
        }

        private void flipCards(Card card)
        {
            if (card.flipped == false)
            {
                // kortet vänds och byter bild samt läggs till i lista för att jämföras
                card.flipped = true;
                flippedCards.Add(card);
                card.Image = picVector[card.id];
            }
            if (flippedCards.Count == 2)
            {
                // Sätter alla kort till oklickbara när 2 är valda
                foreach (Card c in cards)
                {
                    c.Enabled = false;
                }
                compareCards();
            }
        }

        public void compareCards()
        {
            if (flippedCards[0].id == flippedCards[1].id)
            {
                // gör korten klickbara igen
                foreach (Card c in cards)
                {
                    c.Enabled = true;
                }

                // Tömmer listan för jämförelse
                flippedCards.Clear();

                // poäng delas ut
                activePlayer.points++;
                totalPoints++;

                //poäng skrivs ut
                GetInfo();

                if (totalPoints >= endGame)
                {
                    timerEndGame.Start();
                }
            }
                //min hemliga kommentar av Tobias
            else
            {
                //timerCompare.Enabled = true;
                timerCompare.Start();
            }
        }

    }
}