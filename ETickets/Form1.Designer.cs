
namespace ETickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.productEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.btnPastro = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndrysho = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Fshi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUlset = new System.Windows.Forms.Button();
            this.btnPaguaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "eTickets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.txtPaga);
            this.groupBox1.Controls.Add(this.txtEmri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regjistrimi i Biletave";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productEntitiesBindingSource;
            this.comboBox2.DisplayMember = "Configuration";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "Database";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // productEntitiesBindingSource
            // 
            this.productEntitiesBindingSource.DataSource = typeof(ETickets.ProductEntities);
            // 
            // txtPaga
            // 
            this.txtPaga.Location = new System.Drawing.Point(115, 175);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.ReadOnly = true;
            this.txtPaga.Size = new System.Drawing.Size(100, 26);
            this.txtPaga.TabIndex = 4;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(115, 38);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(171, 26);
            this.txtEmri.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pagesa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zgjedh ulsen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email :";
            // 
            // btnRuaj
            // 
            this.btnRuaj.Location = new System.Drawing.Point(234, 392);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 23);
            this.btnRuaj.TabIndex = 2;
            this.btnRuaj.Text = "Konfirmo";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnPastro
            // 
            this.btnPastro.Location = new System.Drawing.Point(795, 377);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(106, 38);
            this.btnPastro.TabIndex = 3;
            this.btnPastro.Text = "Pastro";
            this.btnPastro.UseVisualStyleBackColor = true;
            this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(907, 377);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 38);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Ndrysho,
            this.Fshi});
            this.dataGridView1.Location = new System.Drawing.Point(382, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 231);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emri";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ulsja";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pagesa";
            this.Column4.Name = "Column4";
            // 
            // Ndrysho
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ndrysho.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ndrysho.HeaderText = "Ndrysho";
            this.Ndrysho.Name = "Ndrysho";
            this.Ndrysho.Text = "Ndrysho";
            this.Ndrysho.UseColumnTextForButtonValue = true;
            // 
            // Fshi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fshi.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fshi.HeaderText = "Fshi";
            this.Fshi.Name = "Fshi";
            this.Fshi.Text = "Fshi";
            this.Fshi.UseColumnTextForButtonValue = true;
            // 
            // btnUlset
            // 
            this.btnUlset.Location = new System.Drawing.Point(137, 392);
            this.btnUlset.Name = "btnUlset";
            this.btnUlset.Size = new System.Drawing.Size(75, 23);
            this.btnUlset.TabIndex = 6;
            this.btnUlset.Text = "Ulset";
            this.btnUlset.UseVisualStyleBackColor = true;
            this.btnUlset.Click += new System.EventHandler(this.btnUlset_Click);
            // 
            // btnPaguaj
            // 
            this.btnPaguaj.Location = new System.Drawing.Point(41, 392);
            this.btnPaguaj.Name = "btnPaguaj";
            this.btnPaguaj.Size = new System.Drawing.Size(75, 23);
            this.btnPaguaj.TabIndex = 7;
            this.btnPaguaj.Text = "Paguaj";
            this.btnPaguaj.UseVisualStyleBackColor = true;
            this.btnPaguaj.Click += new System.EventHandler(this.btnPaguaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 521);
            this.Controls.Add(this.btnPaguaj);
            this.Controls.Add(this.btnUlset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPastro);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "eTickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Button btnPastro;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Ndrysho;
        private System.Windows.Forms.DataGridViewButtonColumn Fshi;
        private System.Windows.Forms.Button btnUlset;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource productEntitiesBindingSource;
        private System.Windows.Forms.Button btnPaguaj;
    }
}

