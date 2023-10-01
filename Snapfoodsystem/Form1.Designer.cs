namespace Snapfoodsystem
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
            restaurantname = new Label();
            nametextbox = new TextBox();
            Descriptionlabel = new Label();
            latlabel = new Label();
            Longlabel = new Label();
            label1 = new Label();
            opensatlabel = new Label();
            do_or_does = new CheckBox();
            Descriptiontextbox = new TextBox();
            infotextBox = new TextBox();
            opensattextBox = new TextBox();
            Addingbutton = new Button();
            LongtextBox = new TextBox();
            LattextBox = new TextBox();
            Takeawaylabel = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            FullADdresstxt = new TextBox();
            FullAddress = new Label();
            Location = new Label();
            TypeLabel = new Label();
            TypeCombobox = new ComboBox();
            TelephoneLabel = new Label();
            TelephoneTxt = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // restaurantname
            // 
            restaurantname.AutoSize = true;
            restaurantname.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            restaurantname.Location = new Point(38, 139);
            restaurantname.Name = "restaurantname";
            restaurantname.Size = new Size(100, 40);
            restaurantname.TabIndex = 0;
            restaurantname.Text = "Name:";
            // 
            // nametextbox
            // 
            nametextbox.BackColor = Color.Snow;
            nametextbox.Location = new Point(229, 142);
            nametextbox.Name = "nametextbox";
            nametextbox.Size = new Size(604, 39);
            nametextbox.TabIndex = 1;
            // 
            // Descriptionlabel
            // 
            Descriptionlabel.AutoSize = true;
            Descriptionlabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            Descriptionlabel.Location = new Point(38, 220);
            Descriptionlabel.Name = "Descriptionlabel";
            Descriptionlabel.Size = new Size(165, 40);
            Descriptionlabel.TabIndex = 3;
            Descriptionlabel.Text = "Description:";
            // 
            // latlabel
            // 
            latlabel.AutoSize = true;
            latlabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            latlabel.Location = new Point(34, 26);
            latlabel.Name = "latlabel";
            latlabel.Size = new Size(51, 32);
            latlabel.TabIndex = 5;
            latlabel.Text = "Lat:";
            // 
            // Longlabel
            // 
            Longlabel.AutoSize = true;
            Longlabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Longlabel.Location = new Point(34, 73);
            Longlabel.Name = "Longlabel";
            Longlabel.Size = new Size(69, 32);
            Longlabel.TabIndex = 4;
            Longlabel.Text = "Long:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 403);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 8;
            // 
            // opensatlabel
            // 
            opensatlabel.AutoSize = true;
            opensatlabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            opensatlabel.Location = new Point(38, 545);
            opensatlabel.Name = "opensatlabel";
            opensatlabel.Size = new Size(135, 40);
            opensatlabel.TabIndex = 9;
            opensatlabel.Text = "Opens at:";
            // 
            // do_or_does
            // 
            do_or_does.AutoSize = true;
            do_or_does.Checked = true;
            do_or_does.CheckState = CheckState.Checked;
            do_or_does.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            do_or_does.Location = new Point(263, 717);
            do_or_does.Name = "do_or_does";
            do_or_does.Size = new Size(28, 27);
            do_or_does.TabIndex = 7;
            do_or_does.UseVisualStyleBackColor = true;
            // 
            // Descriptiontextbox
            // 
            Descriptiontextbox.BackColor = Color.Snow;
            Descriptiontextbox.Location = new Point(229, 223);
            Descriptiontextbox.Name = "Descriptiontextbox";
            Descriptiontextbox.Size = new Size(610, 39);
            Descriptiontextbox.TabIndex = 2;
            // 
            // infotextBox
            // 
            infotextBox.BackColor = Color.Azure;
            infotextBox.Location = new Point(603, 538);
            infotextBox.Multiline = true;
            infotextBox.Name = "infotextBox";
            infotextBox.ReadOnly = true;
            infotextBox.Size = new Size(307, 47);
            infotextBox.TabIndex = 20;
            infotextBox.TabStop = false;
            infotextBox.Text = "(All times are in Iran time)";
            // 
            // opensattextBox
            // 
            opensattextBox.BackColor = Color.Snow;
            opensattextBox.Location = new Point(229, 545);
            opensattextBox.Name = "opensattextBox";
            opensattextBox.Size = new Size(332, 39);
            opensattextBox.TabIndex = 6;
            // 
            // Addingbutton
            // 
            Addingbutton.BackColor = SystemColors.ButtonFace;
            Addingbutton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            Addingbutton.Location = new Point(1128, 695);
            Addingbutton.Name = "Addingbutton";
            Addingbutton.Size = new Size(193, 64);
            Addingbutton.TabIndex = 7;
            Addingbutton.Text = "Add";
            Addingbutton.UseVisualStyleBackColor = false;
            Addingbutton.Click += Addingbutton_Click;
            // 
            // LongtextBox
            // 
            LongtextBox.BackColor = Color.Snow;
            LongtextBox.Location = new Point(170, 73);
            LongtextBox.Name = "LongtextBox";
            LongtextBox.Size = new Size(120, 39);
            LongtextBox.TabIndex = 4;
            // 
            // LattextBox
            // 
            LattextBox.BackColor = Color.Snow;
            LattextBox.Location = new Point(170, 19);
            LattextBox.Name = "LattextBox";
            LattextBox.Size = new Size(120, 39);
            LattextBox.TabIndex = 3;
            // 
            // Takeawaylabel
            // 
            Takeawaylabel.AutoSize = true;
            Takeawaylabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            Takeawaylabel.Location = new Point(38, 707);
            Takeawaylabel.Name = "Takeawaylabel";
            Takeawaylabel.Size = new Size(189, 40);
            Takeawaylabel.TabIndex = 16;
            Takeawaylabel.Text = "Has Takeway:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(158, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 74);
            panel1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleTurquoise;
            textBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(170, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(671, 57);
            textBox1.TabIndex = 0;
            textBox1.Text = "Store Adding";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(FullADdresstxt);
            panel2.Controls.Add(FullAddress);
            panel2.Controls.Add(LattextBox);
            panel2.Controls.Add(LongtextBox);
            panel2.Controls.Add(latlabel);
            panel2.Controls.Add(Longlabel);
            panel2.Location = new Point(229, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 117);
            panel2.TabIndex = 10;
            panel2.TabStop = true;
            // 
            // FullADdresstxt
            // 
            FullADdresstxt.BackColor = Color.Snow;
            FullADdresstxt.Location = new Point(561, 38);
            FullADdresstxt.Multiline = true;
            FullADdresstxt.Name = "FullADdresstxt";
            FullADdresstxt.Size = new Size(220, 57);
            FullADdresstxt.TabIndex = 5;
            // 
            // FullAddress
            // 
            FullAddress.AutoSize = true;
            FullAddress.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            FullAddress.Location = new Point(374, 46);
            FullAddress.Name = "FullAddress";
            FullAddress.Size = new Size(143, 32);
            FullAddress.TabIndex = 19;
            FullAddress.Text = "Full Address:";
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            Location.Location = new Point(38, 430);
            Location.Name = "Location";
            Location.Size = new Size(130, 40);
            Location.TabIndex = 20;
            Location.Text = "Location:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            TypeLabel.Location = new Point(38, 628);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(153, 40);
            TypeLabel.TabIndex = 21;
            TypeLabel.Text = "Store Type:";
            // 
            // TypeCombobox
            // 
            TypeCombobox.FormattingEnabled = true;
            TypeCombobox.Location = new Point(229, 628);
            TypeCombobox.Name = "TypeCombobox";
            TypeCombobox.Size = new Size(323, 40);
            TypeCombobox.TabIndex = 22;
            // 
            // TelephoneLabel
            // 
            TelephoneLabel.AutoSize = true;
            TelephoneLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            TelephoneLabel.Location = new Point(38, 317);
            TelephoneLabel.Name = "TelephoneLabel";
            TelephoneLabel.Size = new Size(152, 40);
            TelephoneLabel.TabIndex = 23;
            TelephoneLabel.Text = "Telephone:";
            // 
            // TelephoneTxt
            // 
            TelephoneTxt.BackColor = Color.Snow;
            TelephoneTxt.Location = new Point(229, 317);
            TelephoneTxt.Name = "TelephoneTxt";
            TelephoneTxt.Size = new Size(610, 39);
            TelephoneTxt.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1422, 841);
            Controls.Add(TelephoneTxt);
            Controls.Add(TelephoneLabel);
            Controls.Add(TypeCombobox);
            Controls.Add(TypeLabel);
            Controls.Add(Location);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Takeawaylabel);
            Controls.Add(Addingbutton);
            Controls.Add(opensattextBox);
            Controls.Add(infotextBox);
            Controls.Add(Descriptiontextbox);
            Controls.Add(do_or_does);
            Controls.Add(opensatlabel);
            Controls.Add(label1);
            Controls.Add(Descriptionlabel);
            Controls.Add(nametextbox);
            Controls.Add(restaurantname);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label restaurantname;
        private TextBox nametextbox;
        private Label Descriptionlabel;
        private Label latlabel;
        private Label Longlabel;
        private Label label1;
        private Label opensatlabel;
        private CheckBox do_or_does;
        private TextBox Descriptiontextbox;
        private TextBox infotextBox;
        private TextBox opensattextBox;
        private Button Addingbutton;
        private TextBox LongtextBox;
        private TextBox LattextBox;
        private Label Takeawaylabel;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private Label FullAddress;
        private Label Location;
        private TextBox FullADdresstxt;
        private Label TypeLabel;
        private ComboBox TypeCombobox;
        private Label TelephoneLabel;
        private TextBox TelephoneTxt;
    }
}