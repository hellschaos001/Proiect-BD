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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "SELECT * FROM COMENZI";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "INSERT INTO COMENZI (ID_COMANDA,ADRESA,DETALII_LIVRATOR,TIMP_LIVRARE,DATA,CANTITATE,ID_CLIENT,ID_CURIER) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox1.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Adaugat cu succes!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "UPDATE COMENZI SET ADRESA = '" + textBox3.Text + "',DETALII_LIVRATOR = '"+textBox4.Text+"',TIMP_LIVRARE = '" + textBox5.Text + "',DATA = '" + textBox6.Text + "', CANTITATE = '" + textBox7.Text + "',ID_CLIENT = '" + textBox8.Text + "',ID_CURIER = '" + textBox1.Text + "' WHERE ID_COMANDA = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("Informatie modificata cu succes !!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "DELETE FROM COMENZI WHERE ID_COMANDA = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie stearsa cu succes !!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
