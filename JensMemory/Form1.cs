﻿using System;
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
        #region // Bildvektor som håller alla bilder på korten. Denna kommer hålla 60st kort till VG-uppgiften
        private Image[] picVector = { Properties.Resources.pic0, Properties.Resources.pic1,
                                      Properties.Resources.pic2, Properties.Resources.pic3,
                                      Properties.Resources.pic4, Properties.Resources.pic5,
                                      Properties.Resources.pic6, Properties.Resources.pic7,
                                      Properties.Resources.pic8, Properties.Resources.pic9,
                                      Properties.Resources.pic10, Properties.Resources.pic11,
                                      Properties.Resources.pic12, Properties.Resources.pic13,
                                      Properties.Resources.pic14, Properties.Resources.pic15,
                                      Properties.Resources.pic16, Properties.Resources.pic17,
                                      Properties.Resources.pic18, Properties.Resources.pic19,
                                      Properties.Resources.pic20, Properties.Resources.pic21,
                                      Properties.Resources.pic22, Properties.Resources.pic23,
                                      Properties.Resources.pic24, Properties.Resources.pic25,
                                      Properties.Resources.pic26, Properties.Resources.pic27,
                                      Properties.Resources.pic28, Properties.Resources.pic29,
                                      Properties.Resources.pic30, Properties.Resources.pic31,
                                      Properties.Resources.pic32, Properties.Resources.pic33,
                                      Properties.Resources.pic34, Properties.Resources.pic35,
                                      Properties.Resources.pic36, Properties.Resources.pic37,
                                      Properties.Resources.pic38, Properties.Resources.pic39,
                                      Properties.Resources.pic40, Properties.Resources.pic41,
                                      Properties.Resources.pic42, Properties.Resources.pic43,
                                      Properties.Resources.pic44, Properties.Resources.pic45,
                                      Properties.Resources.pic46, Properties.Resources.pic47,
                                      Properties.Resources.pic48, Properties.Resources.pic49,
                                      Properties.Resources.pic50, Properties.Resources.pic51,
                                      Properties.Resources.pic52, Properties.Resources.pic53,
                                      Properties.Resources.pic54, Properties.Resources.pic55,
                                      Properties.Resources.pic56, Properties.Resources.pic57,
                                      Properties.Resources.pic58, Properties.Resources.pic59};
        #endregion


        // bildvektor för omslag/baksida. kommer hålla 3st olika för VG
        private Image[] coverVector = { Properties.Resources.newpokeball, Properties.Resources.newpokemon, Properties.Resources.newpokemon2 };
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
        

        BakGrundPopUp BG = new BakGrundPopUp();

        private int rows = 12, columns = 10; //intar som håller värde för spelplanens storlek. Användaren skall sedan sätta dessa själv
        
        
        public GameWindow() //Konstruktor för spelfönstret. Här ligger nu oxå kod för att rita upp spelplanen
        {
            InitializeComponent();
            BG.ShowDialog();

            if (columns == rows)
            {
                this.pnlCardHolder.Size = new System.Drawing.Size(600, 600);
                this.pnlCardHolder.Location = new System.Drawing.Point(250, 60);
            }

            //Nya kort instansieras och argument skickas med i för position på spelplanen
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Card card = new Card(i, j, (pnlCardHolder.Width / columns - 5), (pnlCardHolder.Height / rows - 5), card_Click);
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
                cards[i].Image = coverVector[BG.coverChoice];
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
                flippedcard.Image = coverVector[BG.coverChoice];
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
            foreach (Player p in players)
            {
                winnerList.Add(p);
            }
            while (winnerList.Count > 1)
            {
                if (winnerList[0].points == winnerList[1].points)
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

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

    }
}