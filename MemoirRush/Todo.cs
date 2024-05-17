namespace MemoirRush
{
    public partial class Todo : Form
    {
        public Todo()
        {
            InitializeComponent();
        }
        string filePath = "Todo.txt";
        string jsonfile = "default.json";
        string richtxt;
        int launched;

        List<string> daily_lines = new List<string>();
        List<string> weekly_lines = new List<string>();
        List<string> monthly_lines = new List<string>();
        List<string> sticky_lines = new List<string>();

        private void add_day_task_Click(object sender, EventArgs e)
        {
            todays_list.Items.Add(day_textbox.Text);
            daily_lines.Add(day_textbox.Text);

            //string json = JsonConvert.SerializeObject(daily_lines);

        }
        private void todays_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (todays_list.Items.Count == todays_list.CheckedItems.Count)
            {
                MessageBox.Show("Great Day! Keep On !\nEYES AHEAD");
                todays_list.Items.Clear();
            }
        }

        private void add_week_task_Click(object sender, EventArgs e)
        {
            weekly_list.Items.Add(week_textbox.Text.ToString());
            weekly_lines.Add(week_textbox.Text.ToString());
        }

        private void weekly_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weekly_list.Items.Count == weekly_list.CheckedItems.Count)
            {
                MessageBox.Show("A CHEAT-MEAL YOU DESERVE, \n AND \n A GOOD SLEEP");
                weekly_list.Items.Clear();
            }
        }

        private void Add_sticky_Click(object sender, EventArgs e)
        {
            _stickylistBOX.Items.Add(add_stickytextbox.Text.ToString());
            sticky_lines.Add(add_stickytextbox.Text.ToString());
        }

        private void _add_monthlyButton_Click(object sender, EventArgs e)
        {
            _Monthly_listbox.Items.Add(monthly_textbox.Text.ToString());
            monthly_lines.Add(monthly_textbox.Text.ToString());
        }
        private void create_file_Click(object sender, EventArgs e)
        {
            File.Create(filePath);
        }

        private void checksheet_Click(object sender, EventArgs e)
        {

            if (!File.Exists(filePath)) // Check if file doesn't exist
            {
                MessageBox.Show("File Doesn\'t exist!\n");
            }
            else
            {
                MessageBox.Show("File Exists");
            }
        }
        private void append_to_existing_file()
        {
            //string[] linestoAppend
            File.AppendAllText(filePath, "Daily list: \n");
            File.AppendAllLines(filePath, daily_lines);
            File.AppendAllText(filePath, "Weekly list: \n");
            File.AppendAllLines(filePath, weekly_lines);
            File.AppendAllText(filePath, "Monthly list: \n");
            File.AppendAllLines(filePath, monthly_lines);
        }

        private void append_to_file_Click(object sender, EventArgs e)
        {
            append_to_existing_file();
        }

        private void get_file_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\Users\ahmed_k57cd64\OneDrive\Checklist_Notes\Checklist_Notes\bin\Debug\net8.0-windows";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // User selected a file
                string selectedFileName = openFileDialog.FileName;
                // Do something with the selected file
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (todays_list.SelectedItem != null)
            {
                todays_list.Items.Remove(todays_list.SelectedItem);
            }
            else if (weekly_list.SelectedItem != null)
            {
                weekly_list.Items.Remove(weekly_list.SelectedItem);
            }
            else if (_Monthly_listbox.SelectedItem != null)
            {
                _Monthly_listbox.Items.Remove(_Monthly_listbox.SelectedItem);
            }
            else if (_stickylistBOX.SelectedItem != null)
            {
                _stickylistBOX.Items.Remove(_stickylistBOX.SelectedItem);
            }
        }
        private void day_textbox_TextChanged(object sender, EventArgs e)
        {
        }
        private void Weekly_Load(object sender, EventArgs e)
        {

        }

        private void week_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void _stickylistBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _Sticky_notes_richtextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RichtextBox_button_Click(object sender, EventArgs e)
        {
            _Sticky_notes_richtextbox.SelectionFont = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Italic);
            _Sticky_notes_richtextbox.SelectionColor = System.Drawing.Color.BlueViolet;

            if (todays_list.SelectedItem != null)
            {
                _Sticky_notes_richtextbox.AppendText(todays_list.SelectedItem.ToString());
            }
            else if (weekly_list.SelectedItem != null)
            {
                _Sticky_notes_richtextbox.AppendText(weekly_list.SelectedItem.ToString());
            }
            else if (_Monthly_listbox.SelectedItem != null)
            {
                _Sticky_notes_richtextbox.AppendText(_Monthly_listbox.SelectedItem.ToString());
            }
            else if (_stickylistBOX.SelectedItem != null)
            {
                _Sticky_notes_richtextbox.AppendText(_stickylistBOX.SelectedItem.ToString());
            }
        }

        private void Deserialize_button_Click(object sender, EventArgs e)
        {

        }
    }

}


/*

private void Create_File(){
    FilePath = 

} 


**********************************************************************************************************************************
 * Creation of Workbook, Worksheet, and Sheet Parts:

csharp

using (SpreadsheetDocument doc = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
{
    // Create necessary parts for workbook, worksheet, and sheets
    WorkbookPart workbookPart = doc.AddWorkbookPart();
    workbookPart.Workbook = new Workbook();
    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
    worksheetPart.Worksheet = new Worksheet(new SheetData());
    Sheets sheets = doc.WorkbookPart.Workbook.AppendChild(new Sheets());
    Sheet sheet = new Sheet() { Id = doc.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
    sheets.Append(sheet);
    workbookPart.Workbook.Save();
}

    Here, we're creating a new Excel file if it doesn't already exist.
    We first create the necessary parts for the workbook, worksheet, and sheets.
    WorkbookPart represents the root of the document hierarchy for a spreadsheet.
    WorksheetPart represents a worksheet within the spreadsheet.
    SheetData represents the data within a worksheet.
    We then append a new sheet to the workbook and save the workbook.

Accessing Existing Workbook, Worksheet, and Sheet Parts:

csharp

using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, false))
{
    // Access workbook, worksheet, and sheet data
    WorkbookPart workbookPart = doc.WorkbookPart;
    Sheet sheet = workbookPart.Workbook.Descendants<Sheet>().First();
    WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(sheet.Id);
    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
}

    Here, we're opening an existing Excel file for reading.
    We retrieve the workbook, worksheet, and sheet data to perform operations on them.

Else Block for Existing Content:

csharp

else
{
    // Print existing content of the sheet
    Console.WriteLine("This is the current Content");
    foreach (Row row in sheetData.Elements<Row>())
    {
        foreach (Cell cell in row.Elements<Cell>())
        {
            Console.WriteLine(cell.CellValue.Text + "/t");
        }
        Console.WriteLine();
    }
}

    If the sheet is not empty, this block is executed.
    It iterates through each row and each cell within the rows and prints their values.
    This part is essential for displaying the current content of the Excel sheet to the user.*/