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
using System.Collections;
using System.Collections.Generic;


namespace IntrusionDetectionSystem
{
    public partial class Form1 : Form
    {
        private List<string> ModifiedFiles = new List<string>();
        private List<string> CreatedFiles = new List<string>();
        private List<string> DeletedFiles = new List<string>();
        private List<string> RenamedFilesON = new List<string>();
        private SortedSet<string> ModifiedFilesSet = new SortedSet<string>();
        private Dictionary<string, string> RenamedFiles = new Dictionary<string, string>();
        static string directoryPath = "";
        static string backupPath = "F:\\Intrusion Detection System Backup Directory";
        string password = "pass";
        FileSystemWatcher watcher;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void WatcherMethod()
        {
            watcher = new FileSystemWatcher();

            watcher.Path = Path.Combine(directoryPath, "") ;
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.Filter = "*.*";
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;

            //Adding Event Handlers...!!
            watcher.Renamed += Watcher_Renamed;
            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;
            watcher.Disposed += Watcher_Disposed;


        }

        private void Watcher_Disposed(object sender, EventArgs e)
        {
            //MessageBox.Show("Disposed   ");
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            //MessageBox.Show("Deleted  Name= " + e.Name + "ChangeType= " + e.ChangeType  );
            DeletedFiles.Add(e.Name);
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            //MessageBox.Show( "File created with name " + e.Name + " FullPath= " + e.FullPath + " ChangeType= " + e.ChangeType);
            CreatedFiles.Add(e.Name);
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            //MessageBox.Show("Changed   ChangeType= " + e.ChangeType + " FullPath= " + e.FullPath + " Name= " + e.Name );
            ModifiedFiles.Add(e.Name);
            ModifiedFilesSet.Add(e.Name);
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            //MessageBox.Show("Renamed      ChangeType= " + e.ChangeType+ " FullPath= " + e.FullPath + " Name= " + e.Name + " OldFullPath= " + e.OldFullPath + " OldName= " + e.OldName  );
            RenamedFiles.Add(e.OldName, e.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dlg.SelectedPath);
                directoryPath = dlg.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(password) && CopyDirectory(directoryPath, backupPath))
            {
                WatcherMethod();
                MessageBox.Show("ISD Started...!!");
            }
            else
            {
                MessageBox.Show("Incorrect Passowrd");
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(password))
            {
                watcher.EnableRaisingEvents = false;
                new Form2(backupPath, directoryPath, ModifiedFilesSet, CreatedFiles, DeletedFiles).Show();
                
                //messagebox.show("modified   ====   " + modifiedfiles);
                //messagebox.show("created    ====   " + createdfiles);
                //messagebox.show("renamed    ====   " + renamedfiles);
                //messagebox.show("deleted    ====   " + deletedfiles);
                
            }
            else
            {
                MessageBox.Show("Incorrect Passowrd");
            }

        }

        private bool CopyDirectory(string SourcePath, string DestinationPath)
        {
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);

            return true;

        }
    }
}