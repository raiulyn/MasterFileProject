﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// NAME: RAYMOND LAI
// ID: 30082866

namespace GeneralDictionary
{

    // 5.1 Create the Admin GUI with the following settings: GUI is model, all Control Box features are removed/hidden, then add two text boxes.
    // The text box for the Staff ID should be read-only for Add, Update and Delete purposes.

    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CheckKeyboardPresses;
        }
        // 5.2 Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data.
        public AdminWindow(int id)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CheckKeyboardPresses;

            NameTextbox.Text = MainWindow.MasterFile[id];
            PhoneNumberTextbox.Text = id.ToString();
            this.Text = "AdminWindow [" + MainWindow.MasterFile[id] + "]";
        }

        private void CheckKeyboardPresses(object? sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.A)
            {
                UpdateEntry();
            }
            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                CreateEntry();
            }
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                RemoveEntry();
            }
            if (e.Alt == true && e.KeyCode == Keys.C)
            {
                CloseWindow();
            }
        }

        // 5.3 Create a method that will create a new Staff ID and input the staff name from the related text box.
        // The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
        // The new staff member must be added to the Dictionary data structure.
        private void CreateEntry()
        {
            try
            {
                int phoneId = int.Parse(PhoneNumberTextbox.Text);
                if(MainWindow.MasterFile.ContainsKey(phoneId))
                {
                    OutputMessage("Phone number already exists!!!");
                    return;
                }
                MainWindow.MasterFile.Add(phoneId, NameTextbox.Text);
                CloseWindow();
            }
            catch (Exception ex)
            {
                OutputMessage(ex.Message);
            }
        }

        // 5.4 Create a method that will Update the name of the current Staff ID.
        private void UpdateEntry()
        {
            var id = int.Parse(PhoneNumberTextbox.Text);
            if (!MainWindow.MasterFile.ContainsKey(id)) { return; }
            MainWindow.MasterFile[id] = NameTextbox.Text;
            CloseWindow();
        }

        // 5.5 Create a method that will Remove the current Staff ID and clear the text boxes.
        private void RemoveEntry()
        {
            MainWindow.MasterFile.Remove(int.Parse(PhoneNumberTextbox.Text));

            NameTextbox.Text = string.Empty;
            PhoneNumberTextbox.Text = string.Empty;
            CloseWindow();
        }

        // 5.6 Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveToFile(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter("MalinStaffNamesV3.csv"))
                {
                    foreach (var item in MainWindow.MasterFile)
                    {
                        myOutputStream.WriteLine(item.Key.ToString() + "," + item.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                OutputMessage(ex.Message);
            }
        }

        // 5.7 Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseWindow()
        {
            this.Close();
        }

        // 5.8 Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        // Make all methods private and ensure the Dictionary is updated. 
        private void OutputMessage(string msg)
        {

        }

        // 5.9 Ensure all code is adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS and MS coding standards (refer http://www.citems.com.au/).
    }
}
