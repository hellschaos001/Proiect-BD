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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

       

        private void button6_Click_1(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "SELECT * FROM CUPON_REDUCERE";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "INSERT INTO CUPON_REDUCERE (ID_CUPON,DATA_EXPIRARE,DISCOUNT) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Adaugat cu succes!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "UPDATE CUPON_REDUCERE SET DATA_EXPIRARE = '" + textBox3.Text + "',DISCOUNT = '" + textBox4.Text + "' WHERE ID_CUPON = '" +textBox2.Text+ "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("Informatie modificata cu succes !!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "DELETE FROM CUPON_REDUCERE WHERE ID_CUPON = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie stearsa cu succes !!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
