using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;
namespace InsertInfo
{
    public partial class DataMangementForm : Form
    {
        private sqlOperation aSql = sqlOperation.getInstance();
        public DataMangementForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getDataShowListView();
        }
        public void clearListView()
        {
            listView1.Items.Clear();
        }
        public void getDataShowListView()
        {
            // Create a new ListView control.
            //listView1.Bounds = new Rectangle(new Point(10, 10), new Size(600, 300));
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Descending;
            // Adjust columns width
            listView1.Columns[0].Width = 200;
            listView1.Columns[1].Width = 200;
            listView1.Columns[2].Width = 100;
            listView1.Columns[3].Width = 650 - 200 - 200 - 100;
            // Read from db and show in listview
            List<singleSong> qSongsList = new List<singleSong>();
            if (File.Exists("MyDatabase.sqlite"))
            {
                aSql.openDatabase("MyDatabase.sqlite");
                aSql.queryAll("author", "asc", ref qSongsList);
                int lvIndex = 0;
                List<ListViewItem> allItems = new List<ListViewItem>();
                foreach (var qSong in qSongsList)
                {
                    ListViewItem tempItem = new ListViewItem(qSong.songname, lvIndex);
                    lvIndex++;
                    tempItem.SubItems.Add(qSong.author);
                    tempItem.SubItems.Add(qSong.capo.ToString());
                    tempItem.SubItems.Add(qSong.chords);
                    allItems.Add(tempItem);
                }

                listView1.Items.AddRange(allItems.ToArray());
                this.Controls.Add(listView1);
            }
            else
            {
                MessageBox.Show("Sqlite File Does Not Exists, Push Reset Btn To Generate", "File Does Not Exists");
            }
            
        }
        public void initDatabase()
        {
            // create the db file
            List<singleSong> songsList = new List<singleSong>(){
                new singleSong("Narcissist", "No Rome", 3, "C F Am G"),
                new singleSong("ChunTianHuaHuiKai", "RenXianQi", 0, "G Bm7 C D"),
                new singleSong("Say U Won`t Let Go", "James Arthur", 0, "G Em7 D Cadd7"),
                new singleSong("Dangerous", "Before You Exit", 0, "G C D"),
                new singleSong("Cheating On You", "Charlie Puth", 2, "G D Em7 D"),
                new singleSong("Girlfriend", "Charlie Puth", 1, "G F"),
                new singleSong("Shy", "Jai Waetford", 0, "G C"),
                new singleSong("I Feel it Coming", "The Weekend", 3, "Em Am F C"),
                new singleSong("Blueming", "IU", 0, "F C G Am7"),
                new singleSong("Slow it Down", "Charlie Puth", 3, "F Am7"),
                new singleSong("B-e-a-utiful", "Megan Nicole", 0, "F C G Am")
            };
            
            // INSERT ONCE AS INIT FILE
            if (File.Exists("MyDatabase.sqlite"))
            {
                MessageBox.Show("Delete Old One First", "Delete Before Reset");
                return;
            }
            if (aSql.createDatabase("MyDatabase.sqlite"))
                aSql.createTable();
            aSql.insertCollection(songsList);
            aSql.openDatabase("MyDatabase.sqlite");
            Console.WriteLine("                 -----------AFTER------------            ");
            //List<singleSong> qSongsList = new List<singleSong>();
            //aSql.queryAll("author", "asc", ref qSongsList);
            // for a test
            aSql.insertSingle(new singleSong("Beautiful Mistakes", "Maroon 5", 3, "C G D"));
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            Console.WriteLine("[INFO]Col {0} is clicked!", e.Column);
            if (e.Column % 2 == 0)
            {
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                listView1.Sorting = SortOrder.Descending;
            }
            
            
        }
        // timer1 internal set to 5 secs to show the search results
        private void OnTimerEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].BackColor = Color.White;
            }
        }   
        private void author_Click(object sender, EventArgs e)
        {
            string target = textBox1.Text.ToString();
            if (string.IsNullOrEmpty(target))
            {
                MessageBox.Show("Empty traget", "Invalid Target");
            }
            else
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (!string.IsNullOrEmpty(listView1.Items[i].SubItems[1].Text))
                    {
                        string listStr = listView1.Items[i].SubItems[1].Text;
                        bool foundFlag = listStr.Equals(target, StringComparison.CurrentCultureIgnoreCase);
                        if (listStr.Contains(' '))
                        {
                            foundFlag |= listStr.Split(' ')[0].Equals(target, StringComparison.CurrentCultureIgnoreCase);
                            foundFlag |= listStr.Split(' ')[1].Equals(target, StringComparison.CurrentCultureIgnoreCase);
                        }
                        
                            
                        if (foundFlag)
                        {
                            timer1.Tick += new System.EventHandler(OnTimerEvent); 
                            listView1.Items[i].BackColor = Color.Yellow;
                        }

                    }
                }
            }
        }
        private void songFirstLetter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text.ToString()))
            {
                MessageBox.Show("Empty traget", "Invalid Target");
            }
            char target = textBox2.Text.ToString()[0];
            if (!char.IsLetter(target))
            {
                MessageBox.Show("Empty traget", "Invalid Target");
            }
            else
            {
                
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (!string.IsNullOrEmpty(listView1.Items[i].SubItems[1].Text))
                    {
                        if (char.ToUpperInvariant(target) == char.ToUpperInvariant(listView1.Items[i].SubItems[0].Text[0]))
                        {
                            timer1.Tick += new System.EventHandler(OnTimerEvent);
                            listView1.Items[i].BackColor = Color.Lime;
                        }
                    }
                }

            }
        }
        private void insert_Click(object sender, EventArgs e)
        {
            
            string songTxt = textBox3.Text;
            string authorTxt = textBox4.Text;
            string capoTxt = textBox5.Text;
            string chordsTxt = textBox6.Text;
            bool invalidInsertArg = songTxt == string.Empty || authorTxt == string.Empty || int.Parse(capoTxt) < 0 || int.Parse(capoTxt) > 14 || !chordsTxt.Contains(' ');
            if (invalidInsertArg)
            {
                MessageBox.Show("invalidInsertArg", "Invalid Arg");
            }
            else
            {
                // song name first letter all to upper
                string upperSongTxt = null;
                string upperauthorTxt = null;
                if (songTxt.Contains(' '))
                {
                    foreach (var cell in songTxt.Split(' '))
                    {
                        string temp = char.ToUpper(cell[0]) + cell.Substring(1);
                        upperSongTxt += temp + ' ';
                        Console.WriteLine("{0}", upperSongTxt);
                    }
                    upperSongTxt = upperSongTxt.Substring(0, upperSongTxt.Length - 1);
                }
                else
                {
                    upperSongTxt = songTxt.Substring(0, songTxt.Length - 1);
                }
                if (authorTxt.Contains(' '))
                {
                    // author name first letter all to upper
                    foreach (var cell in authorTxt.Split(' '))
                    {
                        string temp = char.ToUpper(cell[0]) + cell.Substring(1);
                        upperauthorTxt += temp + ' ';
                    }
                    upperauthorTxt = upperauthorTxt.Substring(0, upperauthorTxt.Length - 1);
                }
                else
                {
                    upperauthorTxt = authorTxt.Substring(0, authorTxt.Length - 1);
                }
                aSql.openDatabase("MyDatabase.sqlite");
                aSql.insertSingle(new singleSong(upperSongTxt, upperauthorTxt, int.Parse(capoTxt), chordsTxt));
                MessageBox.Show("Ok", "Insert Done");
            }
        }
       
        private void btnReload_Click(object sender, EventArgs e)
        {
            // clear first to avoid duplication
            clearListView();
            getDataShowListView();
        }

        private void btnResetDB_Click(object sender, EventArgs e)
        {
            initDatabase();
        }
    }
    public class singleSong
    {
        public string songname;
        public string author;
        public string chords;
        public int capo;
        public singleSong(string n, string a, int c, string s)
        {
            this.songname = n;
            this.author = a;
            this.chords = s;
            this.capo = c;
        }
    };
    public class sqlOperation
    {
        static SQLiteConnection m_dbConnection;
        private static sqlOperation instance = null;
        private string sql;
        private SQLiteCommand command;
        private sqlOperation()
        {

        }
        public static sqlOperation getInstance()
        {
            if (instance == null)
                instance = new sqlOperation();
            return instance;
        }
        public bool createDatabase(string fileName)
        {
            // sql start
            SQLiteConnection.CreateFile(fileName);
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            return true;
        }
        public bool openDatabase(string fileName)
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
            m_dbConnection.Open();
            return true;
        }
        public void createTable()
        {
            // create table
            sql = "create table chordify (songname varchar(40) primary key, author varchar(20), capo int, chords varchar(40))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        public bool insertSingle(singleSong aSong)
        {
            if (aSong.songname == string.Empty || aSong.author == string.Empty || aSong.chords == string.Empty)
            {
                Console.WriteLine("[Err]Song name or author or chord is EMPTY!");
                return false;
            }
            sql = "insert into chordify (songname, author, capo, chords) values (" + "'" + aSong.songname + "'" + "," + "'" + aSong.author + "'" + "," + aSong.capo + "," + "'" + aSong.chords + "')";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            return true;
        }
        public bool insertCollection(List<singleSong> songsList)
        {
            if (songsList.Count < 1)
                return false;
            // add songs 
            foreach (var song in songsList)
            {
                if (song.songname == string.Empty || song.author == string.Empty || song.chords == string.Empty)
                {
                    Console.WriteLine("[Err]Song name or author or chord is EMPTY!");
                    return false;
                }
                sql = "insert into chordify (songname, author, capo, chords) values (" + "'" + song.songname + "'" + "," + "'" + song.author + "'" + "," + song.capo + "," + "'" + song.chords + "')";
                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            return true;
        }
        public void queryAll(string qByWhat, string qByWhatOrder, ref List<singleSong> qSongsList)
        {
            // query
            sql = "select * from chordify order by " + qByWhat + " " + qByWhatOrder;
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string printsong;
            int capo;
            string chords;
            Console.WriteLine("          Song                        |   Capo  |     Chords");
            Console.WriteLine("------------------------------------------------------------");
            while (reader.Read())
            {
                // read from db
                qSongsList.Add(new singleSong((string)reader["songname"], (string)reader["author"], (int)reader["capo"], reader["chords"].ToString()));
                // output to console
                printsong = (string)reader["songname"] + "-" + (string)reader["author"];
                capo = (int)reader["capo"];
                chords = reader["chords"].ToString();
                Console.WriteLine("  {0,-35} |    {1,-4} |    {2,-20}", printsong, capo, chords);

            }
        }
        public void closeConnection()
        {
            m_dbConnection.Close();
        }
    }
}
