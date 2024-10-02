namespace AplikacjaDoPogody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPokazPogode_Click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&hourly=temperature_2m,relative_humidity_2m,rain&timezone=auto");

            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;

            string result = response.Content.ReadAsStringAsync().Result;

            

            Hourly PodogaGodzinowo = new Hourly()
            {
                
            };

        }
    }
}
