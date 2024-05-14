namespace GeneralDictionary
{
    partial class MainWindow
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
            HelpBox = new TextBox();
            StatusBox = new TextBox();
            DataBox = new ListBox();
            FilterBox = new ListBox();
            FilterPanel = new Panel();
            PhoneNumberTextbox = new TextBox();
            KeywordTextbox = new TextBox();
            PhoneNumberLabel = new Label();
            KeywordLabel = new Label();
            FilterLabel = new Label();
            DetailsPanel = new Panel();
            DetailsTextbox1 = new TextBox();
            label1 = new Label();
            FilterPanel.SuspendLayout();
            DetailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HelpBox
            // 
            HelpBox.Enabled = false;
            HelpBox.Location = new Point(598, 12);
            HelpBox.Multiline = true;
            HelpBox.Name = "HelpBox";
            HelpBox.ReadOnly = true;
            HelpBox.Size = new Size(190, 186);
            HelpBox.TabIndex = 0;
            HelpBox.Text = "Alt + R : Open Admin Window\r\nAlt + K : Clear Keyword\r\nAlt + P : Clear Phone Number\r\nAlt + C : Close Application";
            // 
            // StatusBox
            // 
            StatusBox.Enabled = false;
            StatusBox.Location = new Point(12, 415);
            StatusBox.Name = "StatusBox";
            StatusBox.ReadOnly = true;
            StatusBox.Size = new Size(776, 23);
            StatusBox.TabIndex = 1;
            // 
            // DataBox
            // 
            DataBox.FormattingEnabled = true;
            DataBox.ItemHeight = 15;
            DataBox.Items.AddRange(new object[] { "Data 1", "Data 2", "Data 3", "Data 4", "Data 5", "Data 6", "Data 7", "Data 8", "Data 9", "Data 10" });
            DataBox.Location = new Point(12, 12);
            DataBox.Name = "DataBox";
            DataBox.Size = new Size(302, 394);
            DataBox.TabIndex = 2;
            // 
            // FilterBox
            // 
            FilterBox.FormattingEnabled = true;
            FilterBox.ItemHeight = 15;
            FilterBox.Location = new Point(320, 204);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(272, 199);
            FilterBox.TabIndex = 3;
            // 
            // FilterPanel
            // 
            FilterPanel.Controls.Add(PhoneNumberTextbox);
            FilterPanel.Controls.Add(KeywordTextbox);
            FilterPanel.Controls.Add(PhoneNumberLabel);
            FilterPanel.Controls.Add(KeywordLabel);
            FilterPanel.Controls.Add(FilterLabel);
            FilterPanel.Location = new Point(320, 12);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(272, 186);
            FilterPanel.TabIndex = 4;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Location = new Point(124, 94);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.Size = new Size(132, 23);
            PhoneNumberTextbox.TabIndex = 4;
            // 
            // KeywordTextbox
            // 
            KeywordTextbox.Location = new Point(124, 53);
            KeywordTextbox.Name = "KeywordTextbox";
            KeywordTextbox.Size = new Size(132, 23);
            KeywordTextbox.TabIndex = 3;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(19, 94);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 2;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // KeywordLabel
            // 
            KeywordLabel.AutoSize = true;
            KeywordLabel.Location = new Point(19, 56);
            KeywordLabel.Name = "KeywordLabel";
            KeywordLabel.Size = new Size(53, 15);
            KeywordLabel.TabIndex = 1;
            KeywordLabel.Text = "Keyword";
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FilterLabel.Location = new Point(0, 0);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(72, 32);
            FilterLabel.TabIndex = 0;
            FilterLabel.Text = "Filter";
            // 
            // DetailsPanel
            // 
            DetailsPanel.Controls.Add(DetailsTextbox1);
            DetailsPanel.Controls.Add(label1);
            DetailsPanel.Location = new Point(598, 204);
            DetailsPanel.Name = "DetailsPanel";
            DetailsPanel.Size = new Size(190, 199);
            DetailsPanel.TabIndex = 5;
            // 
            // DetailsTextbox1
            // 
            DetailsTextbox1.Enabled = false;
            DetailsTextbox1.Location = new Point(21, 37);
            DetailsTextbox1.Multiline = true;
            DetailsTextbox1.Name = "DetailsTextbox1";
            DetailsTextbox1.ReadOnly = true;
            DetailsTextbox1.Size = new Size(151, 135);
            DetailsTextbox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(DetailsPanel);
            Controls.Add(FilterPanel);
            Controls.Add(FilterBox);
            Controls.Add(DataBox);
            Controls.Add(StatusBox);
            Controls.Add(HelpBox);
            Name = "MainWindow";
            Text = "Main Window";
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            DetailsPanel.ResumeLayout(false);
            DetailsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox HelpBox;
        private TextBox StatusBox;
        private ListBox DataBox;
        private ListBox FilterBox;
        private Panel FilterPanel;
        private TextBox KeywordTextbox;
        private Label PhoneNumberLabel;
        private Label KeywordLabel;
        private Label FilterLabel;
        private TextBox PhoneNumberTextbox;
        private Panel DetailsPanel;
        private TextBox DetailsTextbox1;
        private Label label1;
    }
}
