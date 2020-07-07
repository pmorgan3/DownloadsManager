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
        static string DOWNLOADS_FOLDER = "C:\\Users\\" + Environment.UserName +"\\Downloads";
        static string PDF_FOLDER = DOWNLOADS_FOLDER + "\\PDFs";
        static string PICTURES_FOLDER = DOWNLOADS_FOLDER + "\\Pics";
        static string ISO_FOLDER = DOWNLOADS_FOLDER + "\\ISOs";
        static string EXE_FOLDER = DOWNLOADS_FOLDER + "\\EXEs";
        static string ZIP_FOLDER = DOWNLOADS_FOLDER + "\\Archives";
        static string VIDEO_FOLDER = DOWNLOADS_FOLDER + "\\VIDEOs";
        static string AUDIO_FOLDER = DOWNLOADS_FOLDER + "\\MUSIC";
        static string DOCUMENTS_FOLDER = DOWNLOADS_FOLDER + "\\DOCUMENTS";
        static string FONTS_FOLDER = DOWNLOADS_FOLDER + "\\FONTS";

        /** 
         * Checks to see whether the necessary folders are present
         **/
        static void Init()
        {
            // Make sure the directory exists
            // If it doesn't exist, the user probably has a custom downloads folder, so exit the program
            if (!Directory.Exists(DOWNLOADS_FOLDER))
                Environment.Exit;

            // Move the current process into the downloads folder
            Directory.SetCurrentDirectory(DOWNLOADS_FOLDER);

            // Each of these checks to see if the folder we're moving things to exists
            // If it doesn't exist it'll create the folder
            Directory.CreateDirectory(PDF_FOLDER);
            Directory.CreateDirectory(PICTURES_FOLDER);
            Directory.CreateDirectory(ISO_FOLDER);
            Directory.CreateDirectory(EXE_FOLDER);
            Directory.CreateDirectory(ZIP_FOLDER);
            Directory.CreateDirectory(VIDEO_FOLDER);
            Directory.CreateDirectory(AUDIO_FOLDER);
            Directory.CreateDirectory(FONTS_FOLDER);
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

            // PDFs
            Program.MoveFile(PDF_FOLDER, "*.pdf");
            // Images
            Program.MoveFile(PICTURES_FOLDER, "*.png");
            Program.MoveFile(PICTURES_FOLDER, "*.jpeg");
            Program.MoveFile(PICTURES_FOLDER, "*.jpg");
            Program.MoveFile(PICTURES_FOLDER, "*.gif");
            Program.MoveFile(PICTURES_FOLDER, "*.bmp");
            Program.MoveFile(PICTURES_FOLDER, "*.tiff");
            Program.MoveFile(PICTURES_FOLDER, "*.raw");
            Program.MoveFile(PICTURES_FOLDER, "*.svg");
            Program.MoveFile(PICTURES_FOLDER, "*.ico");
            Program.MoveFile(PICTURES_FOLDER, "*.jfif");
            // ISOs
            Program.MoveFile(ISO_FOLDER, "*.iso");
            // Executables
            Program.MoveFile(EXE_FOLDER, "*.exe");
            Program.MoveFile(EXE_FOLDER, "*.msi");
            Program.MoveFile(EXE_FOLDER, "*.bat");
            // Archives
            Program.MoveFile(ZIP_FOLDER, "*.zip");
            Program.MoveFile(ZIP_FOLDER, "*.tar.gz");
            Program.MoveFile(ZIP_FOLDER, "*.pkg");
            Program.MoveFile(ZIP_FOLDER, "*.tar");
            Program.MoveFile(ZIP_FOLDER, "*.rar");
            Program.MoveFile(ZIP_FOLDER, "*.7z");
            // Audio
            Program.MoveFile(AUDIO_FOLDER, "*.mp3");
            Program.MoveFile(AUDIO_FOLDER, "*.wav");
            Program.MoveFile(AUDIO_FOLDER, "*.wma");
            Program.MoveFile(AUDIO_FOLDER, "*.ogg");
            // Videos
            Program.MoveFile(VIDEO_FOLDER, "*.mp4");
            Program.MoveFile(VIDEO_FOLDER, "*.mkv");
            Program.MoveFile(VIDEO_FOLDER, "*.mov");
            Program.MoveFile(VIDEO_FOLDER, "*.wmv");
            Program.MoveFile(VIDEO_FOLDER, "*.webm");
            Program.MoveFile(VIDEO_FOLDER, "*.avi");
            // Documents
            Program.MoveFile(DOCUMENTS_FOLDER, "*.txt");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.docx");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.doc");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.ppt");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.pptx");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.cfg");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.config");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.xls");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.xlsx");
            Program.MoveFile(DOCUMENTS_FOLDER, "*.csv");
            // Fonts
            Program.MoveFile(FONTS_FOLDER, "*.ttf");
            Program.MoveFile(FONTS_FOLDER, "*.otf");
            Program.MoveFile(FONTS_FOLDER, "*.chr");

        }
    }
}
