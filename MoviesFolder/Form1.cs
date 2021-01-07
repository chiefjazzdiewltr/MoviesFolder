using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace MoviesFolder {
    public partial class Form1 : Form {
        private Dictionary<string, bool> watched = new Dictionary<string, bool>(); // The main dictionary that stores the movie's watched state
        private string currItem; // This variable just represents the currently selected item

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            listBoxFiles.DrawItem += ListBoxFiles_DrawItem;
        }

        /// <summary>
        /// A custom implementation of the ListBox's Draw Item event handler, 
        /// this is needed to do the green/white distinction for each list box
        /// entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxFiles_DrawItem(object sender, DrawItemEventArgs e) {
            // Initial variables needed to setup the program
            e.DrawBackground();
            Graphics g = e.Graphics;
            ListBox lb = (ListBox)sender;

            // An if statement that checks if the listbox actually contains entries or not
            if (lb.Items.Count != 0) {
                string key = lb.Items[e.Index].ToString(); // (Needed to simplify my code)
                // If statement that acts as a "cursor"
                if (lb.GetSelected(e.Index)) {
                    g.DrawRectangle(new Pen(Color.Black), e.Bounds);
                }
                // If statement that sets the draw color based on the watched state
                if (watched[key] == true) {
                    g.FillRectangle(new SolidBrush(Color.LightGreen), e.Bounds);
                } else {
                    g.FillRectangle(new SolidBrush(Color.IndianRed), e.Bounds);
                }
                // Drawing the actual string itself into the row
                g.DrawString(key, e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
            }
        }

        /// <summary>
        /// Go Button that will grab all of the Files and Folders in a 
        /// given directory and add them to the display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e) {
            listBoxFiles.Items.Clear();
            watched.Clear();
            // Bunch of variables for storing the files and folders
            string dir = textBoxFolder.Text;
            string[] files = Directory.GetFiles(dir);
            string[] folders = Directory.GetDirectories(dir);

            // A nested foreach loop that gets all the files in the folders and displays them
            foreach (string folder in folders) {
                string[] tempFiles = Directory.GetFiles(folder);
                foreach (string tmpFile in tempFiles) {
                    string newFile = tmpFile.Replace(folder + "\\", ""); // A filter that gets rid of unnecessary garbage
                    // A bit of a redundant if statement, but it checks if the file already exists
                    // and doesn't add it if it does
                    if (watched.ContainsKey(newFile)) {
                        Console.WriteLine("File Already Exists: " + newFile);
                    } else {
                        watched.Add(newFile, false);
                    }
                    listBoxFiles.Items.Add(newFile);

                }
            }

            // A foreach loop that gets all the files in the given directory and displays them
            foreach (string file in files) {
                string newFile = file.Replace(dir + "\\", ""); // Same filter as nested foreach loop
                // A bit of a redundant if statement, but it checks if the file already exists
                // and doesn't add it if it does
                if (watched.ContainsKey(newFile)) {
                    Console.WriteLine("File Already Exists: " + newFile);
                } else {
                    watched.Add(newFile, false);
                }
                listBoxFiles.Items.Add(newFile);
            }
        }

        /// <summary>
        /// This method changes the state of a movie that the user has selected (if provoked)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e) {
            // These variables just change and get the currently selected item
            string listItem = listBoxFiles.SelectedItem.ToString();
            currItem = listItem;
            // This if and else checks if the current item is in the dictionary and adds it, if it isn't
            if (watched.ContainsKey(currItem)) {
                checkBoxWatched.Checked = watched[currItem];
            } else {
                watched.Add(currItem, false);
                checkBoxWatched.Checked = false;
            }
            // Automatically refreshes the selected item in the listbox
            listBoxFiles.Invalidate(listBoxFiles.GetItemRectangle(listBoxFiles.SelectedIndex));
        }

        /// <summary>
        /// This method acts as a sort of "memory" and will "remember" what state each movie has
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxWatched_CheckedChanged(object sender, EventArgs e) {
            watched[currItem] = checkBoxWatched.Checked;
            // Automatically refreshes the selected item in the listbox
            listBoxFiles.Invalidate(listBoxFiles.GetItemRectangle(listBoxFiles.SelectedIndex));
        }

        /// <summary>
        /// This method load the csv file which stores all the saved movie states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseToolStripMenuItem_Click(object sender, EventArgs e) {
            listBoxFiles.Items.Clear(); // Just as a precaution it clears the existing display
            watched.Clear();
            if (openFile.ShowDialog() == DialogResult.OK) {
                try {
                    // Creates a reader that reads from the csv file and adds all entries to the display
                    StreamReader reader = new StreamReader(openFile.FileName);
                    while (!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        listBoxFiles.Items.Add(values[0]);
                        watched.Add(values[0], Boolean.Parse(values[1]));

                    }
                    reader.Close();
                }
                // A bit of error checking
                catch {
                    MessageBox.Show("Incorrect File Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// This method saves the csv file which stores all the saved movie states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFile.ShowDialog() == DialogResult.OK) {
                // Checks if the saved name is not blank (this would never trip but just in case)
                if (saveFile.FileName != "") {
                    // Runs through each entry in the dictionary and adds it to a csv files then saves it
                    string file = "";
                    foreach (KeyValuePair<string, bool> movie in watched) {
                        file += $"{movie.Key},{movie.Value}\n";
                    }
                    File.WriteAllText(saveFile.FileName, file);
                }
                // A bit of error checking 
                else {
                    MessageBox.Show("Null File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// This method does the same thing as the Go button but is implemented by pressing the 
        /// enter key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFolder_KeyPress(object sender, KeyPressEventArgs e) {
            char key = e.KeyChar;
            if (key == 0xD) {
                listBoxFiles.Items.Clear();
                watched.Clear();
                // Bunch of variables for storing the files and folders
                string dir = textBoxFolder.Text;
                string[] files = Directory.GetFiles(dir);
                string[] folders = Directory.GetDirectories(dir);

                // A nested foreach loop that gets all the files in the folders and displays them
                foreach (string folder in folders) {
                    string[] tempFiles = Directory.GetFiles(folder);
                    foreach (string tmpFile in tempFiles) {
                        string newFile = tmpFile.Replace(folder + "\\", ""); // A filter that gets rid of unnecessary garbage
                        // A bit of a redundant if statement, but it checks if the file already exists
                        // and doesn't add it if it does
                        if (watched.ContainsKey(newFile)) {
                            Console.WriteLine("File Already Exists");
                        } else {
                            watched.Add(newFile, false);
                        }
                        listBoxFiles.Items.Add(newFile);

                    }
                }

                // A foreach loop that gets all the files in the given directory and displays them
                foreach (string file in files) {
                    string newFile = file.Replace(dir + "\\", ""); // Same filter as nested foreach loop
                    // A bit of a redundant if statement, but it checks if the file already exists
                    // and doesn't add it if it does
                    if (watched.ContainsKey(newFile)) {
                        Console.WriteLine("File Already Exists");
                    } else {
                        watched.Add(newFile, false);
                    }
                    listBoxFiles.Items.Add(newFile);
                }
            }
        }

        /// <summary>
        /// A simple button that clears the contents of the array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e) {
            // Displays a Warning box
            DialogResult result = MessageBox.Show("This action will clear the array, are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { // If the result is Yes then clear the contents of
                listBoxFiles.Items.Clear();   // the array and the listbox
                watched.Clear();
            }
        }
    }
}