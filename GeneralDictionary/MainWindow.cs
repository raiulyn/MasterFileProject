using System;
using System.Data;
using System.Diagnostics;

namespace GeneralDictionary
{
    // RAYMOND LAI
    // STUDENT ID: 30082866
    // DATE: 

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CheckKeyboardPresses;
            KeywordTextbox.KeyPress += KeywordTextbox_KeyPress;
            PhoneNumberTextbox.KeyPress += PhoneNumberTextbox_KeyPress;
            DataBox.SelectedIndexChanged += DataBox_SelectedIndexChanged;
            FilterBox.SelectedIndexChanged += FilterBox_SelectedIndexChanged;
            ReadFromFile();
            DisplayData();
        }

        private void CheckKeyboardPresses(object? sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.A)
            {
                OpenAdminWindow();
            }
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                ClearName();
            }
            if (e.Alt == true && e.KeyCode == Keys.P)
            {
                ClearID();
            }
            if (e.Alt == true && e.KeyCode == Keys.C)
            {
                Application.Exit();
            }
        }
        private void KeywordTextbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            FilterName();
        }
        private void PhoneNumberTextbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            FilterID();
        }

        private void DataBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            PopulateSelectedData(DataBox.SelectedItem.ToString());
        }
        private void FilterBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            PopulateSelectedData(FilterBox.SelectedItem.ToString());
        }


        // 4.1 Create a Dictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure “MasterFile”.
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

        // 4.2 Create a method that will read the data from the .csv file into the Dictionary data structure when the GUI loads.
        private void ReadFromFile()
        {
            try
            {
                MasterFile.Clear();

                List<string[]> rows = File.ReadAllLines("MalinStaffNamesV3.csv").Select(x => x.Split(',')).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("1");
                dt.Columns.Add("2");
                for (int i = 0; i < rows.Count; i++)
                {
                    if (rows[i][0].ToString() == string.Empty) { break; }
                    MasterFile.Add(int.Parse( rows[i][0]), rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
                throw;
            }
        }

        // 4.3 Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        
        private void DisplayData()
        {
            DataBox.Items.Clear();
            for (int i = 0;i < MasterFile.Count;i++)
            {
                DataBox.Items.Add(MasterFile.ElementAt(i).Key.ToString() + "," + MasterFile.ElementAt(i).Value);
            }
        }

        // 4.4 Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.
        // This method must use a text box input and update as each character is entered. The list box must reflect the filtered data in real time.
        private void FilterName()
        {
            FilterBox.Items.Clear();
            var dic = MasterFile.Where(x => x.Value.ToString().Contains(KeywordTextbox.Text));
            foreach (var item in dic)
            {
                FilterBox.Items.Add(item.Key.ToString() + "," + item.Value);
            }
        }

        // 4.5 Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
        // This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
        private void FilterID()
        {
            FilterBox.Items.Clear();
            var dic = MasterFile.Where(x => x.Key.ToString().Contains(PhoneNumberTextbox.Text));
            foreach (var item in dic)
            {
                FilterBox.Items.Add(item.Key.ToString() + "," + item.Value);
            }
        }

        // 4.6 Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box.
        // Utilise a keyboard shortcut.
        private void ClearName()
        {
            KeywordTextbox.Text = string.Empty;
            KeywordTextbox.Focus();
        }

        // 4.7 Create a method for the Staff ID text box which will clear the contents and place the focus into the text box.
        // Utilise a keyboard shortcut.
        private void ClearID()
        {
            PhoneNumberTextbox.Text = string.Empty;
            PhoneNumberTextbox.Focus();
        }

        // 4.8 Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected.
        // Utilise the Tab and keyboard keys.
        private void PopulateSelectedData(string selectedDat)
        {
            var str = selectedDat.Split(',');
            KeywordTextbox.Text = str[1];
            PhoneNumberTextbox.Text = str[0];
        }

        // 4.9 Create a method that will open the Admin GUI when the Alt + A keys are pressed.
        // Ensure the General GUI sends the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal.
        // Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty.
        // Read the appropriate criteria in the Admin GUI for further information.
        private void OpenAdminWindow()
        {
            if (PhoneNumberTextbox.Text ==  string.Empty)
            {
                OutputMessage("Please input a Phone Number...");
                return;
            }
            var keyID = int.Parse(PhoneNumberTextbox.Text);
            if (!MasterFile.ContainsKey(keyID))
            {
                OutputMessage("No Data existed!!!");
                return;
            }
            var adminWin = new AdminWindow(keyID);
            adminWin.FormClosed += AdminWin_FormClosed;
            adminWin.Show();
        }

        private void AdminWin_FormClosed(object? sender, FormClosedEventArgs e)
        {
            DisplayData();
        }

        // 4.10 Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        // Make all methods private and ensure the Dictionary is static and public.
        private void OutputMessage(string msg)
        {
            StatusBox.Text = msg;
        }


        // 4.11 Ensure all code is adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).
    }
}
