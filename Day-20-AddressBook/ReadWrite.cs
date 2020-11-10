using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_20_AddressBook
{
    class ReadWrite
    {
        /// <summary>
        /// Reads from stream reader.
        /// </summary>
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\admin\source\repos\Day-20-AddressBook\Day-20-AddressBook\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String fileData = "";
                    while ((fileData = sr.ReadLine()) != null)
                        Console.WriteLine((fileData));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }

        /// <summary>
        /// Writes the using stream writer.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void WriteUsingStreamWriter(List<string> data)
        {
            string path = @"C:\Users\admin\source\repos\Day-20-AddressBook\Day-20-AddressBook\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (string contact in data)
                    {
                        streamWriter.WriteLine(contact);
                    }
                    streamWriter.Close();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
    }
}
    
