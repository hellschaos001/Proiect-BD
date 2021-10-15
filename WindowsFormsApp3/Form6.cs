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

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "SELECT * FROM PRODUSE_COMANDA";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "INSERT INTO PRODUSE_COMANDA (ID_COMANDA,ID_PRODUS) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Adaugat cu succes!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "UPDATE PRODUSE_COMANDA SET ID_PRODUS = '" + textBox3.Text + "' WHERE ID_COMANDA = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie modificata cu succes !!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "DELETE FROM PRODUSE_COMANDA WHERE ID_COMANDA = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie stearsa cu succes !!");
        }
    }
}
