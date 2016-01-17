using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FileHandlingAssignment
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //Variable Dictionary
        //games     -holds all game data for title, platform, genre, developer, price, inventory, and cover art file
        //count     -holds the number of game entries in the program
        //line      -holds lines from the text file
        //parts     -holds the split parts of the text file line
        //pos       -temporary variable used to hold the position of a game in the array
        //max       -holds the maximum value for shell sorting technique
        //compare   -holds value of game being compared with for sorting
        //gap       -holds value of space between games being compared for sorting
        //done      -tells sorting method if it is done a section of its sorting
        //subtotal  -holds the subtotal price for a transaction
        //tax       -holds the tax price for a transaction
        //total     -holds the final price for a transaction
        //entry     -used to open, get, and set values for data entry dialog
        //select    -used to open, get, and set values for game selection form
        //help      -used to open help form
        //cover     -temporarily hold cover image file in entry dialog
        //num       -holds number of game entries for game selection form
        //iCheck    -used to check for errors with inventory number from entry dialog
        //dCheck    -used to check for errors with price value from entry dialog
        //pCheck    -used to check for errors with image file from entry dialog

        public struct GameInfo
        {
            //set up structure with values for game title, platform, genre, developer, price, inventory, and cover art
            public string game;
            public string platform;
            public string genre;
            public string dev;
            public double price;
            public int inv;
            public string cover;
        }

        //initialize game data array and variable to hold # of entries
        public GameInfo[] games = new GameInfo[100];
        int count = 0;

        private void addNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initializes entry dialog form
            FrmEntry entry = new FrmEntry();
            if (entry.ShowDialog() == DialogResult.OK)
            {
                //increment # of entries
                count++;
                //set values of structure to the entries from the form
                games[count].game = entry.Title;
                games[count].platform = entry.Platform;
                games[count].dev = entry.Developer;
                games[count].genre = entry.Genre;
                games[count].price = entry.Price;
                games[count].inv = entry.Inventory;
                games[count].cover = entry.Cover;
                //sorts game titles
                sort();
                //refills combo box
                comboFill();
            }
        }

        private void saveInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saves data to text file
            SaveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize temporary variables for reading delimitted text file
            string line;
            string[] parts;
            //set file dialog location to the application's folder
            ofdData.InitialDirectory = Application.StartupPath;
            //sets dialog to only show text files
            ofdData.Filter = "SQL Files (*.mdf)|*.mdf";
            ofdData.FilterIndex = 1;
            if (ofdData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    /*
                    StreamReader r = new StreamReader(ofdData.FileName);
                    //resets # of entries to 0
                    count = 0;
                    //goes through all lines of text file
                    while ((line = r.ReadLine()) != null)
                    {
                        //increments # of entries
                        count++;

                        parts = line.Split(',');
                        
                        //sets structure values to the different parts of the line in text file
                        games[count].game = parts[0];
                        games[count].platform = parts[1];
                        games[count].dev = parts[2];
                        games[count].genre = parts[3];
                        games[count].price = double.Parse(parts[4]);
                        games[count].inv = int.Parse(parts[5]);
                        games[count].cover = parts[6];
                        //sorts by game title
                        sort();
                        //refills combo box
                        comboFill();
                        //resets all text boxes
                        Reset();
                    }
                    
                    r.Close(); */


                    SqlConnection dataConn = new SqlConnection("Server=localhost;Integrated security=sspi;database=" + Path.GetFileNameWithoutExtension(ofdData.FileName));
                    dataConn.Open();

                    SqlDataReader r = null;
                    //resets # of entries to 0
                    count = 0;
                    SqlCommand read = new SqlCommand("SELECT * from " + Path.GetFileNameWithoutExtension(ofdData.FileName) + "_items", dataConn);
                    r = read.ExecuteReader();
                    //goes through all lines of text file
                    while (r.Read())
                    {
                        //increments # of entries
                        count++;
                        //sets structure values to the different parts of the line in text file
                        games[count].game = r["Title"].ToString();
                        games[count].platform = r["Platform"].ToString();
                        games[count].dev = r["Developer"].ToString();
                        games[count].genre = r["Genre"].ToString();
                        games[count].price = double.Parse(r["Price"].ToString());
                        games[count].inv = int.Parse(r["Inventory"].ToString());
                        games[count].cover = r["Image"].ToString();
                        //sorts by game title
                        sort();
                        //refills combo box
                        comboFill();
                        //resets all text boxes
                        Reset();
                    }
                    dataConn.Close();

                }
                //prevents error caused by invalid file selection
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void removeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows game selection dialog
            int pos = SelectGame();
            //makes sure a game was selected
            if (pos != 0)
            {
                //replaces the game to be removed with the last game
                games[pos].game = games[count].game;
                games[pos].platform = games[count].platform;
                games[pos].dev = games[count].dev;
                games[pos].genre = games[count].genre;
                games[pos].price = games[count].price;
                games[pos].inv = games[count].inv;
                games[pos].cover = games[count].cover;
                //decreases number of entries to remove last game
                count--;
                //sorts games
                sort();
                //refills combo box
                comboFill();
                //reset all text boxes
                Reset();
            } 
        }

        private void cmbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set entry number to the game selected in combo box
            int pos = cmbGames.SelectedIndex + 1;
            //show the entry's information in text boxes
            txtTitle.Text = games[pos].game;
            txtPlatform.Text = games[pos].platform;
            txtDev.Text = games[pos].dev;
            txtGenre.Text = games[pos].genre;
            txtPrice.Text = games[pos].price.ToString("c");
            txtInv.Text = games[pos].inv.ToString();
            
            try
            {
                //set picture box image to the game's image file
                picCover.Image = Image.FromFile(Application.StartupPath + @"\images\" + games[pos].cover);
            }
            //prevents eror caused by missing image
            catch (FileNotFoundException)
            {
                //let user reselect the image by changing the entrie's information
                MessageBox.Show(games[pos].cover + " was not found, please reselect image");
                changeInfo(pos);
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resets count to 0
            count = 0;
            //resets all text boxes
            Reset();
            //empties combo box
            comboFill();
        }

        private void changeGameInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows game selection  dialog
            int pos = SelectGame();
            //makes sure a game was selected
            if (pos != 0)
            {
                //changes info for selected game
                changeInfo(pos);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //makes sure there is data to save
            if (count > 0)
            {
                //asks user if they would like to save before closing
                if (MessageBox.Show("Would you like to save your data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //saves data
                    SaveFile();
                }
            }
        }

        private void SaveFile()
        {
            //sets dialog directory to the application's folder
            sfdData.InitialDirectory = Application.StartupPath;
            //sets file type to be saved as text file
            sfdData.Filter = "files |*";
            sfdData.FilterIndex = 1;
            if (sfdData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = Path.GetFileName(sfdData.FileName);
                    SqlConnection servConn = new SqlConnection("Server=localhost;Integrated security=sspi;database=master");

                    string commStr = "CREATE DATABASE "+ fileName + " ON PRIMARY (NAME = " + fileName + "_Data, FILENAME = '" + sfdData.FileName +
                        ".mdf', SIZE = 5MB, MAXSIZE = 10MB, FILEGROWTH = 10%) LOG ON (NAME = " + fileName + "_Log, FILENAME = '"
                        + sfdData.FileName + "Log.ldf', SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)";

                    SqlCommand servStart = new SqlCommand(commStr, servConn);

                    servConn.Open();
                    servStart.ExecuteNonQuery();

                    SqlConnection dataConn = new SqlConnection("Server=localhost;Integrated security=sspi;database=" + fileName);
                    dataConn.Open();


                    SqlCommand changeProp = new SqlCommand("ALTER DATABASE " + fileName + " SET AUTO_CLOSE ON", servConn);
                    changeProp.ExecuteNonQuery();

                    SqlCommand createTable = new SqlCommand("CREATE TABLE " + fileName +"_items (Title varchar(255), Platform varchar(255), Developer varchar(255), Genre varchar(255), Price decimal(38,2), Inventory integer, Image varchar(255))", dataConn);
                    createTable.ExecuteNonQuery();
                    
                    for (int i = 1; i <= count; i++)
                    {
                        SqlCommand fillTable = new SqlCommand("INSERT INTO " + fileName + "_items (Title, Platform, Developer, Genre, Price, Inventory, Image) " +
                            "VALUES ('" + games[i].game + "','" + games[i].platform + "','" + games[i].dev + "','" + games[i].genre + "','" + games[i].price + "','" + games[i].inv + "','" + games[i].cover + "')", dataConn);
                        fillTable.ExecuteNonQuery();
                    }
                    dataConn.Close();
                    servConn.Close();
                }
                //prevents possible errors
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void sort()
        {
            //initialize variables for method
            int max, compare;
            bool done = false;
            //sets initial gap to total number of games
            int gap = count;
            //continues sorting until it is finishes comparing games one apart
            while (gap >= 1)
            {
                //sets gap to half of its previous value
                gap = gap / 2;
                //sets a maximum value for the lower number being compared
                max = count - gap;
                //sets done to false so it doesn't immediately finish
                done = false;
                while (!done)
                {
                    done = true;
                    for (int i = 1; i <= max; i++)
                    {
                        //finds two numbers seperated by gap
                        compare = i + gap;
                        //compares the two game titles to see if they need to be switched
                        if (games[i].game.CompareTo(games[compare].game) > 0)
                        {
                            GameInfo temp = games[i];
                            games[i] = games[compare];
                            games[compare] = temp;
                            //shows that it still needs to continue sorting
                            done = false;
                        }
                    }
                }
            }
        }

        private void comboFill()
        {
            //cleasrs combo box text and items
            cmbGames.Text = "";
            cmbGames.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                //adds all game titles to combo box in order
                cmbGames.Items.Add(games[i].game);
            }
        }

        private void changeInfo(int pos)
        {
            //initializes entry dialog
            FrmEntry entry = new FrmEntry();
            //passes all data for game to the form
            entry.Title = games[pos].game;
            entry.Platform = games[pos].platform;
            entry.Developer = games[pos].dev;
            entry.Genre = games[pos].genre;
            entry.Price = games[pos].price;
            entry.Inventory = games[pos].inv;
            entry.Cover = games[pos].cover;
            if (entry.ShowDialog() == DialogResult.OK)
            {
                //sets game's data to inputted data
                games[pos].game = entry.Title;
                games[pos].platform = entry.Platform;
                games[pos].dev = entry.Developer;
                games[pos].genre = entry.Genre;
                games[pos].price = entry.Price;
                games[pos].inv = entry.Inventory;
                games[pos].cover = entry.Cover;
                //sorst games by title
                sort();
                //refills combo box
                comboFill();
                //empties text boxes
                Reset();
            }
        }

        private void Reset()
        {
            //clears text boxes
            txtTitle.Text ="";
            txtPlatform.Text = "";
            txtDev.Text = "";
            txtGenre.Text = "";
            txtPrice.Text = "";
            txtInv.Text = "";
            //removes picture box image
            picCover.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //sets entry # to the selected game
                int pos = cmbGames.SelectedIndex + 1;
                //changes game's inventory to the value in text box
                games[pos].inv = int.Parse(txtInv.Text);
                //confirms change for the user
                MessageBox.Show("Inventory for " + games[pos].game + " changed to " + games[pos].inv.ToString());
            }
            //prevents error caused by invalid inventory number
            catch
            {
                MessageBox.Show("Please enter a valid inventory number");
            }
        }

        private int SelectGame()
        {
            
            //initialize game selection form
            FrmSelect select = new FrmSelect();
            //tell selection form the number of entries and pass it the game data
            select.NumEntries = count;
            select.Games = games;

            if (select.ShowDialog() == DialogResult.OK)
            {
                //set entry # to the selected game
                int pos = select.Selected;
                if (pos <= 0)
                {
                    MessageBox.Show("No game selected");
                }                
                //returns position of selected game
                return pos;
            }
            //returns 0 to show no game was selected
            return 0;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initilaizes and shows the help form
            FrmHelp help = new FrmHelp();
            help.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //lets user select game to sell
            int pos = SelectGame();
            //makes sure a game is selected and that there is inventory left to sell
            if (pos != 0)
            {
                if (games[pos].inv <= 0)
                {
                    MessageBox.Show("No inventory left");
                }
                else
                {
                    //finds price of game and calculates taxes to find total price
                    double subtotal = games[pos].price;
                    double tax = subtotal * 0.13;
                    double total = subtotal * 1.13;
                    //removes sold game from inventory
                    games[pos].inv--;
                    //shows receipt of transaction
                    MessageBox.Show("Game:" + "\t" + games[pos].game + "\nSubtotal:" + "\t" + subtotal.ToString("c") + "\nTax: " + "\t" + tax.ToString("c") + "\nTotal" + "\t" + total.ToString("c"));
                }
            }
        }
    }
}
