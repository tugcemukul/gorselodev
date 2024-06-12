using gorselodev.Model;
using System.Text.Json;

namespace gorselodev;

public partial class Kurlar : ContentPage
{
	public Kurlar()
	{
		InitializeComponent();
	}

	private async void ContentPage_Appearing(object sender, EventArgs e)
	{
		await Load();
	}

	List <kurItem> Kurlarss;
	private async Task Load()
	{
		string jsonData = await KurlariYukle();

		var json = JsonSerializer.Deserialize<Model.kurItem.Root>(jsonData);

		Kurlarss = new List<kurItem>();

		Kurlarss.Add(new kurItem()
		{
			Doviz = "Dolar",
			Alis=json.USD.alis,
			Satis=json.USD.satis,
			Fark=json.USD.degisim,
			Yon=json.USD.yon,

		});

        Kurlarss.Add(new kurItem()
        {
            Doviz = "Euro",
            Alis = json.EUR.alis,
            Satis = json.EUR.satis,
            Fark = json.EUR.degisim,
            Yon = json.EUR.yon,

        });

        Kurlarss.Add(new kurItem()
        {
            Doviz = "Sterlin",
            Alis = json.GBP.alis,
            Satis = json.GBP.satis,
            Fark = json.GBP.degisim,
            Yon = json.GBP.yon,

        });

        Kurlarss.Add(new kurItem()
        {
            Doviz = "Gram Altýn",
            Alis = json.GA.alis,
            Satis = json.GA.satis,
            Fark = json.GA.degisim,
            Yon = json.GA.yon,

        });


        Kurlarss.Add(new kurItem()
        {
            Doviz = "Çeyrek",
            Alis = json.C.alis,
            Satis = json.C.satis,
            Fark = json.C.degisim,
            Yon = json.C.yon,

        });

        Kurlarss.Add(new kurItem()
        {
            Doviz = "Gümüþ",
            Alis = json.GAG.alis,
            Satis = json.GAG.satis,
            Fark = json.GAG.degisim,
            Yon = json.GAG.yon,

        });

        Kurlarss.Add(new kurItem()
        {
            Doviz = "Bitcoin",
            Alis = json.BTC.alis,
            Satis = json.BTC.satis,
            Fark = json.BTC.degisim,
            Yon = json.BTC.yon,

        });

        Kurlarss.Add(new kurItem()
        {
            Doviz = "Etherium",
            Alis = json.ETH.alis,
            Satis = json.ETH.satis,
            Fark = json.ETH.degisim,
            Yon = json.ETH.yon,

        });

        listDoviz.ItemsSource = Kurlarss;
    }

    private async Task<string> KurlariYukle()
    {
		string jsonData = "";
        HttpClient client = new HttpClient();
		string url = "https://api.genelpara.com/embed/altin.json";
		using HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        jsonData = await response.Content.ReadAsStringAsync();

		return jsonData;
    }
}