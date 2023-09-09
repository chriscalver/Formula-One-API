using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string favText = "chriscalver@hotmail.com";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            // requestHeaders.Add("Accept", "applicationjson");
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync("http://ergast.com/api/f1/drivers.json");
            HttpResponseMessage httpResponseMessage = httpResponse.Result;

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responsData = responseContent.ReadAsStringAsync();
            string data = responsData.Result;

            Root deserialized = JsonConvert.DeserializeObject<Root>(data);

            txtOutput2.Text = data;
            lbldriver1.Text = deserialized.MRData.DriverTable.Drivers[0].familyName;
            txtOutput.Text = deserialized.MRData.DriverTable.Drivers[0].familyName;

            httpClient.Dispose();

        }
    }
}