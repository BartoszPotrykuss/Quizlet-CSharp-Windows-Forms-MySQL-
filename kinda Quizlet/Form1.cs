using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kinda_Quizlet
{
    public partial class Form1 : Form
    {
        static string connectionString =    "server=127.0.0.1;" +
                                            "user=root;" +
                                            "password=;" +
                                            "database=quizlet";
        static MySqlConnection connection = new MySqlConnection(connectionString);
        static string query = "SELECT * FROM słowa;";
        readonly MySqlCommand command = new MySqlCommand(query, connection);

        static List<Slowo> list = new List<Slowo>();
        int i = 0;
        string box2;
        int poprawne = 0, niepoprawne = 0, pozostalo;
        int nauczoneSlowa;
        int liczbaRund = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                bStart.Visible = true;
                button1.Visible = false;
            }
            catch
            {
                Close();
            }
            finally
            {
                connection.Close();
            }
        }

        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == list[i].angielski)
                {
                    poprawnosc.Text = "dobra odpowiedź";
                    list[i].nauczone = true;
                    poprawne++;
                    await Task.Run(() => moveBar(progressBar1));
                }
                else
                {
                    poprawnosc.Text = $"Zła odpowiedź. {list[i].polski} - {list[i].angielski}";
                    LPoprawa.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Enabled = false;
                    list[i].nauczone = false;
                    box2 = list[i].angielski;
                    textBox2.Focus();
                    niepoprawne++;
                    await Task.Run(() => moveBar(progressBar2));
                }
                pozostalo--;
                await Task.Run(() => moveBar(progressBar3));
                i++;
                if (list.All(x => x.nauczone == true))
                {
                    MessageBox.Show("Gratulacje, znasz już wszystkie słowa z bazy!");
                    zmienDane();
                }
                else
                {
                    if (!textBox2.Visible) NowaRunda();
                }
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string polski = reader.GetString("Polski");
                        string angielski = reader.GetString("Angielski");
                        int nauczone = reader.GetInt32("nauczone");
                        bool naucz;
                        if (nauczone == 0) naucz = false;
                        else naucz = true;
                        Slowo slowo = new Slowo(polski, angielski, id, naucz);
                        list.Add(slowo);
                    }    
                }
            }
            catch
            {
                Close();
            }
            finally
            {
                connection.Close();
            }
            if (list.All((x) => x.nauczone))
            {
                MessageBox.Show("Wszystkie słowa już nauczone");
                Close();
            }
            
            polski.Text = list.FirstOrDefault(x => !x.nauczone).polski;
            i = list.First(x => !x.nauczone).id - 1;
            pozostalo = list.Count();
            nauczoneSlowa = list.Count();
            lPozostalo.Text = pozostalo.ToString();

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == box2)
                {
                    LPoprawa.Visible = false;
                    textBox2.Visible = false;
                    textBox1.Enabled = true;
                    textBox2.Visible = false;
                    textBox2.Text = "";
                    textBox1.Focus();
                    NowaRunda();
                }    
            }
        }

        public void moveBar(ProgressBar progressBar)
        {
            int doIluPrzesun = 100 / nauczoneSlowa;
            for (int i = 0; i < doIluPrzesun; i++)
            {
                Thread.Sleep(1);

                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value++;
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz zapisać nauczone słowa?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                zmienDane();
            }
            e.Cancel = false;
        }

        public void NowaRunda()
        {
            if (i >= nauczoneSlowa || i >= list.Count())
            {
                i = 0;
                foreach (var item in list)
                {
                    if (!item.nauczone) pozostalo++;
                }
                LPoprawne.Text = poprawne.ToString();
                lNiepoprawne.Text = niepoprawne.ToString();
                lPozostalo.Text = pozostalo.ToString();
                liczbaRund++;
                MessageBox.Show($"{liczbaRund} runda");
                poprawne = 0;
                niepoprawne = 0;
                LPoprawne.Text = poprawne.ToString();
                lNiepoprawne.Text = niepoprawne.ToString();
                lPozostalo.Text = pozostalo.ToString();
                nauczoneSlowa = pozostalo;
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
            }
            while (list[i].nauczone)
            {
                i++;
                if (i >= list.Count) break;
            }

            textBox1.Text = "";
            polski.Text = list[i].polski;

            LPoprawne.Text = poprawne.ToString();
            lNiepoprawne.Text = niepoprawne.ToString();
            lPozostalo.Text = pozostalo.ToString();
        }
        

       public void zmienDane()
        {
            string IdDoZmiany = "";
            foreach (var item in list)
            {
                if (item.nauczone) IdDoZmiany += $"{item.id},";
            }
            IdDoZmiany = IdDoZmiany.Remove(IdDoZmiany.Length - 1);
            label5.Text = IdDoZmiany;
            string query = $"UPDATE słowa SET nauczone = '1' WHERE id IN ({IdDoZmiany});";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    
                }
                catch
                {
                    Console.WriteLine("Błąd");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
