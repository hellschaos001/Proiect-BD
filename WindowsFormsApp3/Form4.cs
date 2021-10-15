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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "SELECT * FROM CURIERI";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "INSERT INTO CURIERI (ID_CURIER,NUME,PRENUME,TELEFON,DATA_NASTERII) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Adaugat cu succes!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "UPDATE CURIERI SET NUME = '" + textBox3.Text + "',PRENUME = '" + textBox4.Text + "',TELEFON = '" + textBox5.Text + "',DATA_NASTERII = '" + textBox6.Text + "' WHERE ID_CURIER = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("Informatie modificata cu succes !!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "DELETE FROM CURIERI WHERE ID_CURIER = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie stearsa cu succes !!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
