using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models;
using VirtualDoorman.Models.OrderKeyModels;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.OrderAccessCard
{
    public class CardType{
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public partial class OrderAccessCardPageFour : ContentPage
    {
        private Cart cart;
        private CardDataService _service = new CardDataService();
        private IList<CardData> listOfCards;

        public OrderAccessCardPageFour()
        {
            InitializeComponent();
        }

        public OrderAccessCardPageFour(Cart cart)
        {
            this.cart = cart;
            InitializeComponent();
            Init();
            populatePage(cart);
        }

        void Init()
		{
			BackgroundColor = Constants.BackgroundColor;
		}

		async private void populatePage(Cart cart)
		{
            CardListResponse res = await _service.RetreiveCardListData(cart.loginGUID);
            Debug.WriteLine($"CardListResponse Received: {res.Message}");
            listOfCards = res.Result;
            foreach(var card in listOfCards){
                pickerCard.Items.Add(card.Number);
            }
            foreach(var card in GetAcceptedCards())
                pickerCardType.Items.Add(card.Type);

            for (int i = 1; i <= 9;i++){
                pickerCardMonth.Items.Add($"0{i.ToString()}");
            }
            for (int i = 10; i <= 12;i++){
                pickerCardMonth.Items.Add(i.ToString());
            }

            for (int i = 2017; i <= 2037;i++){
                pickerCardYear.Items.Add(i.ToString());
            }
		}

		void OnCardPickerSelected(object sender, System.EventArgs e)
		{
            var selectedCard = listOfCards[pickerCard.SelectedIndex];  
            Debug.WriteLine(selectedCard.Name);
            cardFullName.Text = selectedCard.Name;
		}

		//Temporarily Hardcoded data
        public List<CardType> GetAcceptedCards()
		{
            return new List<CardType>
			{
                new CardType{Id=1, Type="Visa"},
				new CardType{Id=2, Type="American Express"},
                new CardType{Id=3, Type="Discover"},
				new CardType{Id=4, Type="Mastercard"},
				new CardType{Id=5, Type="Diners Club"},
				new CardType{Id=6, Type="JCB"}
			};
		}

	}
}
