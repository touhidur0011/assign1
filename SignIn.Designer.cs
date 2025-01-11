namespace Main
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            button1 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(247, 524);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Nexa Extra Light", 8F);
            textBox3.Location = new Point(129, 346);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Username or Email";
            textBox3.Size = new Size(373, 25);
            textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nexa Extra Light", 8F);
            textBox1.Location = new Point(129, 401);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '.';
            textBox1.PlaceholderText = "Enter Password";
            textBox1.Size = new Size(373, 25);
            textBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.FlatAppearance.BorderColor = Color.White;
            checkBox1.FlatAppearance.BorderSize = 0;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(120, 449);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(172, 27);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1, 592);
            button2.Name = "button2";
            button2.Size = new Size(82, 60);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 664);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Font = new Font("Nexa Extra Light", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += SignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button2;
    }
}