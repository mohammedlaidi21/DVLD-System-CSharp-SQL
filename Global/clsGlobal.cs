using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using DVLD_BusinessLogicLayer_BLL_.Users;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DVLD_PresentationLayer_PL_.Global
{
    internal static class clsGlobal
    {
        public static clsUsers CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

            string FilePath = CurrentDirectory + "\\data.txt";

            try
            {
                if (Username == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string RecordSaved = Username + "#//#" + Password;

                using(StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine(RecordSaved);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
          

            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentDirectory + "\\data.txt";

                if (File.Exists(FilePath))
                {
                    using (StreamReader Reader = new StreamReader(FilePath))
                    {
                        string Line;
                        while ((Line = Reader.ReadLine()) != null)
                        {
                            Console.WriteLine(Line);
                            string[] Result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                            
                            Username = Result[0];
                            Password = Result[1];
                        }

                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
