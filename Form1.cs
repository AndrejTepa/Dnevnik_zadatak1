using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dnevnik
{
    public partial class Form1 : Form
    {
            int broj_sloga = 0;
            DataTable dt;
            int redovi, kolone;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            /*
            SqlConnection veza = new SqlConnection("Data Source = DESKTOP-AJNTOM8; Initial Catalog = dnevnik; Integrated Security=true; ");
            veza.Open();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = veza;
            komanda.CommandText = ("Select * from ucenici");
            SqlDataReader reader = komanda.ExecuteReader();
            reader.Read();
            textBox2.Text = reader[0].ToString();
            textBox1.Text = reader[1].ToString();
            textBox3.Text = reader[2].ToString();
            textBox4.Text = reader[3].ToString();
            textBox5.Text = reader[4].ToString();
            */
            SqlDataAdapter unos = new SqlDataAdapter("Select * from ucenici", "Data Source = DESKTOP-AJNTOM8; Initial Catalog = dnevnik; Integrated Security=true; ");
            dt = new DataTable();
            unos.Fill(dt);
            redovi = dt.Rows.Count;
            kolone = dt.Columns.Count;
            textBox2.Text = dt.Rows[broj_sloga][0].ToString();
            textBox1.Text = dt.Rows[broj_sloga][1].ToString();
            textBox3.Text = dt.Rows[broj_sloga][2].ToString();
            textBox4.Text = dt.Rows[broj_sloga][3].ToString();
            textBox5.Text = dt.Rows[broj_sloga][4].ToString();
                    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (broj_sloga > 0)
            {
                broj_sloga--;
                textBox2.Text = dt.Rows[broj_sloga][0].ToString();
                textBox1.Text = dt.Rows[broj_sloga][1].ToString();
                textBox3.Text = dt.Rows[broj_sloga][2].ToString();
                textBox4.Text = dt.Rows[broj_sloga][3].ToString();
                textBox5.Text = dt.Rows[broj_sloga][4].ToString();
            }
            else
            {
                broj_sloga = redovi-1;
                textBox2.Text = dt.Rows[broj_sloga][0].ToString();
                textBox1.Text = dt.Rows[broj_sloga][1].ToString();
                textBox3.Text = dt.Rows[broj_sloga][2].ToString();
                textBox4.Text = dt.Rows[broj_sloga][3].ToString();
                textBox5.Text = dt.Rows[broj_sloga][4].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broj_sloga = redovi - 1;
            textBox2.Text = dt.Rows[broj_sloga][0].ToString();
            textBox1.Text = dt.Rows[broj_sloga][1].ToString();
            textBox3.Text = dt.Rows[broj_sloga][2].ToString();
            textBox4.Text = dt.Rows[broj_sloga][3].ToString();
            textBox5.Text = dt.Rows[broj_sloga][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            textBox2.Text = dt.Rows[broj_sloga][0].ToString();
            textBox1.Text = dt.Rows[broj_sloga][1].ToString();
            textBox3.Text = dt.Rows[broj_sloga][2].ToString();
            textBox4.Text = dt.Rows[broj_sloga][3].ToString();
            textBox5.Text = dt.Rows[broj_sloga][4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (broj_sloga < (redovi - 1))
            {
                broj_sloga++;
                textBox2.Text = dt.Rows[broj_sloga][0].ToString();
                textBox1.Text = dt.Rows[broj_sloga][1].ToString();
                textBox3.Text = dt.Rows[broj_sloga][2].ToString();
                textBox4.Text = dt.Rows[broj_sloga][3].ToString();
                textBox5.Text = dt.Rows[broj_sloga][4].ToString();
            }
            else 
            {
                broj_sloga = 0;
                textBox2.Text = dt.Rows[broj_sloga][0].ToString();
                textBox1.Text = dt.Rows[broj_sloga][1].ToString();
                textBox3.Text = dt.Rows[broj_sloga][2].ToString();
                textBox4.Text = dt.Rows[broj_sloga][3].ToString();
                textBox5.Text = dt.Rows[broj_sloga][4].ToString();

            }
        }

    }
}
