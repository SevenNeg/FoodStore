namespace Snapfoodsystem
{
    partial class takeaway_rules
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
            Min_items_textbox = new TextBox();
            minncartlabel = new Label();
            textBox1 = new TextBox();
            sortlabel = new Label();
            label2 = new Label();
            domainUpDown1 = new DomainUpDown();
            Exceptionlabel = new Label();
            Websitelabel = new Label();
            ExceptionDisTxt = new TextBox();
            URLTxt = new TextBox();
            donebutton = new Button();
            SaveInfButton = new Button();
            CopyDirectButton = new Button();
            Backbutton = new Button();
            SuspendLayout();
            // 
            // Min_items_textbox
            // 
            Min_items_textbox.Location = new Point(461, 216);
            Min_items_textbox.Name = "Min_items_textbox";
            Min_items_textbox.Size = new Size(246, 39);
            Min_items_textbox.TabIndex = 0;
            // 
            // minncartlabel
            // 
            minncartlabel.AutoSize = true;
            minncartlabel.Location = new Point(24, 216);
            minncartlabel.Name = "minncartlabel";
            minncartlabel.Size = new Size(397, 32);
            minncartlabel.TabIndex = 1;
            minncartlabel.Text = "min Cart Items: (insert the minprice)";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(40, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(850, 156);
            textBox1.TabIndex = 15;
            textBox1.Text = "Now, that you are OK with takeways, we need you to fill this blanks and help us keep track on your order!";
            // 
            // sortlabel
            // 
            sortlabel.AutoSize = true;
            sortlabel.Location = new Point(40, 301);
            sortlabel.Name = "sortlabel";
            sortlabel.Size = new Size(169, 32);
            sortlabel.TabIndex = 3;
            sortlabel.Text = "Sort orders by:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 397);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 4;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("Price");
            domainUpDown1.Items.Add("District");
            domainUpDown1.Items.Add("Food");
            domainUpDown1.Items.Add("Costumer Loyalty");
            domainUpDown1.Items.Add("Custom");
            domainUpDown1.Location = new Point(257, 294);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(268, 39);
            domainUpDown1.TabIndex = 2;
            domainUpDown1.Text = "Sort by";
            // 
            // Exceptionlabel
            // 
            Exceptionlabel.AutoSize = true;
            Exceptionlabel.Location = new Point(40, 397);
            Exceptionlabel.Name = "Exceptionlabel";
            Exceptionlabel.Size = new Size(210, 32);
            Exceptionlabel.TabIndex = 6;
            Exceptionlabel.Text = "Exception districts:";
            // 
            // Websitelabel
            // 
            Websitelabel.AutoSize = true;
            Websitelabel.Location = new Point(40, 485);
            Websitelabel.Name = "Websitelabel";
            Websitelabel.Size = new Size(420, 32);
            Websitelabel.TabIndex = 7;
            Websitelabel.Text = "URL of your website (If you have one):";
            // 
            // ExceptionDisTxt
            // 
            ExceptionDisTxt.Location = new Point(300, 394);
            ExceptionDisTxt.Name = "ExceptionDisTxt";
            ExceptionDisTxt.Size = new Size(248, 39);
            ExceptionDisTxt.TabIndex = 3;
            // 
            // URLTxt
            // 
            URLTxt.Location = new Point(488, 482);
            URLTxt.Name = "URLTxt";
            URLTxt.Size = new Size(402, 39);
            URLTxt.TabIndex = 4;
            // 
            // donebutton
            // 
            donebutton.BackColor = SystemColors.ButtonShadow;
            donebutton.Location = new Point(643, 650);
            donebutton.Name = "donebutton";
            donebutton.Size = new Size(234, 48);
            donebutton.TabIndex = 7;
            donebutton.Text = "Done";
            donebutton.UseVisualStyleBackColor = false;
            donebutton.Click += donebutton_Click;
            // 
            // SaveInfButton
            // 
            SaveInfButton.BackColor = Color.Thistle;
            SaveInfButton.Location = new Point(81, 608);
            SaveInfButton.Name = "SaveInfButton";
            SaveInfButton.Size = new Size(266, 45);
            SaveInfButton.TabIndex = 5;
            SaveInfButton.Text = "Save Your information";
            SaveInfButton.UseVisualStyleBackColor = false;
            SaveInfButton.Click += SaveInfButton_Click;
            // 
            // CopyDirectButton
            // 
            CopyDirectButton.BackColor = Color.LightSteelBlue;
            CopyDirectButton.Location = new Point(18, 670);
            CopyDirectButton.Name = "CopyDirectButton";
            CopyDirectButton.Size = new Size(403, 44);
            CopyDirectButton.TabIndex = 6;
            CopyDirectButton.Text = "Copy and Paste to your Directory";
            CopyDirectButton.UseVisualStyleBackColor = false;
            CopyDirectButton.Click += CopyDirectButton_Click;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.DarkGray;
            Backbutton.Location = new Point(677, 713);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(166, 48);
            Backbutton.TabIndex = 16;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // takeaway_rules
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 773);
            Controls.Add(Backbutton);
            Controls.Add(CopyDirectButton);
            Controls.Add(SaveInfButton);
            Controls.Add(donebutton);
            Controls.Add(URLTxt);
            Controls.Add(ExceptionDisTxt);
            Controls.Add(Websitelabel);
            Controls.Add(Exceptionlabel);
            Controls.Add(domainUpDown1);
            Controls.Add(label2);
            Controls.Add(sortlabel);
            Controls.Add(textBox1);
            Controls.Add(minncartlabel);
            Controls.Add(Min_items_textbox);
            Name = "takeaway_rules";
            Text = "takeaway_rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Min_items_textbox;
        private Label minncartlabel;
        private TextBox textBox1;
        private Label sortlabel;
        private Label label2;
        private DomainUpDown domainUpDown1;
        private Label Exceptionlabel;
        private Label Websitelabel;
        private TextBox ExceptionDisTxt;
        private TextBox URLTxt;
        private Button donebutton;
        private Button SaveInfButton;
        private Button CopyDirectButton;
        private Button Backbutton;
    }
}