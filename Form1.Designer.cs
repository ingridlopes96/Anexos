namespace Anexos
{
    partial class telaLogin

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnAcessar = new Button();
            Login = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
           
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.Transparent;
            btnAcessar.BackgroundImage = (Image)resources.GetObject("btnAcessar.BackgroundImage");
            btnAcessar.Cursor = Cursors.IBeam;
            btnAcessar.FlatAppearance.BorderSize = 0;
            btnAcessar.FlatStyle = FlatStyle.Flat;
            btnAcessar.Location = new Point(188, 253);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(214, 88);
            btnAcessar.TabIndex = 0;
            btnAcessar.UseVisualStyleBackColor = false;
   
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.FromArgb(139, 61, 255);
            Login.Location = new Point(81, 160);
            Login.Name = "Login";
            Login.Size = new Size(58, 26);
            Login.TabIndex = 1;
            Login.Text = "&Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(139, 61, 255);
            label2.Location = new Point(81, 211);
            label2.Name = "label2";
            label2.Size = new Size(65, 26);
            label2.TabIndex = 2;
            label2.Text = "&Senha";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(178, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(442, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 23, 40);
            ClientSize = new Size(781, 419);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(btnAcessar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Label Login;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}
