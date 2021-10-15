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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Setam conexiunea cu baza de date
        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.VEHICULE' table. You can move, or remove it, as needed.
            this.vEHICULETableAdapter.Fill(this.databaseDataSet.VEHICULE);
            // TODO: This line of code loads data into the 'databaseDataSet.RESTAURANTE' table. You can move, or remove it, as needed.
            this.rESTAURANTETableAdapter.Fill(this.databaseDataSet.RESTAURANTE);
            // TODO: This line of code loads data into the 'databaseDataSet.PRODUSE_COMANDA' table. You can move, or remove it, as needed.
            this.pRODUSE_COMANDATableAdapter.Fill(this.databaseDataSet.PRODUSE_COMANDA);
            // TODO: This line of code loads data into the 'databaseDataSet.PRODUSE' table. You can move, or remove it, as needed.
            this.pRODUSETableAdapter.Fill(this.databaseDataSet.PRODUSE);
            // TODO: This line of code loads data into the 'databaseDataSet.CURIERI' table. You can move, or remove it, as needed.
            this.cURIERITableAdapter.Fill(this.databaseDataSet.CURIERI);
            // TODO: This line of code loads data into the 'databaseDataSet.CUPON_REDUCERE' table. You can move, or remove it, as needed.
            this.cUPON_REDUCERETableAdapter.Fill(this.databaseDataSet.CUPON_REDUCERE);
            // TODO: This line of code loads data into the 'databaseDataSet.COMENZI' table. You can move, or remove it, as needed.
            this.cOMENZITableAdapter.Fill(this.databaseDataSet.COMENZI);
            // TODO: This line of code loads data into the 'databaseDataSet.CLIENTI' table. You can move, or remove it, as needed.
            this.cLIENTITableAdapter.Fill(this.databaseDataSet.CLIENTI);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                cnn.Open();
                String query = "INSERT INTO CLIENTI (ID_CLIENT,NUME,PRENUME,DATA_NASTERII,TELEFON,EMAIL,ID_CUPON) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
                SDA.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Adaugat cu succes!!!");
            }
            else
            {
                cnn.Open();
                String query = "INSERT INTO CLIENTI (ID_CLIENT,NUME,PRENUME,DATA_NASTERII,TELEFON,EMAIL) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
                SDA.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Adaugat cu succes!!!");
            }    

        }
        private void button6_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "SELECT * FROM CLIENTI";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                cnn.Open();
                String query2 = "UPDATE CLIENTI SET NUME = '" + textBox3.Text + "',PRENUME = '" + textBox4.Text + "',DATA_NASTERII = '" + textBox5.Text + "',TELEFON = '" + textBox6.Text + "', EMAIL = '" + textBox7.Text + "',ID_CUPON = NULL WHERE ID_CLIENT = '" + textBox2.Text + "'";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, cnn);
                SDA2.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Informatie modificata cu succes!!!");
            }
            else
            {
                cnn.Open();
                String query1 = "UPDATE CLIENTI SET NUME = '" + textBox3.Text + "',PRENUME = '" + textBox4.Text + "',DATA_NASTERII = '" + textBox5.Text + "',TELEFON = '" + textBox6.Text + "', EMAIL = '" + textBox7.Text + "',ID_CUPON = '" + textBox8.Text + "' WHERE ID_CLIENT = '" + textBox2.Text + "'";
                SqlDataAdapter SDA1 = new SqlDataAdapter(query1, cnn);
                SDA1.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Informatie modificata cu succes!!!");
            }
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn.Open();
            String query = "DELETE FROM CLIENTI WHERE ID_CLIENT = '" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cnn);
            SDA.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Informatie stearsa cu succes !!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
