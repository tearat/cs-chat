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
        private string serverUrl = "http://get.ar";
        private string serverUrlPost = "http://get.ar/post.php";
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
            HttpResponseMessage response = await client.GetAsync(serverUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Message[] parsed = JsonConvert.DeserializeObject<Message[]>(responseBody);

            foreach (Message message in parsed)
            {
                string title = "";
                title += message.name + ": " + message.message;
                listLabels.Items.Add(title);
            }
        }

        private async void SendMessage()
        {
            if (textBoxName.Text != "" && textBoxMessage.Text != "")
            {
                var message = new Dictionary<string, string>
                {
                    { "name", textBoxName.Text },
                    { "message", textBoxMessage.Text }
                };

                textBoxMessage.Text = "";

                var content = new FormUrlEncodedContent(message);
                var response = await client.PostAsync(serverUrlPost, content);
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
