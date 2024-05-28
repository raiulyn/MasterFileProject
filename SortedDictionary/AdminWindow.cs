using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 28/05/2024

namespace GeneralDictionary
{

    // 7.1 Create the Admin GUI with the following settings: Form is model, all Control Box features are removed/hidden, then add two text boxes.
    // The text box for the Staff ID should be read-only for Update and Delete purposes.

    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            Stopwatch sw = Stopwatch.StartNew();

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CheckKeyboardPresses;

            int key = GenerateStaffID();
            ID_Textbox.Text = key.ToString();
            this.Text = "AdminWindow [" + key.ToString() + "]";

            Trace.WriteLine("Initializing Admin Window: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }
        // 7.2 Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        public AdminWindow(int id)
        {
            Stopwatch sw = Stopwatch.StartNew();

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CheckKeyboardPresses;

            NameTextbox.Text = MainWindow.MasterFile[id];
            ID_Textbox.Text = id.ToString();
            this.Text = "AdminWindow [" + MainWindow.MasterFile[id] + "]";

            Trace.WriteLine("Initializing Admin Window: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }
        public AdminWindow(int id, string name)
        {
            Stopwatch sw = Stopwatch.StartNew();

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CheckKeyboardPresses;

            NameTextbox.Text = name;
            ID_Textbox.Text = id.ToString();
            this.Text = "AdminWindow [" + name + "]";

            Trace.WriteLine("Initializing Admin Window: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }

        private void CheckKeyboardPresses(object? sender, KeyEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();

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
            if (e.Alt == true && e.KeyCode == Keys.L)
            {
                CloseWindow();
            }

            Trace.WriteLine("Admin Window-KeyboardPress: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }

        // 7.3 Create a method that will create a new Staff ID and input the staff name from the related text box.
        // The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
        // The new staff member must be added to the SortedDictionary data structure.
        private void CreateEntry()
        {
            Stopwatch sw = Stopwatch.StartNew();

            try
            {
                MainWindow.MasterFile.Add(int.Parse(ID_Textbox.Text), NameTextbox.Text);
                CloseWindow();
            }
            catch (Exception ex)
            {
                OutputMessage(ex.Message);
            }

            Trace.WriteLine("Create Entry: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }

        private int GenerateStaffID()
        {
            Stopwatch sw = Stopwatch.StartNew();

            int key = 770000000;
            while (MainWindow.MasterFile.ContainsKey(key))
            {
                key++;
            }

            Trace.WriteLine("Generate ID: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();

            return key;
        }

        // 7.4 Create a method that will Update the name of the current Staff ID.
        private void UpdateEntry()
        {
            Stopwatch sw = Stopwatch.StartNew();

            var id = int.Parse(ID_Textbox.Text);
            if (!MainWindow.MasterFile.ContainsKey(id))
            {
                OutputMessage("No such ID existed..");
                return;
            }
            MainWindow.MasterFile[id] = NameTextbox.Text;
            CloseWindow();

            Trace.WriteLine("Update Entry: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }

        // 7.5 Create a method that will Remove the current Staff ID and clear the text boxes.
        private void RemoveEntry()
        {
            Stopwatch sw = Stopwatch.StartNew();

            var id = int.Parse(ID_Textbox.Text);
            if (!MainWindow.MasterFile.ContainsKey(id))
            {
                OutputMessage("No such ID existed..");
                return;
            }

            MainWindow.MasterFile.Remove(id);
            NameTextbox.Text = string.Empty;
            ID_Textbox.Text = string.Empty;
            CloseWindow();

            Trace.WriteLine("Remove Entry: " + sw.ElapsedTicks.ToString() + " Ticks");
            Trace.WriteLine("---------------------------------------------------------------");
            Trace.Flush();
        }

        // 7.6 Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveToFile(object sender, FormClosingEventArgs e)
        {
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                using (StreamWriter myOutputStream = new StreamWriter("MalinStaffNamesV3.csv"))
                {
                    foreach (var item in MainWindow.MasterFile)
                    {
                        myOutputStream.WriteLine(item.Key.ToString() + "," + item.Value);
                    }
                }
                sw.Stop();
                Trace.WriteLine("Saving to CSV file: " + sw.ElapsedTicks.ToString() + " Ticks");
                Trace.WriteLine("---------------------------------------------------------------");
                Trace.Flush();
            }
            catch (Exception ex)
            {
                OutputMessage(ex.Message);
            }
        }

        // 7.7 Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseWindow()
        {
            this.Close();
        }

        // 7.8 Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        // Make all methods private and ensure the Dictionary is updated. 
        private void OutputMessage(string msg)
        {
            OutputMessage_Textbox.Text = msg;
        }

        // 7.9 Ensure all code is adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS and MS coding standards (refer http://www.citems.com.au/).
    }
}
