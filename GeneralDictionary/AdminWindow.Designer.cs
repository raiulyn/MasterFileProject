namespace GeneralDictionary
{
    partial class AdminWindow
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
            NameLabel = new Label();
            PhoneNumberLabel = new Label();
            NameTextbox = new TextBox();
            PhoneNumberTextbox = new TextBox();
            HelpBox = new TextBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(36, 33);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(12, 77);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 1;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(158, 30);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(100, 23);
            NameTextbox.TabIndex = 2;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Location = new Point(158, 77);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.Size = new Size(100, 23);
            PhoneNumberTextbox.TabIndex = 3;
            // 
            // HelpBox
            // 
            HelpBox.Location = new Point(317, 12);
            HelpBox.Multiline = true;
            HelpBox.Name = "HelpBox";
            HelpBox.ReadOnly = true;
            HelpBox.Size = new Size(136, 117);
            HelpBox.TabIndex = 4;
            HelpBox.Text = "Alt + A : Apply\r\nAlt + D : Duplicate\r\nAlt + K : Delete\r\nAlt + C : Close";
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 148);
            Controls.Add(HelpBox);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(NameTextbox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(NameLabel);
            Name = "AdminWindow";
            Text = "AdminWindow [Data ID]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label PhoneNumberLabel;
        private TextBox NameTextbox;
        private TextBox PhoneNumberTextbox;
        private TextBox HelpBox;
    }
}