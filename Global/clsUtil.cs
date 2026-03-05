using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer_PL_.Global
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();

            return guid.ToString();
        }
        public static bool CreateFolderIFDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Create Folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string FileName)
        {
            string SourceFilePath = FileName;
            FileInfo fi = new FileInfo(SourceFilePath);
            string Ext = fi.Extension;

            return GenerateGUID() + Ext;


        }
        public static bool CopyImageToProjectImagesFolder(ref string SourceFilePath)
        {
            string DestinationFolderPath = @"C:\DVLD-People-Images\";

            if (!CreateFolderIFDoesNotExist(DestinationFolderPath))
                return false;

            string destinationFile = DestinationFolderPath + ReplaceFileNameWithGUID(SourceFilePath);

            try
            {
                File.Copy(SourceFilePath, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceFilePath = destinationFile;
            return true;
        }
    }
}
