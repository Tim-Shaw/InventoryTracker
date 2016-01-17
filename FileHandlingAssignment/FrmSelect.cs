using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileHandlingAssignment
{
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        int num;

        public int NumEntries
        {
            //gets the number of entries from the main form
            set { num = value; }
        }

        public FrmMain.GameInfo[] Games
        {
            set
            {
                //adds all game titles to the combo box
                for (int i = 1; i <= num; i++)
                {
                    cmbSelect.Items.Add(value[i].game);
                }
            }
        }

        public int Selected
        {
            //returns the entry # of the selected game
            get { return cmbSelect.SelectedIndex + 1; }
        }

    }
}
