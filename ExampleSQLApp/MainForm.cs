using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        private MySqlConnection connection;


        public MainForm()
        {
            InitializeComponent();
            this.connection = DBConnect();
            LoadPosts();
        }

        private MySqlConnection DBConnect()
        {
            string connectionParams = "server=localhost;user=root;database=cs_chat;password=;";
            MySqlConnection connection = new MySqlConnection(connectionParams);
            connection.Open();
            label_informer.Text = "DB cs_chat connected";
            return connection;
        }

        private void LoadPosts()
        {
            listLabels.Items.Clear();
            string sql = "SELECT name, message, created_at FROM messages;";
            MySqlCommand query = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                string title = "";
                title += reader[0].ToString() + ": " + reader[1].ToString();
                listLabels.Items.Add(title);
            }
            reader.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Не уходи. Останься ещё немного...\nНеужели ты правда хочешь этого?..";
            string caption = "Выход";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.connection.Close();
                this.Close();
            }
            else
            {
                
            }
        }

        private void Button_send_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "" && textBox_message.Text != "")
            {
                string name = textBox_name.Text;
                string message = textBox_message.Text;
                string sql = String.Format(@"INSERT INTO messages (name,message) VALUES ('{0}','{1}');", name, message); ;
                MySqlCommand query = new MySqlCommand(sql, this.connection);
                MySqlDataReader reader = query.ExecuteReader();
                textBox_message.Text = null;
                reader.Close();
                LoadPosts();
            }
        }
    }
}
