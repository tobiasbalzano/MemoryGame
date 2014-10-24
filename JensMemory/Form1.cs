using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace JensMemory
{
    public partial class GameWindow : Form
    {
        #region // Vektorer för alla bilder
        private Image[] picVector = { Properties.Resources.pic0, Properties.Resources.pic01,
                                      Properties.Resources.pic02, Properties.Resources.pic03,
                                      Properties.Resources.pic04, Properties.Resources.pic05,
                                      Properties.Resources.pic06, Properties.Resources.pic07,
                                      Properties.Resources.pic08, Properties.Resources.pic09,
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



        // bildvektor för omslag/baksida. kommer hålla 3st olika för VG
        private Image[] coverVector = { Properties.Resources.newpokeball,
                                        Properties.Resources.newpokemon,
                                        Properties.Resources.newpokemon2 };

        private Image[] Portraits = { Properties.Resources.trainer1, Properties.Resources.trainer2,
                                      Properties.Resources.trainer3, Properties.Resources.trainer4,
                                      Properties.Resources.trainer5, Properties.Resources.trainer6 };

        private Image[] Silhouettes = { Properties.Resources.trainer1S, Properties.Resources.trainer2S,
                                        Properties.Resources.trainer3S, Properties.Resources.trainer4S,
                                        Properties.Resources.trainer5S, Properties.Resources.trainer6S };
        #endregion

        #region //Alla listor
        public static List<Player> players; // Lista som håller spelarna
        public static List<Player> playerTurn; // Lista som håller spelarordningen
        private List<Card> cards; //Lista som håller alla kort(objekt)
        private List<Card> flippedCards = new List<Card>(); //Lista som håller de 2st kort som skall jämföras
        public static List<Player> winnerList; // Lista som skall hålla vinnare
        public Card[] AICards = new Card[2];
        private List<Card> AIMemory = new List<Card>();
        #endregion

        //int drawPlayer = 0;
        Random rand = new Random();
        //int chooseTurn;
        Player activePlayer;
        int totalPoints;

        #region //Alla ljud
        public static SoundPlayer splashSound = new SoundPlayer(Properties.Resources.pokemonSplash1);
        public static SoundPlayer clickForwardFX = new SoundPlayer(Properties.Resources.ClickForward);
        public static SoundPlayer clickBackFX = new SoundPlayer(Properties.Resources.ClickBack);
        public static SoundPlayer clickBigFX = new SoundPlayer(Properties.Resources.ClickBig);
        public static SoundPlayer clickNextFX = new SoundPlayer(Properties.Resources.NextFx);
        public static SoundPlayer gameBoardFX = new SoundPlayer(Properties.Resources.GameWindow);
        public static SoundPlayer cardFlipFX = new SoundPlayer(Properties.Resources.CardFlip);
        public static SoundPlayer flipBackFX = new SoundPlayer(Properties.Resources.CardFlipBack);
        public static SoundPlayer pointsFX = new SoundPlayer(Properties.Resources.PairPoint);
        public static SoundPlayer winFX = new SoundPlayer(Properties.Resources.WinSound);
        public static SoundPlayer loseDrawFX = new SoundPlayer(Properties.Resources.CompWinDraw);
        public static SoundPlayer creditSong = new SoundPlayer(Properties.Resources.PThemeS);
        #endregion

        public int allPoints;
        ChooseCharacter CHAR;
        BakGrundPopUp BG;
        PopUpBoardSize boardSize;
        public static EndSplash exit = new EndSplash();
        EndGame endGame;
        public static int setDuration;
        int duration;
        bool updatePortraits;

        public static int columns, rows;  //intar som håller värde för spelplanens storlek. Användaren kan välja

        public GameWindow() //Konstruktor för spelfönstret plus laddning av ljud
        {
            InitializeComponent();
            splashSound.Play();
            clickForwardFX.Load();
            clickBackFX.Load();
            clickBigFX.Load();
            clickNextFX.Load();
            gameBoardFX.Load();
            cardFlipFX.Load();
            flipBackFX.Load();
            pointsFX.Load();
            winFX.Load();
            loseDrawFX.Load();
            creditSong.Load();
            splashTimer.Enabled = true;
        }

        private void randomizeIdInCardList(int numberOfCards) //metod för att blanda kortens id
        {
            List<int> shuffledIntList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < (numberOfCards / 2); i++)
            {
                //Skapa två likadana id:n och slumpa in dom i listan
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
            }
            for (int i = 0; i < numberOfCards; i++)
            {
                //id delas ut till korten i listan cards
                cards[i].id = shuffledIntList[i];

                //Här kan man stoppa in bildreferens i Card:
                cards[i].Image = coverVector[BG.coverChoice];
            }
        }

        private void card_Click(object sender, EventArgs e) // Metoden som körs när korten klickas
        {
            // Vi castar om object sender till Card sender så att kompilatorn känner att
            // avsändaren av klick-eventet är av typen Card : PictureBox
            Card card = (Card)sender;
            flipCards(card);
        }

        public void NewTurn() //Metod för att byta till nästa spelare i turordning
        {
            if (totalPoints != allPoints)
            {
                playerTurn.RemoveAt(0);
                playerTurn.Add(activePlayer);
                activePlayer = playerTurn[0];
                updateGUI();
                checkComp();

                if (activePlayer.computer == false)
                {
                    foreach (Card c in cards)
                    {
                        c.Enabled = true;
                    }
                }
            }
        }

        private void initializeGame()//Metoden för att starta om hela spelet förutom splashscreen
        {
            cards = new List<Card>();
            players = new List<Player>();
            playerTurn = new List<Player>();
            winnerList = new List<Player>();
            CHAR = new ChooseCharacter();
            BG = new BakGrundPopUp();
            boardSize = new PopUpBoardSize();
            updatePortraits = true;
            CHAR.ShowDialog();
            updateGUI();
            boardSize.ShowDialog();
            updateGUI();
            BG.ShowDialog();
            updateGUI();
            StartGame();
        }

        public void updateGUI() //Metod föra att skriva ut poäng mm
        {
            lblP1ScoreN.Text = players[0].points.ToString();
            lblP2ScoreN.Text = players[1].points.ToString();
            //lblTimerTurn.Text = duration.ToString();
            #region Update correct number of gui-elements
            if (updatePortraits == true)
            {
                pictureBoxP1.BackgroundImage = players[0].potrait;
                lblP1ScoreN.Text = players[0].points.ToString();
                lblNameP1.Text = players[0].name;
                lblp1Score.Text = "Score:";
                pictureBoxP2.BackgroundImage = players[1].potrait;
                lblP2ScoreN.Text = players[1].points.ToString();
                lblNameP2.Text = players[1].name;
                lblp2Score.Text = "Score:";
                if (players.Count == 3)
                {
                    pictureBoxP3.BackgroundImage = players[2].potrait;
                    lblP3ScoreN.Text = players[2].points.ToString();
                    lblNameP3.Text = players[2].name;
                    lblp3Score.Text = "Score:";
                }
                if (players.Count == 4)
                {
                    pictureBoxP3.BackgroundImage = players[2].potrait;
                    lblP3ScoreN.Text = players[2].points.ToString();
                    lblNameP3.Text = players[2].name;
                    lblp3Score.Text = "Score:";
                    pictureBoxP4.BackgroundImage = players[3].potrait;
                    lblP4ScoreN.Text = players[3].points.ToString();
                    lblNameP4.Text = players[3].name;
                    lblp4Score.Text = "Score:";
                }
                if (players.Count == 5)
                {
                    pictureBoxP3.BackgroundImage = players[2].potrait;
                    lblP3ScoreN.Text = players[2].points.ToString();
                    lblNameP3.Text = players[2].name;
                    lblp3Score.Text = "Score:";
                    pictureBoxP4.BackgroundImage = players[3].potrait;
                    lblP4ScoreN.Text = players[3].points.ToString();
                    lblNameP4.Text = players[3].name;
                    lblp4Score.Text = "Score:";
                    pictureBoxP5.BackgroundImage = players[4].potrait;
                    lblP5ScoreN.Text = players[4].points.ToString();
                    lblNameP5.Text = players[4].name;
                    lblp5Score.Text = "Score:";
                }
                if (players.Count == 6)
                {
                    pictureBoxP3.BackgroundImage = players[2].potrait;
                    lblP3ScoreN.Text = players[2].points.ToString();
                    lblNameP3.Text = players[2].name;
                    lblp3Score.Text = "Score:";
                    pictureBoxP4.BackgroundImage = players[3].potrait;
                    lblP4ScoreN.Text = players[3].points.ToString();
                    lblNameP4.Text = players[3].name;
                    lblp4Score.Text = "Score:";
                    pictureBoxP5.BackgroundImage = players[4].potrait;
                    lblP5ScoreN.Text = players[4].points.ToString();
                    lblNameP5.Text = players[4].name;
                    lblp5Score.Text = "Score:";
                    pictureBoxP6.BackgroundImage = players[5].potrait;
                    lblP6ScoreN.Text = players[5].points.ToString();
                    lblNameP6.Text = players[5].name;
                    lblp6Score.Text = "Score:";
                }
                updatePortraits = false;
            }
            #endregion
            if (players.Count == 3)
            {
                lblP3ScoreN.Text = players[2].points.ToString();
            }
            if (players.Count == 4)
            {
                lblP3ScoreN.Text = players[2].points.ToString();
                lblP4ScoreN.Text = players[3].points.ToString();
            }
            if (players.Count == 5)
            {
                lblP3ScoreN.Text = players[2].points.ToString();
                lblP4ScoreN.Text = players[3].points.ToString();
                lblP5ScoreN.Text = players[4].points.ToString();
            }
            if (players.Count == 6)
            {
                lblP3ScoreN.Text = players[2].points.ToString();
                lblP4ScoreN.Text = players[3].points.ToString();
                lblP5ScoreN.Text = players[4].points.ToString();
                lblP6ScoreN.Text = players[5].points.ToString();
            }

            if (activePlayer != null)
            {
                pictureBoxTurn.BackgroundImage = activePlayer.potrait;
                lblPlayerTurn.Text = activePlayer.name + "!";
            }
        }

        public static void CreatePlayer(string name, Image portrait, bool computer, int AILevel)
        {
            Player player = new Player(name, portrait, computer, AILevel);
            players.Add(player);
            playerTurn.Add(player);
        }

        private void timerEndGame_Tick(object sender, EventArgs e)//3 olika alternativ - omspel, nytt spel, stäng
        {
            bool win = WhoWon();
            timerEndGame.Stop();
            endGame = new EndGame(win);
            DialogResult result = endGame.ShowDialog();

            if (result == DialogResult.Retry) //omspel
            {
                PlayAgain();
            }
            else if (result == DialogResult.OK) //Nytt spel
            {
                foreach (Card c in cards)
                {
                    this.pnlCardHolder.Controls.Remove(c);
                }
                cards.Clear();

                initializeGame();
            }
            else if (result == DialogResult.Cancel) //Stäng
            {
                creditSong.Play();
                exit.ShowDialog();
            }
        }

        public void PlayAgain() //Metod för omspel med samma inställningar
        {
            foreach (Player p in players)
            {
                p.points = 0;
                p.aiMemory.Clear();
                //chooseTurn = rand.Next(0, players.Count);
            }

            winnerList.Clear();
            randomizeIdInCardList(cards.Count);
            foreach (Card c in cards)
            {
                c.flipped = false;
            }
            totalPoints = 0;
            updateGUI();
            NewTurn();
        }

        public bool WhoWon()//Metoden som visar vinnare eller lika
        {
            bool winner = false;
            int drawPlayer = 0;

            //winnerList = players;
            foreach (Player p in players)
            {
                winnerList.Add(p);
            }
            while (winnerList.Count > 1)//jämför spelarens position [0] mot position [1] i winnerList listan
            {
                if (winnerList[0].points == winnerList[1].points)//jämför position [0] och [1] i listan och vid matchning sparas [0] i draw
                {
                    drawPlayer = winnerList[0].points;
                    winnerList.Remove(winnerList[0]);
                }
                else if (winnerList[0].points < winnerList[1].points)//om position [1] är större än [0] så tas 0an bort ur listan
                {
                    winnerList.Remove(winnerList[0]);
                }
                else if (winnerList[0].points > winnerList[1].points)//om position [0] är större än [1] så tas 1an bort ur listan
                {
                    winnerList.Remove(winnerList[1]);
                }
            }
            if (winnerList[0].points > drawPlayer)//om position [0] är större än draw så returneras vinnaren
            {
                winner = true;
            }
            return winner;
        }

        private void flipCards(Card card)
        {
            cardFlipFX.Play();
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
                foreach (Card c in flippedCards)
                {
                    foreach (Player p in players)
                    {
                        p.aiMemory.Remove(c);
                    }
                }
                flippedCards.Clear();

                // poäng delas ut
                activePlayer.points++;
                totalPoints++;
                pointsFX.Play();

                if (totalPoints == allPoints)
                {
                    timerEndGame.Start();
                    timerTurn.Stop();
                }

                duration = setDuration;
                //poäng skrivs ut
                updateGUI();
                delay(2000);
                checkComp();
            }
            else
            {
                //timerCompare.Enabled = true;
                //timerCompare.Start();
                delay(2000);
                FlipBackCards();
            }
        }

        public Card[] ComputerPlay()
        {
            int AiTurn = 0;
            Card[] cCard = new Card[2];
            Random randomWait = new Random();
            EventArgs e = new EventArgs();
            Random computerRandom = new Random();

            foreach (Card c in cards)
            {
                c.Enabled = false;
            }

            while (AiTurn < 2)
            {
                foreach (Player p in players)
                {
                    if (activePlayer.aiMemory.Count > 1)
                    {
                        foreach (Card c in p.aiMemory.ToList())
                        {
                            foreach (Card j in p.aiMemory.ToList())
                            {
                                if (c.id == j.id && p.aiMemory.IndexOf(c) != p.aiMemory.IndexOf(j))
                                {
                                    cCard[0] = c;
                                    cCard[1] = j;

                                    AiTurn = 2;
                                    return cCard;
                                }
                            }
                        }
                    }

                }

                if (AiTurn < 2)
                {
                    int cardIndex = computerRandom.Next(0, cards.Count);
                    while (cards[cardIndex].flipped == true)
                    {
                        cardIndex = computerRandom.Next(0, cards.Count);
                    }
                    foreach (Card c in cards)
                    {
                        if (cardIndex == cards.IndexOf(c) && AiTurn == 0)
                        {
                            cCard[0] = c;
                            activePlayer.aiMemory.Add(c);
                            AiTurn = 1;

                        }
                        else if (cardIndex == cards.IndexOf(c) && AiTurn == 1)
                        {
                            if (cCard[0] != c)
                            {
                                cCard[1] = c;
                                AiTurn = 2;

                                activePlayer.aiMemory.Remove(cCard[0]);
                                return cCard;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return cCard;
        }

        public void checkComp()
        {
            Random randomWait = new Random();
            EventArgs e = new EventArgs();
            if (activePlayer.computer == true && totalPoints != allPoints)
            {

                AICards = ComputerPlay();
                delay(randomWait.Next(300, 1300));
                card_Click(AICards[0], e);
                delay(randomWait.Next(700, 2000));
                card_Click(AICards[1], e);
            }
        }

        private void StartGame()
        {
            gameBoardFX.Play();
            if (columns == rows)
            {
                this.pnlCardHolder.Size = new System.Drawing.Size(600, 600);
                this.pnlCardHolder.Location = new System.Drawing.Point(340, 60);
            }
            else
            {
                this.pnlCardHolder.Location = new System.Drawing.Point(240, 60);
                this.pnlCardHolder.Size = new System.Drawing.Size((600 / rows + 5) * columns, 600);
            }
            //Nya kort instansieras och argument skickas med i för position på spelplanen
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Card card = new Card(i, j, (pnlCardHolder.Height / rows - 5), card_Click);
                    cards.Add(card);
                    this.pnlCardHolder.Controls.Add(card);
                }
            }
            lblTurnAnnounce.Text = "It's your turn:";
            randomizeIdInCardList(rows * columns); //konstruktorn ropar på metod för att blanda kortens id
            allPoints = cards.Count() / 2;
            totalPoints = 0;
            activePlayer = playerTurn[0];
            updateGUI();
            checkComp();
            updateGUI();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            splashBox.Visible = false;
            initializeGame();
        }

        //removed timer from this release as it's not working as intended
        //private void timerTurn_Tick(object sender, EventArgs e)
        //{
        //    //Skriver ut betänkertiden i sekunder och räknar tiden neråt.
        //    //lblTimerTurn.Text = duration.ToString();
        //    duration--;

        //    if (duration == 0)//Byter spelare när tiden räknat ner till 0.
        //    {
        //        timerTurn.Stop();
        //        FlipBackCards();
        //    }
        //}

        private void FlipBackCards()
        {
            flipBackFX.Play();
            //Ändrar tillbaka bild till baksidan mm..
            foreach (Card flippedcard in flippedCards.ToList())
            {
                // vid olida ändras kortens bild till baksida och listan töms
                flippedcard.Image = coverVector[BG.coverChoice];
                flippedcard.flipped = false;
                foreach (Player p in players)
                {
                    if (p.aiMemory.Count < p.AILevel)
                    {
                        p.aiMemory.Add(flippedcard);
                    }
                    else
                    {
                        p.aiMemory.RemoveAt(0);
                        p.aiMemory.Add(flippedcard);
                    }
                    flippedCards.Remove(flippedcard);
                }
            }
            // Gör alla kort klickbara igen
            updateGUI();
            NewTurn();
        }

        public void delay(int _delayTime)
        {
            int increment = 0;
            while (increment < _delayTime)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
                increment += 2;
            }
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            totalPoints = allPoints;
            creditSong.Play();
            exit.ShowDialog();
        }
    }
}