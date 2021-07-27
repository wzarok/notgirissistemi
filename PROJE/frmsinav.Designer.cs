
namespace PROJE
{
    partial class frmsinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsinav));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txts3 = new System.Windows.Forms.TextBox();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.txtort = new System.Windows.Forms.TextBox();
            this.btngun = new System.Windows.Forms.Button();
            this.btnhesap = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbders
            // 
            this.cmbders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(308, 81);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(190, 21);
            this.cmbders.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(44, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "SINAV 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(44, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "SINAV 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "SINAV 1";
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(143, 120);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(190, 20);
            this.txts1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(232, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "DERS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(187, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ogrenci ID";
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(143, 160);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(190, 20);
            this.txts2.TabIndex = 37;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(308, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(190, 20);
            this.txtid.TabIndex = 36;
            // 
            // txts3
            // 
            this.txts3.Location = new System.Drawing.Point(143, 200);
            this.txts3.Name = "txts3";
            this.txts3.Size = new System.Drawing.Size(190, 20);
            this.txts3.TabIndex = 47;
            // 
            // txtdurum
            // 
            this.txtdurum.Enabled = false;
            this.txtdurum.Location = new System.Drawing.Point(534, 200);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(190, 20);
            this.txtdurum.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(435, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "DURUM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(395, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "ORTALAMA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(441, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "PROJE";
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(534, 120);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(190, 20);
            this.txtpro.TabIndex = 49;
            // 
            // txtort
            // 
            this.txtort.Enabled = false;
            this.txtort.Location = new System.Drawing.Point(534, 160);
            this.txtort.Name = "txtort";
            this.txtort.Size = new System.Drawing.Size(190, 20);
            this.txtort.TabIndex = 48;
            // 
            // btngun
            // 
            this.btngun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngun.Location = new System.Drawing.Point(354, 269);
            this.btngun.Name = "btngun";
            this.btngun.Size = new System.Drawing.Size(144, 45);
            this.btngun.TabIndex = 55;
            this.btngun.Text = "GÜNCELLE";
            this.btngun.UseVisualStyleBackColor = true;
            this.btngun.Click += new System.EventHandler(this.btngun_Click);
            // 
            // btnhesap
            // 
            this.btnhesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesap.Location = new System.Drawing.Point(204, 269);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(144, 45);
            this.btnhesap.TabIndex = 56;
            this.btnhesap.Text = "HESAPLA";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // btnara
            // 
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.Location = new System.Drawing.Point(504, 269);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(144, 45);
            this.btnara.TabIndex = 57;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(752, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 58;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // frmsinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.btngun);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.txtort);
            this.Controls.Add(this.txts3);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txts1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txts2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsinav";
            this.Load += new System.EventHandler(this.frmsinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txts3;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.TextBox txtort;
        private System.Windows.Forms.Button btngun;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}