using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            Task<int> contentLength = GetUrlContentLengthAsync();

            //.... .........
            // ........

            int pizza = await contentLength;

            this.label1.Text = "Length: " + contentLength;
        }

        public async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();

            Task<string> getStringTask =  client.GetStringAsync("https://docs.microsoft.com/dotnet");

            DoIndependentWork();

            string contents = await getStringTask;

            return contents.Length;
        }

        void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
