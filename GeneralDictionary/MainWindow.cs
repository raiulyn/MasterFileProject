using System;

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

            //ReadFromFile();
        }

        // 4.1 Create a Dictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure “MasterFile”.
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

        // 4.2 Create a method that will read the data from the .csv file into the Dictionary data structure when the GUI loads.
        private void ReadFromFile()
        {
            using (var reader = new StreamReader(@"file.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }

                for (int i = 0; i < listA.Count; i++)
                {
                    MasterFile.Add(int.Parse(listA[i]), listB[i]);
                }
            }
        }

        // 4.3 Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        private void DisplayData()
        {
            DataBox.Items.Clear();
            DataBox.DataSource = MasterFile;
        }

        // 4.4 Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.
        // This method must use a text box input and update as each character is entered. The list box must reflect the filtered data in real time.
        private void FilterName()
        {
            FilterBox.Items.Clear();
        }

        // 4.5 Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
        // This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
        private void FilterID(ListBox listbox, TextBox inputTextBox)
        {

        }

        // 4.6 Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box.
        // Utilise a keyboard shortcut.
        private void ClearName()
        {

        }

        // 4.7 Create a method for the Staff ID text box which will clear the contents and place the focus into the text box.
        // Utilise a keyboard shortcut.
        private void ClearID()
        {

        }

        // 4.8 Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected.
        // Utilise the Tab and keyboard keys.
        private void PopulateData()
        {

        }

        // 4.9 Create a method that will open the Admin GUI when the Alt + A keys are pressed.
        // Ensure the General GUI sends the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal.
        // Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty.
        // Read the appropriate criteria in the Admin GUI for further information.
        private void OpenAdminWindow()
        {

        }

        // 4.10 Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        // Make all methods private and ensure the Dictionary is static and public.
        private void OutputMessage(string msg)
        {
            StatusBox.Text = msg;
        }


        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            OutputMessage(e.KeyCode.ToString());
            if (e.Alt && e.KeyCode == Keys.C)
            {
                Application.Exit();
            }
        }



        // 4.11 Ensure all code is adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).
    }
}
