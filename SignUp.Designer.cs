namespace Main
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(727, 198);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your First Name";
            textBox1.Size = new Size(178, 22);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(961, 198);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Your Last Name";
            textBox2.Size = new Size(178, 22);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(727, 255);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Your Email";
            textBox3.Size = new Size(412, 22);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(727, 322);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter Your Contact Number";
            textBox4.Size = new Size(412, 22);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(727, 444);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "Creat Password";
            textBox5.Size = new Size(412, 22);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Window;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(727, 502);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.PlaceholderText = "Confirm Password";
            textBox6.Size = new Size(412, 22);
            textBox6.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Select Role";
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "patient", "Doctor", "sciber" });
            comboBox1.Location = new Point(977, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 33);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(864, 563);
            button1.Name = "button1";
            button1.Size = new Size(123, 31);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Nexa Extra Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(727, 376);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 29);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
            button2.Location = new Point(12, 592);
            button2.Name = "button2";
            button2.Size = new Size(82, 60);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 664);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}