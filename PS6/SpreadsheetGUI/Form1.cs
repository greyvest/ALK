// PS6
// 10/27/2017
// Kelsey Fink
// Leona Craig

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SS;
using SpreadsheetUtilities;

namespace SpreadsheetGUI
{
    public partial class Form1 : Form
    {
        AbstractSpreadsheet spreadsheet;
        List<string> letters;
        bool savedRecently;

        /// <summary>
        /// Zero argument constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            spreadsheetPanel1.SelectionChanged += displaySelection;

            spreadsheet = new Spreadsheet(n => true, n => n.ToUpper(), "ps6");
            letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
                "X", "Y", "Z" };
            //update_all_textboxes();
            update_NonEmpty_Cells();
            savedRecently = true;
        }

        /// <summary>
        /// One argument constructor taking in a filename 
        /// Used for Open
        /// </summary>
        /// <param name="fileName"></param>
        public Form1(string fileName)
        {
            InitializeComponent();
            spreadsheetPanel1.SelectionChanged += displaySelection;

            spreadsheet = new Spreadsheet(fileName, n => true, n => n.ToUpper(), "ps6");
            letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
                "X", "Y", "Z" };
            //update_all_textboxes();
            update_NonEmpty_Cells();
            savedRecently = true;
        }

        /// <summary>
        /// Triggered everytime mouse selects new cell. It gets current cell selection, gets the value,
        /// updates all display textboxes, and then clears that content if necessary.
        /// </summary>
        /// <param name="ss"></param>
        private void displaySelection(SpreadsheetPanel ss)
        {
            cell_content_textbox.Clear();
            int row, col;
            ss.GetSelection(out col, out row);
            //update_NonEmpty_Cells();
            update_all_textboxes();
        }

        /// <summary>
        /// Triggered when enter button is hit. Gets the current cell that is selected and assigns
        /// it content, then updates all the display textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void content_enter_button_Click(object sender, EventArgs e)
        {
            cell_content_textbox.ForeColor = Color.Black;
            int col;
            int row;
            get_current_cell_selection(out col, out row);
            assign_content(col, row);
            //update_all_textboxes();
        }

        /// <summary>
        /// Helper method that sets the contents of the actual spreadsheet
        /// Called when user enters in new content
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        private void assign_content(int col, int row)
        {
            string given_val = cell_content_textbox.Text;
            IEnumerable<string> dependentCells;
            string cellName = getCellName(col, row);
            try
            {
                dependentCells = spreadsheet.SetContentsOfCell(cellName, given_val);
                update_Dependent_Cells(dependentCells);
            }
            catch (CircularException)
            {
                MessageBox.Show("WARNING: Circular dependency present");
            }
            catch(FormulaFormatException)
            {
                MessageBox.Show("WARNING: Invalid Format for Formula");
            }
            
            //update_all_textboxes();
            savedRecently = false;
        }

        /// <summary>
        /// Helper method which takes the cell column and row position as parameters
        /// Returns a string representing the cell name
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private string getCellName(int col, int row)
        {
            string colLetter = letters[col];
            string rowNumber = (row + 1).ToString();
            return colLetter + rowNumber;
        }

        /// <summary>
        /// Triggered when the New button is clicked in the file menu
        /// Creates a new Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void new_spreadsheet_click(object sender, EventArgs e)
        {
            SpreadsheetApplicationContext.getAppContext().RunForm(new Form1());
        }

        /// <summary>
        /// Helper method which assigns the cell col/row location into the out parameters
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        private void get_current_cell_selection(out int col, out int row)
        {
            spreadsheetPanel1.GetSelection(out col, out row);
        }

        /// <summary>
        /// Triggered when the Save option is selected in the file menu
        /// Opens the file explorer and allows the user to pick file path and name
        /// Saves the current spreadsheet state to a .sprd file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Text Files (*.sprd)|*.sprd|All Files (*.*)|*.*";
            dialog.ShowDialog();
            string savePath = dialog.FileName;
            if (!string.IsNullOrWhiteSpace(savePath))
            {
                spreadsheet.Save(savePath);
            }
            savedRecently = true;
        }

        /// <summary>
        /// Triggered when the Open option is selected in the file menu
        /// Opens the file explorer and allows the user to pick an already existing .sprd file
        /// Creates a new Form1 based off this file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.sprd)|*.sprd|All Files (*.*)|*.*";
            dialog.ShowDialog();
            string savePath = dialog.FileName;
            if (!string.IsNullOrWhiteSpace(savePath))
            {
                SpreadsheetApplicationContext.getAppContext().RunForm(new Form1(savePath));
            }
        }

        /// <summary>
        /// Triggered when Close option is selected in the file menu
        /// Closes the current Form1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            if(savedRecently == false)
            {
                MessageBox.Show("WARNING: File has not been recently saved. " +
                    "This will result in loss of data. Try again if this is your intention.");
            }
            if (savedRecently == true)
            {
                Close();
            }
            savedRecently = true;
            
        }

        /// <summary>
        /// Helper method to call all methods which update textboxes of specified cell
        /// </summary>
        private void update_all_textboxes()
        {
            int col, row;
            get_current_cell_selection(out col, out row);
            update_name_textbox(col, row);
            update_value_textbox(col, row);
            update_content_textbox(col, row);
        }

        /// <summary>
        /// Helper method to update the name textbox of specified cell
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        private void update_name_textbox(int col, int row)
        {
            cell_name_textbox.Text = getCellName(col, row);
        }

        /// <summary>
        /// Helper method to update the value textbox of specified cell
        /// Also updates the visible value on the selected cell
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        private void update_value_textbox(int col, int row)
        {
            string cellName = getCellName(col, row);
            object value = spreadsheet.GetCellValue(cellName);
            if (value is string)
            {
                cell_value_textbox.Text = (string)spreadsheet.GetCellValue(cellName);
                spreadsheetPanel1.SetValue(col, row, (string)spreadsheet.GetCellValue(cellName));
            }
            else if (value is double)
            {
                cell_value_textbox.Text = spreadsheet.GetCellValue(cellName).ToString();
                spreadsheetPanel1.SetValue(col, row, spreadsheet.GetCellValue(cellName).ToString());
            }
            else if (value is FormulaError)
            {
                cell_value_textbox.Text = "FormulaError";
                spreadsheetPanel1.SetValue(col, row, "FormulaError");
            }
        }

        /// <summary>
        /// Helper method used to update the content textbox of the specified cell
        /// Updates the content textbox of the selected cell
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        private void update_content_textbox(int col, int row)
        {
            string cellName = getCellName(col, row);
            object content = spreadsheet.GetCellContents(cellName);
            object value = spreadsheet.GetCellValue(cellName);
            if (content is Formula)
            {
                cell_content_textbox.Text = "=" + content.ToString();
            }
            else if (value is FormulaError)
            {
                cell_content_textbox.Text = "=" + content.ToString();
            }
            else
            {
                cell_content_textbox.Text = content.ToString();
            }
        }

        /// <summary>
        /// Helper method to update all cells that are non-empty
        /// </summary>
        private void update_NonEmpty_Cells()
        {
            IEnumerable<string> NonEmptyCells = spreadsheet.GetNamesOfAllNonemptyCells();
            foreach (string cell in NonEmptyCells)
            {
                string colString = cell[0].ToString();
                string rowString = cell.Substring(1);

                int col = letters.IndexOf(colString);
                int row;
                int.TryParse(rowString, out row);
                row -= 1;
                
                update_content_textbox(col, row);
                update_name_textbox(col, row);
                update_value_textbox(col, row);
            }
        }

        /// <summary>
        /// Helper method to update cells which depend on cell that was altered
        /// </summary>
        private void update_Dependent_Cells(IEnumerable<string> dependentCells)
        {
            foreach (string cell in dependentCells)
            {
                string colString = cell[0].ToString();
                string rowString = cell.Substring(1);

                int col = letters.IndexOf(colString);
                int row;
                int.TryParse(rowString, out row);
                row -= 1;

                update_content_textbox(col, row);
                update_name_textbox(col, row);
                update_value_textbox(col, row);
            }
        }

        /// <summary>
        /// Triggered when the help option is picked
        /// Displays how to use the spreadsheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help_Clicked(object sender, EventArgs e)
        {
            string message = "\u2022 Select any cell by clicking on it " +
                "with your mouse.\n\u2022 For all cell selections please use " +
                "your mouse.\n\u2022 To change the content, please click on " +
                "the content box and start typing.\n\u2022 Once you have typed " +
                "the contents, either hit enter or click on the enter button." +
                "\n\u2022 If you need a quick smile, seek out the 'Need a boost?' " +
                "option.\n\u2022 When you are done with a visual from 'Need a boost?'" +
                ", simply click on it.";
            MessageBox.Show(message, "How to use this spreadsheet");
        }


        // Everything after this point is EXTRA FEATURES


        /// <summary>
        /// Triggered when the content is being changed
        /// Causes the text to be red when it is being altered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_content_textbox_TextChanged(object sender, EventArgs e)
        {
            cell_content_textbox.ForeColor = Color.Red;
        }

        /// <summary>
        /// Closes the LandShark GIF when user clicks on GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickedLandSharkGIF(object sender, EventArgs e)
        {
            LandShark.Visible = false;
        }

        /// <summary>
        /// Closes the Penguin GIF when user clicks on GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickedPenguinGIF(object sender, EventArgs e)
        {
            PenguinGif.Visible = false;
        }

        /// <summary>
        /// Closes the Sloth GIF when user clicks on GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickedSlothGIF(object sender, EventArgs e)
        {
            Sloth.Visible = false;
        }

        /// <summary>
        /// Closes the JustDoIt GIF when user clicks on GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickedJustDoItGIF(object sender, EventArgs e)
        {
            JustDoIt.Visible = false;
        }

        /// <summary>
        /// Closes the Doggie GIF when user clicks on GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickedDoggieGif(object sender, EventArgs e)
        {
            Doggie.Visible = false;
        }

        /// <summary>
        /// Closes the Pony GIF when user clicks on GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickedPonyGIF(object sender, EventArgs e)
        {
            Pony.Visible = false;
        }

        /// <summary>
        /// Opens the Penguin GIF when user clicks on menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PenguinClickEvent(object sender, EventArgs e)
        {
            PenguinGif.Visible = true;
        }

        /// <summary>
        /// Opens the LandShark GIF when user clicks on menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LandSharkClickEvent(object sender, EventArgs e)
        {
            LandShark.Visible = true;
        }

        /// <summary>
        /// Opens the Sloth GIF when user clicks on menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlothClickEvent(object sender, EventArgs e)
        {
            Sloth.Visible = true;
        }

        /// <summary>
        /// Opens the JustDoIt GIF when user clicks on menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JustDoItClickEvent(object sender, EventArgs e)
        {
            JustDoIt.Visible = true;
        }

        /// <summary>
        /// Opens the Doggie GIF when user clicks on menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoggieClickEvent(object sender, EventArgs e)
        {
            Doggie.Visible = true;
        }

        /// <summary>
        /// Opens the Pony GIF when user clicks on menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PonyClickEvent(object sender, EventArgs e)
        {
            Pony.Visible = true;
        }
    }
}
