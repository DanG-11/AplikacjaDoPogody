using System.Timers;
using Newtonsoft.Json;

namespace AplikacjaDoPogody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FetchWeatherData();
        }

        private static System.Timers.Timer IdkTimer;

        private void BtnPokazPogode_Click(object sender, EventArgs e)
        {
            TmrPogoda_Tick(null, null);
        }

        private void FetchWeatherData()
        {
            IdkTimer = new System.Timers.Timer();
            IdkTimer.Interval = 90000;

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,rain&timezone=auto");

            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;

            string result = response.Content.ReadAsStringAsync().Result;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result);

            RchTxtBoxPogoda.ResetText();
            RchTxtBoxPogoda.AppendText(IdkTimer.Interval.ToString() + "\n\n");
            RchTxtBoxPogoda.AppendText("Temperatura: " + myDeserializedClass.current.temperature_2m.ToString() + "°C" + "\n");
            RchTxtBoxPogoda.AppendText("Wilgotnoœæ: " + myDeserializedClass.current.relative_humidity_2m.ToString() + "%" + "\n");
            RchTxtBoxPogoda.AppendText("Informacje o opadach: " + myDeserializedClass.current.rain.ToString() + "mm" + "\n");
        }

        private void TmrPogoda_Tick(object sender, EventArgs e)
        {
            FetchWeatherData();
        }
    }
}
