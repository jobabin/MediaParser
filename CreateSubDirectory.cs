using System;
using System.Collections.Generic;
using System.Text;

namespace Vid_Pic_Sorter
{
    public class CreateSubDirectory
    {
        public static void Main()
        {
            //Still need to fill this out to create directory with name of "date/time"

            // Create a reference to a directory.
            DirectoryInfo di = new DirectoryInfo("TempDir");

            // Create the directory only if it does not already exist.
            if (di.Exists == false)
                di.Create();

            // Create a subdirectory in the directory just created.
            DirectoryInfo dis = di.CreateSubdirectory("SubDir");

            
        }
    }