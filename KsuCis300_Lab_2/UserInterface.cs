/*
 * KsuCis300_Lab_2.cs
 * Author: Gabriel Serrano
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsuCis300_Lab_2
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The event handler for the "Open..." section of uxMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            string fileName = openFile.FileName;

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Error: Cannot Open File!");
            }
        }

        private void uxSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Error: Cannot Save to File " + saveFile.FileName);
            }
        }
    }
}