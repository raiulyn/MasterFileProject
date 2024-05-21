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
            ID_Label = new Label();
            NameTextbox = new TextBox();
            ID_Textbox = new TextBox();
            HelpBox = new TextBox();
            OutputMessage_Textbox = new TextBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(36, 76);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.Location = new Point(45, 34);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(18, 15);
            ID_Label.TabIndex = 1;
            ID_Label.Text = "ID";
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(158, 73);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(100, 23);
            NameTextbox.TabIndex = 0;
            // 
            // ID_Textbox
            // 
            ID_Textbox.Location = new Point(158, 26);
            ID_Textbox.Name = "ID_Textbox";
            ID_Textbox.ReadOnly = true;
            ID_Textbox.Size = new Size(100, 23);
            ID_Textbox.TabIndex = 0;
            ID_Textbox.TabStop = false;
            // 
            // HelpBox
            // 
            HelpBox.Enabled = false;
            HelpBox.Location = new Point(317, 12);
            HelpBox.Multiline = true;
            HelpBox.Name = "HelpBox";
            HelpBox.ReadOnly = true;
            HelpBox.Size = new Size(136, 117);
            HelpBox.TabIndex = 4;
            HelpBox.Text = "Alt + A : Apply\r\nAlt + D : Duplicate\r\nAlt + K : Delete\r\nAlt + L : Close";
            // 
            // OutputMessage_Textbox
            // 
            OutputMessage_Textbox.Enabled = false;
            OutputMessage_Textbox.Location = new Point(12, 135);
            OutputMessage_Textbox.Name = "OutputMessage_Textbox";
            OutputMessage_Textbox.ReadOnly = true;
            OutputMessage_Textbox.Size = new Size(441, 23);
            OutputMessage_Textbox.TabIndex = 5;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 168);
            Controls.Add(OutputMessage_Textbox);
            Controls.Add(HelpBox);
            Controls.Add(ID_Textbox);
            Controls.Add(NameTextbox);
            Controls.Add(ID_Label);
            Controls.Add(NameLabel);
            Name = "AdminWindow";
            Text = "AdminWindow [Data ID]";
            FormClosing += SaveToFile;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label ID_Label;
        private TextBox NameTextbox;
        private TextBox ID_Textbox;
        private TextBox HelpBox;
        private TextBox OutputMessage_Textbox;
    }
}