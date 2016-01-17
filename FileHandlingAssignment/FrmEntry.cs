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
    public partial class FrmEntry : Form
    {
        public FrmEntry()
        {
            InitializeComponent();
        }
        
        string cover;
        
        //sets text boxes' text to game info passed to the form when changing info and returns
        // the text box values with the game info to the main form
        public string Title
        {            
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }

        public string Platform
        {
            get { return txtPlatform.Text; }
            set { txtPlatform.Text = value; }
        }

        public string Developer
        {
            get { return txtDev.Text; }
            set { txtDev.Text = value; }
        }

        public string Genre
        {
            get { return txtGenre.Text; }
            set { txtGenre.Text = value; }
        }

        public double Price
        {
            get { return double.Parse(txtPrice.Text); }
            set { txtPrice.Text = value.ToString("n2"); }
        }

        public int Inventory
        {
            get { return int.Parse(txtInv.Text); }
            set { txtInv.Text = value.ToString(); }
        }
        //gets the cover image file name and returns file name to main form
        public string Cover
        {
            get { return cover; }
            set { cover = value; }
        }
                
        private void BtnCover_Click(object sender, EventArgs e)
        {
            //sets dialog directory to images folder in application folder
            dlgCover.InitialDirectory = Application.StartupPath + @"\Images";
            //allows user to switch between common picture files and other files in dialog
            dlgCover.Filter = "Picture Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            dlgCover.FilterIndex = 1;
            if (dlgCover.ShowDialog() == DialogResult.OK)
            {
                //sets cover to the name of the file that was selected
                cover = dlgCover.SafeFileName;
                try
                {
                    //moves file to images folder in application folder
                    System.IO.File.Copy(dlgCover.FileName, Application.StartupPath + @"\images\" + cover, true);
                }
                catch
                {
                    //prevents error if file is already in the images folder
                }
            }
        }

        private void FrmDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //does error checking when the user submits the form and prevents it from closing if errors are found
            if (this.DialogResult == DialogResult.OK)
            {
                try
                {
                    //creates temporary variables to check for possible errrors
                    int iCheck = int.Parse(txtInv.Text);
                    double dCheck = double.Parse(txtPrice.Text);
                    Image pCheck = Image.FromFile(Application.StartupPath + @"\images\" + cover);
                }
                //prevents error caused by not selecting an image
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Please select a picture");
                    e.Cancel = true;
                }
                //prevents error caused by not entering a number in inventory and price fields
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numbers for the price and inventory");
                    e.Cancel = true;
                }
                //prevents error caused by slecting an invalid image file
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Please select a valid image file");
                    e.Cancel = true;
                }
                //prevents any other errors
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}
