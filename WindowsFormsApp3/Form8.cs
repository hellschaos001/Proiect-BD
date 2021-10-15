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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "SELECT * FROM VEHICULE";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox6.Text == "")
            {
                cnn.Open();
                String query = "INSERT INTO VEHICULE (ID_VEHICUL,NUME,TIP,NUMAR_IMATRICULARE) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
                SDA.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Adaugat cu succes!!!");
            }
            else
            {
                cnn.Open();
                String query = "INSERT INTO VEHICULE (ID_VEHICUL,NUME,TIP,NUMAR_IMATRICULARE,ID_CURIER) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
                SDA.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Adaugat cu succes!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox6.Text == "")
            {
                cnn.Open();
                String query = "UPDATE VEHICULE SET NUME = '" + textBox3.Text + "',TIP = '" + comboBox1.Text + "',NUMAR_IMATRICULARE = '" + textBox5.Text + "',ID_CURIER = NULL WHERE ID_VEHICUL = '" + textBox2.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
                SDA.SelectCommand.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Informatie modificata cu succes !!");
            }
            else
            {
                cnn.Open();
                String query = "UPDATE VEHICULE SET NUME = '" + textBox3.Text + "',TIP = '" + comboBox1.Text + "',NUMAR_IMATRICULARE = '" + textBox5.Text + "',ID_CURIER = '" + textBox6.Text + "' WHERE ID_VEHICUL = '" + textBox2.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
                SDA.SelectCommand.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Informatie modificata cu succes !!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "DELETE FROM VEHICULE WHERE ID_VEHICUL = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie stearsa cu succes !!");
        }
    }
}