using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        private string server_url = "http://get.ar";
        private string server_url_post = "http://get.ar/post.php";
        private static readonly HttpClient client = new HttpClient();

        private class Message
        {
            public string name { get; set; }
            public string message { get; set; }
        }


        public MainForm()
        {
            InitializeComponent();
            LoadPosts();
        }

        private async void LoadPosts()
        {
            listLabels.Items.Clear();
            HttpResponseMessage response = await client.GetAsync(server_url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Message[] parsed = JsonConvert.DeserializeObject<Message[]>(responseBody);

            int count = 0;
            foreach (Message message in parsed)
            {
                string title = "";
                title += message.name + ": " + message.message;
                listLabels.Items.Add(title);
                count++;
            }
        }

        private async void SendMessage()
        {
            if (textBox_name.Text != "" && textBox_message.Text != "")
            {
                var message = new Dictionary<string, string>
                {
                    { "name", textBox_name.Text },
                    { "message", textBox_message.Text }
                };

                textBox_message.Text = "";

                var content = new FormUrlEncodedContent(message);
                var response = await client.PostAsync(server_url_post, content);
                var responseString = await response.Content.ReadAsStringAsync();
                LoadPosts();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Button_send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            LoadPosts();
        }

        private void textBox_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }
    }
}
