using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WincanToolsLib;

namespace WincanMediaCreator
{
    public partial class Form1 : Form
    {
        public static string sourceDBstr ="";
        private DBManager dbSource = new DBManager(sourceDBstr);
        private string sampleFilePath = @"D:\Temp\SampleFiles\";

        public Form1()
        {
            InitializeComponent();
            

           
        }
        private string GetFilename()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                return "";
            }
        }

        private void buttonSourceDB_Click(object sender, EventArgs e)
        {
            textBoxSourceDB.Text = "";
            sourceDBstr = GetFilename();
            textBoxSourceDB.Text = sourceDBstr;

            dbSource = new DBManager(sourceDBstr);
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            DataTable mediaList = new DataTable();

            mediaList = GetDataFromDB();


            
            //create a list of files to copy
            List<KeyValuePair<string,string>> files = new List<KeyValuePair<string, string>>();
            foreach (DataRow dr in mediaList.Rows)
            {
                if (true)
                {

                    string filename = "", filePath = "";
                    
                    if (!String.IsNullOrEmpty(dr["FilePath"].ToString()))
                    {
                        filePath = dr["FilePath"].ToString();
                    }
                    if (!String.IsNullOrEmpty(dr["FileName"].ToString()))
                    {
                        filename = dr["FileName"].ToString();
                        files.Add(new KeyValuePair<string, string>(filename, filePath));
                    }

                    
                }
                
            }
            string projectFolder =  System.IO.Path.GetDirectoryName(dbSource.DBFileName);
            //If is vx go back to the root (delete \DB)
            if (dbSource.typeOfDb == DBManager.SQLCE)
            {
                projectFolder = projectFolder.Substring(0, projectFolder.Length - 2);
            }
            
            List<string> PicExtesionList = new List<string> { ".jpg", ".bmp" };
            List<string> VidExtesionList = new List<string> { ".mpg", ".mp4", ".avi", ".wmv" };



            // Copy the files and overwrite destination files if they already exist. 
            foreach (KeyValuePair<string,string> filenameStrings in files)
            {
                string destFolder = projectFolder+"\\";
                string fileExtension = System.IO.Path.GetExtension(filenameStrings.Key);

                // Use static Path methods to extract only the file name from the path.
                if (PicExtesionList.Contains(fileExtension))
                {
                    if (String.IsNullOrEmpty(filenameStrings.Value))
                    {
                        destFolder = destFolder + "Picture\\Sec\\";
                    }
                    else
                    {
                        destFolder = destFolder + filenameStrings.Value ;
                    }
                   
                }
                else if (VidExtesionList.Contains(fileExtension))
                {
                    if (String.IsNullOrEmpty(filenameStrings.Value))
                    {
                        destFolder = destFolder + "Video\\Sec\\";
                    }
                    else
                    {
                        destFolder = destFolder +filenameStrings.Value ;
                    }
                    
                }
                //check that ends with '\'
                if (destFolder.Substring(destFolder.Length - 1) != "\\")
                {
                    destFolder = destFolder + "\\";
                }
                CopyFiles(fileExtension, destFolder, filenameStrings.Key);
            }
            MessageBox.Show("Done");
        }

        private DataTable GetDataFromDB()
        {
            string query;
            if (dbSource.typeOfDb == DBManager.SQLCE)
            {
                query = @"SELECT [OMM_Type]
		                            ,[OMM_FilePath] as FilePath
		                            ,[OMM_FileName] as FileName
		                            ,[OMM_FileType]
                            FROM [SECOBSMM]";
            }
            else
            {
                query = @"SELECT `Image_Reference` as FileName
	                        	,`Image_Path` as FilePath
                             FROM `Media_Conditions`
	                        union
	                        	SELECT `Video_File` as FileName
	                        	,`Video_File_Path` as FilePath
	                        FROM `Media_Conditions`
	                        union
	                        SELECT `Video_Name` as FileName
	                        	,`Video_Location` as FilePath
	                        FROM `Media_Inspections`
	                        UNION
	                        SELECT `Image_Reference` as FileName
	                        	,`Image_Path` as FilePath
                             FROM `LACP_Media_Conditions`
	                        union
	                        	SELECT `Video_File` as FileName
	                        	,`Video_File_Path` as FilePath
	                        FROM `LACP_Media_Conditions`
	                        union
	                        SELECT `Video_Name` as FileName
	                        	,`Video_Location` as FilePath
	                        FROM `LACP_Media_Inspections`";
            }


            dbSource.OpenConnection();
            DataTable mediaList = new DataTable();

            mediaList = dbSource.Get(query);
            dbSource.CloseConnection();
            return mediaList;
        }

        private void CopyFiles(string extension, string destFolder, string filenameString)
        {
            if (!System.IO.Directory.Exists(destFolder))
            {
                System.IO.Directory.CreateDirectory(destFolder);
            }

            if (System.IO.Directory.Exists(destFolder))
            {
                var destFile = System.IO.Path.Combine(destFolder, filenameString);
                try
                {
                    System.IO.File.Copy(sampleFilePath + "Sample" + extension, destFile, false);

                }
                catch (Exception e)
                {

                    MessageBox.Show("error creating files");
                }

            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }

        private void buttonPicFolderBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                textBoxPicFolder.Text =  folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonVidFolderBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                textBoxVidFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonChangeDirectory_Click(object sender, EventArgs e)
        {

            string picqueryString = @"UPDATE [SECOBSMM] 
                                    SET [OMM_FilePath] ='" + textBoxPicFolder.Text + "' "
                                    + " WHERE [OMM_Type] = 'PI1' OR [OMM_Type] = 'PI2'";
            string vidqueryString = @"UPDATE [SECOBSMM] 
                                    SET [OMM_FilePath] ='" + textBoxVidFolder.Text + "' "
                                    + " WHERE [OMM_Type] = 'CLI'";
                            ;
            dbSource.OpenConnection();
            dbSource.insert(picqueryString);
            dbSource.insert(vidqueryString);
            dbSource.CloseConnection();
            MessageBox.Show("done");
        }
    }
}
