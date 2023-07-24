namespace Ingilizce_Kelime_Ogren
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtIngilizce = new TextBox();
            txtTurkce = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSure = new Label();
            lblKelime = new Label();
            lblCevap = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 1;
            label1.Text = "İngilizce: ";
            // 
            // txtIngilizce
            // 
            txtIngilizce.Enabled = false;
            txtIngilizce.Location = new Point(91, 6);
            txtIngilizce.Name = "txtIngilizce";
            txtIngilizce.ReadOnly = true;
            txtIngilizce.Size = new Size(144, 29);
            txtIngilizce.TabIndex = 100;
            // 
            // txtTurkce
            // 
            txtTurkce.Location = new Point(91, 41);
            txtTurkce.Name = "txtTurkce";
            txtTurkce.Size = new Size(144, 29);
            txtTurkce.TabIndex = 0;
            txtTurkce.TextChanged += txtTurkce_TextChanged;
            txtTurkce.KeyDown += txtTurkce_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Türkçe: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 4;
            label3.Text = "Süre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 44);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 5;
            label4.Text = "Kelime: ";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Location = new Point(346, 9);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(19, 21);
            lblSure.TabIndex = 6;
            lblSure.Text = "0";
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.Location = new Point(346, 44);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(19, 21);
            lblKelime.TabIndex = 7;
            lblKelime.Text = "0";
            // 
            // lblCevap
            // 
            lblCevap.AutoSize = true;
            lblCevap.Location = new Point(181, 78);
            lblCevap.Name = "lblCevap";
            lblCevap.Size = new Size(31, 21);
            lblCevap.TabIndex = 8;
            lblCevap.Text = "***";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(91, 74);
            button1.Name = "button1";
            button1.Size = new Size(68, 29);
            button1.TabIndex = 101;
            button1.Text = "Geç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(409, 118);
            Controls.Add(button1);
            Controls.Add(lblCevap);
            Controls.Add(lblKelime);
            Controls.Add(lblSure);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTurkce);
            Controls.Add(label2);
            Controls.Add(txtIngilizce);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Öğren";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngilizce;
        private TextBox txtTurkce;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblSure;
        private Label lblKelime;
        private Label lblCevap;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}