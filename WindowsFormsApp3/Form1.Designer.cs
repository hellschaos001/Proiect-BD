
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cLIENTIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApp3.DatabaseDataSet();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUPON_REDUCEREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURIERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUSE_COMANDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTAURANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTITableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.CLIENTITableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.cOMENZITableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.COMENZITableAdapter();
            this.cUPON_REDUCERETableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.CUPON_REDUCERETableAdapter();
            this.cURIERITableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.CURIERITableAdapter();
            this.pRODUSE_COMANDATableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.PRODUSE_COMANDATableAdapter();
            this.pRODUSETableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.PRODUSETableAdapter();
            this.rESTAURANTETableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.RESTAURANTETableAdapter();
            this.vEHICULETableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.VEHICULETableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUPON_REDUCEREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURIERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUSE_COMANDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTAURANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULEBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLIENTIBindingSource
            // 
            this.cLIENTIBindingSource.DataMember = "CLIENTI";
            this.cLIENTIBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMENZIBindingSource
            // 
            this.cOMENZIBindingSource.DataMember = "COMENZI";
            this.cOMENZIBindingSource.DataSource = this.databaseDataSet;
            // 
            // cUPON_REDUCEREBindingSource
            // 
            this.cUPON_REDUCEREBindingSource.DataMember = "CUPON_REDUCERE";
            this.cUPON_REDUCEREBindingSource.DataSource = this.databaseDataSet;
            // 
            // cURIERIBindingSource
            // 
            this.cURIERIBindingSource.DataMember = "CURIERI";
            this.cURIERIBindingSource.DataSource = this.databaseDataSet;
            // 
            // pRODUSEBindingSource
            // 
            this.pRODUSEBindingSource.DataMember = "PRODUSE";
            this.pRODUSEBindingSource.DataSource = this.databaseDataSet;
            // 
            // pRODUSE_COMANDABindingSource
            // 
            this.pRODUSE_COMANDABindingSource.DataMember = "PRODUSE_COMANDA";
            this.pRODUSE_COMANDABindingSource.DataSource = this.databaseDataSet;
            // 
            // rESTAURANTEBindingSource
            // 
            this.rESTAURANTEBindingSource.DataMember = "RESTAURANTE";
            this.rESTAURANTEBindingSource.DataSource = this.databaseDataSet;
            // 
            // vEHICULEBindingSource
            // 
            this.vEHICULEBindingSource.DataMember = "VEHICULE";
            this.vEHICULEBindingSource.DataSource = this.databaseDataSet;
            // 
            // cLIENTITableAdapter
            // 
            this.cLIENTITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTITableAdapter = this.cLIENTITableAdapter;
            this.tableAdapterManager.COMENZITableAdapter = this.cOMENZITableAdapter;
            this.tableAdapterManager.CUPON_REDUCERETableAdapter = this.cUPON_REDUCERETableAdapter;
            this.tableAdapterManager.CURIERITableAdapter = this.cURIERITableAdapter;
            this.tableAdapterManager.PRODUSE_COMANDATableAdapter = this.pRODUSE_COMANDATableAdapter;
            this.tableAdapterManager.PRODUSETableAdapter = this.pRODUSETableAdapter;
            this.tableAdapterManager.RESTAURANTETableAdapter = this.rESTAURANTETableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VEHICULETableAdapter = this.vEHICULETableAdapter;
            // 
            // cOMENZITableAdapter
            // 
            this.cOMENZITableAdapter.ClearBeforeFill = true;
            // 
            // cUPON_REDUCERETableAdapter
            // 
            this.cUPON_REDUCERETableAdapter.ClearBeforeFill = true;
            // 
            // cURIERITableAdapter
            // 
            this.cURIERITableAdapter.ClearBeforeFill = true;
            // 
            // pRODUSE_COMANDATableAdapter
            // 
            this.pRODUSE_COMANDATableAdapter.ClearBeforeFill = true;
            // 
            // pRODUSETableAdapter
            // 
            this.pRODUSETableAdapter.ClearBeforeFill = true;
            // 
            // rESTAURANTETableAdapter
            // 
            this.rESTAURANTETableAdapter.ClearBeforeFill = true;
            // 
            // vEHICULETableAdapter
            // 
            this.vEHICULETableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 305);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operatii tabel CLIENTI";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(150, 271);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(150, 229);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(150, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID_CUPON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TELEFON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATA_NASTERII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRENUME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NUME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID_CLIENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 305);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(53, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "View";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 305);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUPON_REDUCEREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURIERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUSE_COMANDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTAURANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULEBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource cLIENTIBindingSource;
        private DatabaseDataSetTableAdapters.CLIENTITableAdapter cLIENTITableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private DatabaseDataSetTableAdapters.CUPON_REDUCERETableAdapter cUPON_REDUCERETableAdapter;
        private System.Windows.Forms.BindingSource cUPON_REDUCEREBindingSource;
        private DatabaseDataSetTableAdapters.CURIERITableAdapter cURIERITableAdapter;
        private System.Windows.Forms.BindingSource cURIERIBindingSource;
        private DatabaseDataSetTableAdapters.PRODUSETableAdapter pRODUSETableAdapter;
        private System.Windows.Forms.BindingSource pRODUSEBindingSource;
        private DatabaseDataSetTableAdapters.PRODUSE_COMANDATableAdapter pRODUSE_COMANDATableAdapter;
        private System.Windows.Forms.BindingSource pRODUSE_COMANDABindingSource;
        private DatabaseDataSetTableAdapters.RESTAURANTETableAdapter rESTAURANTETableAdapter;
        private System.Windows.Forms.BindingSource rESTAURANTEBindingSource;
        private DatabaseDataSetTableAdapters.VEHICULETableAdapter vEHICULETableAdapter;
        private System.Windows.Forms.BindingSource vEHICULEBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

