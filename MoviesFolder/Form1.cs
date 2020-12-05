using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MoviesFolder
{
    public partial class Form1 : Form
    {
        private Dictionary<string, bool> watched = new Dictionary<string, bool>();
        private string currItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string dir = textBoxFolder.Text;
            string[] files = Directory.GetFiles(dir);
            foreach(string file in files) {
                listBoxFiles.Items.Add(file);   
            }
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e) {
            string listItem = listBoxFiles.SelectedItem.ToString();
            currItem = listItem;
            if(watched.ContainsKey(currItem)) {
                checkBoxWatched.Checked = watched[currItem];
            }
            else {
                watched.Add(currItem, false);
                checkBoxWatched.Checked = false;
            }
        }

        private void checkBoxWatched_CheckedChanged(object sender, EventArgs e) {
            watched[currItem] = checkBoxWatched.Checked;
        }
    }
}
