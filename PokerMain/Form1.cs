using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerMain
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public int PlayerCounter = 1; // For determining Player turns
    public int RoundCounter = 1;  // For determining Circular round
    public int GameCounter = 1;   // For Determining number of Games PLayed
    //asdasd

    List<Players> PlayersList = new List<Players>();
    List<Card> ShuffledCards = new List<Card>();

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btn_Shuffle_Click(object sender, EventArgs e)
    {
      ShuffledCards = ShuffleCards(CreateDecks());
      PlayersList = AddPlayers();
      PlayersList = DealCards(PlayersList, ShuffledCards);
      ((ListBox)this.chk_Player1).DataSource = PlayersList.ElementAt(0).PlayerCards;
      ((ListBox)this.chk_Player1).DisplayMember = "ToStringToShow";
      ((ListBox)this.chk_Player2).DataSource = PlayersList.ElementAt(1).PlayerCards;
      ((ListBox)this.chk_Player2).DisplayMember = "ToStringToShow";
      ((ListBox)this.chk_Player3).DataSource = PlayersList.ElementAt(2).PlayerCards;
      ((ListBox)this.chk_Player3).DisplayMember = "ToStringToShow";
   
      pnl_Player1.Enabled = false;
      pnl_Player2.Enabled = false;
      pnl_Player3.Enabled = false;
    }

    private List<Players> DealCards(List<Players> PlayersList, List<Card> ShuffledCards)
    {
      for (int i = 0, j = 0; i < (PlayersList.Count * 5); i++)
      {
        Card obj_Card = ShuffledCards.ElementAt(i);
        if (j == PlayersList.Count)
          j = 0;

        Players obj_Player = PlayersList.ElementAt(j++);
        obj_Player.PlayerCards.Add(obj_Card);

      }
      return PlayersList;
    }

    private List<Players> AddPlayers()
    {
      List<Players> Players = new List<Players>();
      for (int i = 0; i < Convert.ToInt32(txt_Players.Text); i++)
      {
        Players obj = new Players();
        obj.amount = 100.00;
        obj.bet = false;
        obj.Call = false;
        obj.check = false;
        obj.Name = "Player" + i;
        obj.Raise = false;
        obj.isDealer = false;
        obj.PlayerCards = new List<Card>();
        Players.Add(obj);
      }
      return Players;

    }

    private List<Card> ShuffleCards(List<Card> obj_Card)
    {
      return obj_Card.OrderBy(a => Guid.NewGuid()).ToList();
    }

    private List<Card> CreateDecks()
    {
      List<Card> deck = new List<Card>();
      for (int i = 0; i < Convert.ToInt32(txt_Decks.Text); i++)
      {
        foreach (CardsRank r in Enum.GetValues(typeof(CardsRank)))
        {
          foreach (CardSuit s in Enum.GetValues(typeof(CardSuit)))
          {
            deck.Add(new Card((int)s, (int)r));
          }
        }
        deck.Add(new Card(0, 0));
        deck.Add(new Card(0, 0));
      }
      return deck;
    }

    public class Card
    {
      private readonly int _suit;
      private readonly int _rank;
      private readonly string _ToStringToShow;

      public Card(int suit, int rank)
      {
        _suit = suit;  // 0 = Hearts, 1 = Diamonds ...
        _rank = rank;  // 1 = ace, 2 = two
      }

      public int Suit
      {
        get { return _suit; }
      }

      public int Value
      {
        get { return _rank; }
      }

      public string ToStringToShow
      {
        get {
          if (_suit == 0)
            return "JK";
          else
            return Enum.Parse(typeof(CardSuit),_suit.ToString()) + " " +  Enum.Parse(typeof(CardsRank),_rank.ToString()); }
      }
    }

    public enum PokerHand
    {
      HighCard = 11,
      Pair = 10,
      TwoPair = 9,
      ThreeOfKind = 8,
      Straight = 7,
      Flush = 6,
      FullHouse = 5,
      FourOfKind = 4,
      StraightFlush = 3,
      RoyalFlush = 2,
      FiveAces = 1
    }

    public enum CardSuit
    {
      Hearts = 1,
      Diamonds = 2,
      Clubs = 3,
      Spades = 4
    }

    public enum CardsRank
    {
      Ace = 1,
      Two = 2,
      Three = 3,
      Four = 4,
      Five = 5,
      Six = 6,
      Seven = 7,
      Eight = 8,
      Nine = 9,
      Ten = 10,
      Jack = 11,
      Queen = 12,
      King = 13
    }

    public class Players
    {
      public string Name { get; set; }
      public bool Call { get; set; }
      public bool Raise { get; set; }
      public bool bet { get; set; }
      public bool fold { get; set; }
      public bool check { get; set; }
      public double amount { get; set; }
      public bool isDealer { get; set; }
      public List<Card> PlayerCards { get; set; }
    }

    private void btn_StartGame_Click(object sender, EventArgs e)
    {
      btn_Shuffle.Enabled = false;
      GetPlayerCounter();
      
      

    }

    private void GetPlayerCounter()
    {
      if (PlayerCounter == 1)
      {
        pnl_Player1.Enabled = true;
        pnl_Player2.Enabled = false;
        pnl_Player3.Enabled = false;
        PlayerCounter++;
      }
      else if (PlayerCounter == 2)
      {
        pnl_Player1.Enabled = false;
        pnl_Player2.Enabled = true;
        pnl_Player3.Enabled = false;
        PlayerCounter++;
      } 
      else 
      {
        pnl_Player1.Enabled = false;
        pnl_Player2.Enabled = false;
        pnl_Player3.Enabled = true;
        PlayerCounter = 1;
      }

     

    }




    
  }
}
