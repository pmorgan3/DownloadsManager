using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// This App sorts my downloads folder by file type
namespace DownloadsManager
{   
    
    class Program
    {
        const string DOWNLOADS_FOLDER = "C:\\Users\\pmorg\\Downloads";
        const string PDF_FOLDER = DOWNLOADS_FOLDER + "\\PDFs";
        const string PICTURES_FOLDER = DOWNLOADS_FOLDER + "\\Pics";
        const string ISO_FOLDER = DOWNLOADS_FOLDER + "\\ISOs";
        const string EXE_FOLDER = DOWNLOADS_FOLDER + "\\EXEs";
        const string ZIP_FOLDER = DOWNLOADS_FOLDER + "\\ZIPs";


        /** 
         * Checks to see whether the necessary folders are present
         **/
        static void Init()
        {
            // Move the current process into the downloads folder
            Directory.SetCurrentDirectory(DOWNLOADS_FOLDER);

            // Each of these checks to see if the folder we're moving things to exists
            // If it doesn't exist it'll create the folder
            Directory.CreateDirectory(PDF_FOLDER);
            Directory.CreateDirectory(PICTURES_FOLDER);
            Directory.CreateDirectory(ISO_FOLDER);
            Directory.CreateDirectory(EXE_FOLDER);
            Directory.CreateDirectory(ZIP_FOLDER);
        }

        static void MoveFile(string dest_folder, string extention)
        {
            var files = Directory.EnumerateFiles(DOWNLOADS_FOLDER, extention);
            foreach (var currentFile in files)
            {
                string fileName = currentFile.Substring(DOWNLOADS_FOLDER.Length + 1);
                Directory.Move(currentFile, Path.Combine(dest_folder, fileName));
            }
        }

        static void Main(string[] args)
        {
            Program.Init();
            Program.MoveFile(PDF_FOLDER, "*.pdf");
            Program.MoveFile(PICTURES_FOLDER, "*.png");
            Program.MoveFile(PICTURES_FOLDER, "*.jpeg");
            Program.MoveFile(PICTURES_FOLDER, "*.jpg");
            Program.MoveFile(ISO_FOLDER, "*.iso");
            Program.MoveFile(EXE_FOLDER, "*.exe");
            Program.MoveFile(EXE_FOLDER, "*.msi");
            Program.MoveFile(ZIP_FOLDER, "*.zip");

        }
    }
}
