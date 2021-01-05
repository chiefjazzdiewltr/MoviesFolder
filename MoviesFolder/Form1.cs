using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace MoviesFolder
{
    public partial class Form1 : Form
    {
        private Dictionary<string, bool> watched = new Dictionary<string, bool>(); // The main dictionary that stores the movie's watched state
        private string currItem; // This variable just represents the currently selected item

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Go Button that will grab all of the Files and Folders in a given directory and add them to the display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            // Bunch of variables for storing the files and folders
            string dir = textBoxFolder.Text;
            string[] files = Directory.GetFiles(dir);
            string[] folders = Directory.GetDirectories(dir);

            // A nested foreach loop that gets all the files in the folders and displays them
            foreach(string folder in folders) {
                string[] tempFiles = Directory.GetFiles(folder);
                foreach(string tmpFile in tempFiles) {
                    watched.Add(tmpFile, false);
                    string newFile = tmpFile.Replace(folder + "\\", ""); // A filter that gets rid of unnecessary garbage
                    listBoxFiles.Items.Add(newFile);
                   
                }
            }

            // A foreach loop that gets all the files in the given directory and displays them
            foreach(string file in files) {
                watched.Add(file, false);
                string newFile = file.Replace(dir + "\\", ""); // Same filter as nested foreach loop
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
        }

        /// <summary>
        /// This method acts as a sort of "memory" and will "remember" what state each movie has
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxWatched_CheckedChanged(object sender, EventArgs e) {
            watched[currItem] = checkBoxWatched.Checked;
        }

        /// <summary>
        /// This method load the csv file which stores all the saved movie states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseToolStripMenuItem_Click(object sender, EventArgs e) {
            listBoxFiles.Items.Clear(); // Just as a precaution it clears the existing display
            if(openFile.ShowDialog() == DialogResult.OK) {
                try {
                    // Creates a reader that reads from the csv file and adds all entries to the display
                    StreamReader reader = new StreamReader(openFile.FileName); 
                    while(!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        listBoxFiles.Items.Add(values[0]);
                        watched.Add(values[0], Boolean.Parse(values[1]));
                        
                    }
                    reader.Close();
                } 
                // A bit of error checking
                catch {
                    Console.Error.WriteLine("Incorrect File Path");
                }
            }
        }

        /// <summary>
        /// This method saves the csv file which stores all the saved movie states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if(saveFile.ShowDialog() == DialogResult.OK) {
                // Checks if the saved name is not blank (this would never trip but just in case)
                if(saveFile.FileName != "") {
                    // Runs through each entry in the dictionary and adds it to a csv files then saves it
                    string file = "";
                    foreach(KeyValuePair<string, bool> movie in watched) {
                        file += $"{movie.Key},{movie.Value}\n";
                    }
                    File.WriteAllText(saveFile.FileName, file);
                }
                // A bit of error checking 
                else {
                    Console.Error.WriteLine("Null File Name");
                }
            }
        }
    }
}
