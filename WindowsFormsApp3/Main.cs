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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.VEHICULE' table. You can move, or remove it, as needed.
            this.vEHICULETableAdapter.Fill(this.databaseDataSet1.VEHICULE);
            // TODO: This line of code loads data into the 'databaseDataSet1.RESTAURANTE' table. You can move, or remove it, as needed.
            this.rESTAURANTETableAdapter.Fill(this.databaseDataSet1.RESTAURANTE);
            // TODO: This line of code loads data into the 'databaseDataSet1.PRODUSE_COMANDA' table. You can move, or remove it, as needed.
            this.pRODUSE_COMANDATableAdapter.Fill(this.databaseDataSet1.PRODUSE_COMANDA);
            // TODO: This line of code loads data into the 'databaseDataSet1.PRODUSE' table. You can move, or remove it, as needed.
            this.pRODUSETableAdapter.Fill(this.databaseDataSet1.PRODUSE);
            // TODO: This line of code loads data into the 'databaseDataSet1.CURIERI' table. You can move, or remove it, as needed.
            this.cURIERITableAdapter.Fill(this.databaseDataSet1.CURIERI);
            // TODO: This line of code loads data into the 'databaseDataSet1.CUPON_REDUCERE' table. You can move, or remove it, as needed.
            this.cUPON_REDUCERETableAdapter.Fill(this.databaseDataSet1.CUPON_REDUCERE);
            // TODO: This line of code loads data into the 'databaseDataSet1.COMENZI' table. You can move, or remove it, as needed.
            this.cOMENZITableAdapter.Fill(this.databaseDataSet1.COMENZI);
            // TODO: This line of code loads data into the 'databaseDataSet1.CLIENTI' table. You can move, or remove it, as needed.
            this.cLIENTITableAdapter.Fill(this.databaseDataSet1.CLIENTI);
        }
        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            String query1 = "SELECT * FROM CLIENTI";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, cnn);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            cLIENTIDataGridView.DataSource = dt1;
            cnn.Close();

            cnn.Open();
            String query2 = "SELECT * FROM COMENZI";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, cnn);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            cOMENZIDataGridView.DataSource = dt2;
            cnn.Close();

            cnn.Open();
            String query3 = "SELECT * FROM CUPON_REDUCERE";
            SqlDataAdapter SDA3 = new SqlDataAdapter(query3, cnn);
            DataTable dt3 = new DataTable();
            SDA3.Fill(dt3);
            cUPON_REDUCEREDataGridView.DataSource = dt3;
            cnn.Close();

            cnn.Open();
            String query4 = "SELECT * FROM CURIERI";
            SqlDataAdapter SDA4 = new SqlDataAdapter(query4, cnn);
            DataTable dt4 = new DataTable();
            SDA4.Fill(dt4);
            cURIERIDataGridView.DataSource = dt4;
            cnn.Close();

            cnn.Open();
            String query5 = "SELECT * FROM PRODUSE";
            SqlDataAdapter SDA5 = new SqlDataAdapter(query5, cnn);
            DataTable dt5 = new DataTable();
            SDA5.Fill(dt5);
            pRODUSEDataGridView.DataSource = dt5;
            cnn.Close();

            cnn.Open();
            String query6 = "SELECT * FROM PRODUSE_COMANDA";
            SqlDataAdapter SDA6 = new SqlDataAdapter(query6, cnn);
            DataTable dt6 = new DataTable();
            SDA6.Fill(dt6);
            pRODUSE_COMANDADataGridView.DataSource = dt6;
            cnn.Close();

            cnn.Open();
            String query7 = "SELECT * FROM RESTAURANTE";
            SqlDataAdapter SDA7 = new SqlDataAdapter(query7, cnn);
            DataTable dt7 = new DataTable();
            SDA7.Fill(dt7);
            rESTAURANTEDataGridView.DataSource = dt7;
            cnn.Close();

            cnn.Open();
            String query8 = "SELECT * FROM VEHICULE";
            SqlDataAdapter SDA8 = new SqlDataAdapter(query8, cnn);
            DataTable dt8 = new DataTable();
            SDA8.Fill(dt8);
            vEHICULEDataGridView.DataSource = dt8;
            cnn.Close();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JapJap\Desktop\WindowsFormsApp3\WindowsFormsApp3\Database.mdf;Integrated Security = True");
        
        public void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            MessageBox.Show("Conexiune deschisa  !");
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "CLIENTI")
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (comboBox1.Text.Trim() == "COMENZI")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else if (comboBox1.Text.Trim() == "CUPON_REDUCERE")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else if (comboBox1.Text.Trim() == "CURIERI")
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            else if (comboBox1.Text.Trim() == "PRODUSE")
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
            else if (comboBox1.Text.Trim() == "PRODUSE_COMANDA")
            {
                Form6 f6 = new Form6();
                f6.Show();
            }
            else if (comboBox1.Text.Trim() == "RESTAURANTE")
            {
                Form7 f7 = new Form7();
                f7.Show();
            }
            else if (comboBox1.Text.Trim() == "VEHICULE")
            {
                Form8 f8 = new Form8();
                f8.Show();
            }
            else
                MessageBox.Show("Tabel inexistent");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();

            //Afisez intr un MessageBox informatiile din curiei
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT COMENZI.ID_COMANDA, CURIERI.ID_CURIER, CLIENTI.ID_CLIENT " +
                "FROM COMENZI " +
                "INNER JOIN CURIERI ON COMENZI.ID_CURIER = CURIERI.ID_CURIER " +
                "INNER JOIN CLIENTI ON COMENZI.ID_CLIENT = CLIENTI.ID_CLIENT " +
                "WHERE COMENZI.TIMP_LIVRARE < 15 AND COMENZI.CANTITATE > 3";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + " ID_COMANDA: " + dataReader.GetValue(0) + " - ID_CURIER:" + dataReader.GetValue(1) + " - ID_CLIENT:" + dataReader.GetValue(2) + "\n";
            }

            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();

            //Afisez intr un MessageBox informatiile din curiei
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT CURIERI.NUME, COUNT(COMENZI.ID_CURIER) AS NumarComenzi FROM COMENZI " +
                "JOIN CURIERI ON COMENZI.ID_CURIER = CURIERI.ID_CURIER " +
                "GROUP BY CURIERI.NUME " +
                "HAVING COUNT(COMENZI.ID_CURIER) > 1";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + " NUME: " + dataReader.GetValue(0) + " - NUMAR COMENZI:" + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
