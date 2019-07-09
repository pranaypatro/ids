using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntrusionDetectionSystem;
using System.IO;
namespace IntrusionDetectionSystem
{
    public partial class Form2 : Form
    {

        string backupPath = "";
        string directoryPath = "";
        private SortedSet<string> ModifiedFilesSet = new SortedSet<string>();
        private List<string> CreatedFiles = new List<string>();
        private List<string> DeletedFiles = new List<string>();
        public Form2(string backupPath, string directoryPath, SortedSet<string> ModifiedFilesSet, List<string> CreatedFiles, List<string> DeletedFiles)
        {
            this.ModifiedFilesSet = ModifiedFilesSet;
            this.CreatedFiles = CreatedFiles;
            this.DeletedFiles = DeletedFiles;
            this.backupPath = backupPath;
            this.directoryPath = directoryPath;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach (var item in modifiedfiles)
            {
                messagebox.show(item);
            }
            foreach (var item in createdfiles)
            {
                messagebox.show(item);
            }
            foreach (var item in renamedfiles)
            {
                messagebox.show(item.key + "  " + item.value);
            }

            foreach (var item in deletedfiles)
            {
                messagebox.show(item);
            }*/


            if (MessageBox.Show("Do You Want to Restore the files?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                CopyDirectory(backupPath, directoryPath);
            }
            else if (MessageBox.Show("All the Modified Files will be deleted, Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Directory.Delete(backupPath, true);
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

        private void Form2_Load(object sender, EventArgs e)
        {
            listCreatedFiles.DataSource = CreatedFiles;
            listDeletedFiles.DataSource = DeletedFiles;
            listModifiedFiles.DataSource = ModifiedFilesSet;
            
        }
    }
}
