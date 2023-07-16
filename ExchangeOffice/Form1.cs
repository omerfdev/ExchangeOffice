using System.Text.Json;

namespace ExchangeOffice
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			while (true) { await GetCurrency(); }

		}

		private async Task GetCurrency()
		{
			string[] moneyType = { "EUR", "USD", "GBP", "AUD", "CHF", "JPY", "SAR","CAD" ,"KWD","AZN"};
			using (HttpClient client = new HttpClient())
			{
				foreach (string money in moneyType)
				{
					string url = "http://dovizkurlari-l6vtviaacq-uc.a.run.app/api/doviz/" + money;
					HttpResponseMessage response = await client.GetAsync(url);
					if (response.IsSuccessStatusCode)
					{
						string jsonResponse = await response.Content.ReadAsStringAsync();
						Currency currency = JsonSerializer.Deserialize<Currency>(jsonResponse);
						DateTime currentTime = DateTime.Now;
						lblExchangeOffice.Text = currentTime.ToString();
						lblCurrency.Text = currency.CurrencyName;
						lblValue.Text = currency.ForexBuying;
					}
					else
					{
						MessageBox.Show($"{response.StatusCode}");
					}
				}
			}
		}

		public class Currency
		{
			public string CurrencyName { get; set; }
			public string ForexBuying { get; set; }
		}
	}
}
