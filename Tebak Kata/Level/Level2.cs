using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tebak_Kata.Hint;
using MySql.Data.MySqlClient;

namespace Tebak_Kata.Level
{
    public partial class Level2 : Form
    {
        Thread th;
        string jwb;
        public static TimeSpan timeleft = TimeSpan.FromMinutes(1);
        public Level2()
        {
            InitializeComponent();
            timer1.Start();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tebak_kata;";
            // Your query,
            string query = "SELECT id_quiz, level, kosakata, kategori, jawaban, hint FROM `quiz` q, `kategori_quiz` k, `jawaban_quiz` j , `hint` h where q.id_kategori = k.id_kategori and q.id_jawaban = j.id_jawaban and q.id_hint = h.id_hint and id_quiz=2;";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        jwb = reader.GetString(4);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(string.Equals(Jawaban.Text, jwb, StringComparison.OrdinalIgnoreCase))
            {
                timer1.Stop();
                CorrectAns2 ca = new CorrectAns2();
                ca.Show();
            } else
            {
                timer1.Stop();
                IncorrectAns2 ia = new IncorrectAns2();
                ia.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Level);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Level(object obj)
        {
            Application.Run(new SantaiMode());
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            hint2 h2 = new hint2();
            h2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft.TotalSeconds > 0)
            {
                timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            }

            if (timeleft.TotalSeconds == 0)
            {
                timer1.Stop();
                IncorrectAns2 ia = new IncorrectAns2();
                ia.Show();

            }

            Timer.Text = timeleft.ToString("mm\\:ss");

        }
    }
}
