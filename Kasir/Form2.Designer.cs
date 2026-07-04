namespace Kasir
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            MasukkanBarang = new TextBox();
            MasukkanHarga = new TextBox();
            JumlahBarang = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TotalBarang = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            lblTotal = new Label();
            button2 = new Button();
            hitungBarang = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 128, 0);
            groupBox1.Location = new Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 50);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // MasukkanBarang
            // 
            MasukkanBarang.Location = new Point(183, 126);
            MasukkanBarang.Name = "MasukkanBarang";
            MasukkanBarang.Size = new Size(115, 23);
            MasukkanBarang.TabIndex = 1;
            MasukkanBarang.TextChanged += MasukkanBarang_TextChanged;
            // 
            // MasukkanHarga
            // 
            MasukkanHarga.Location = new Point(183, 183);
            MasukkanHarga.Name = "MasukkanHarga";
            MasukkanHarga.Size = new Size(115, 23);
            MasukkanHarga.TabIndex = 2;
            // 
            // JumlahBarang
            // 
            JumlahBarang.Location = new Point(183, 240);
            JumlahBarang.Name = "JumlahBarang";
            JumlahBarang.Size = new Size(115, 23);
            JumlahBarang.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 134);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 4;
            label1.Text = "Masukkan Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 191);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Masukkan Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 248);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "JumlahBarang";
            // 
            // TotalBarang
            // 
            TotalBarang.AutoSize = true;
            TotalBarang.Location = new Point(58, 346);
            TotalBarang.Name = "TotalBarang";
            TotalBarang.Size = new Size(76, 15);
            TotalBarang.TabIndex = 7;
            TotalBarang.Text = "Total barang:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(418, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 259);
            listBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(183, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(198, 305);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(244, 297);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hitungBarang
            // 
            hitungBarang.Location = new Point(152, 297);
            hitungBarang.Name = "hitungBarang";
            hitungBarang.Size = new Size(75, 23);
            hitungBarang.TabIndex = 12;
            hitungBarang.Text = "hitung";
            hitungBarang.UseVisualStyleBackColor = true;
            hitungBarang.Click += btnHitung_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hitungBarang);
            Controls.Add(button2);
            Controls.Add(lblTotal);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(TotalBarang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(JumlahBarang);
            Controls.Add(MasukkanHarga);
            Controls.Add(MasukkanBarang);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox MasukkanBarang;
        private TextBox MasukkanHarga;
        private TextBox JumlahBarang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TotalBarang;
        private ListBox listBox1;
        private Button button1;
        private Label lblTotal;
        private Button button2;
        private Button hitungBarang;
    }
}