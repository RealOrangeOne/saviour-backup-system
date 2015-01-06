using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading;
using Microsoft.Win32;
using System.Windows.Forms;
namespace Saviour_Backup_System
{
    class compression
    {
        private static List<Thread> threads = new List<Thread>();
        private volatile static string Gdirectory;
        private volatile static string GfileName;

        public static void Compress(string directory, string outputFile) {
            GfileName = outputFile; Gdirectory = directory; //store as globals
            compressToZip();
            if (has7Zip()) {
                DialogResult result = MessageBox.Show("7-Zip has been detected on your computer\nWould you like to use this instead?", "Use 7-Zip?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    threads.Add(new Thread(new ThreadStart(compression7Zip)));
                    threads[threads.Count].Start();
                    return;
                }
            } else {
                //7z.exe interface code goes here!
            }
            MessageBox.Show("Compression for drive" + "DRIVE NAME" + "has completed.", "Compression Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void compression7Zip() { //need to write this!
            string fileToCompress = Gdirectory + GfileName + ".zip";
            string outputFile = Gdirectory.Replace("\\Temp", GfileName + ".SB");
            MessageBox.Show("Compression of your drive has begun. Be aware this can take a lot of time to run", "Compression Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CompressFileLZMA(fileToCompress, outputFile);
        }

        private static void compressToZip() {
            ZipFile.CreateFromDirectory(Gdirectory, Gdirectory + GfileName + ".zip"); //create the zip file inside the temp directory still.
        }

        private static void CompressFileLZMA(string inFile, string outFile)
        {
            SevenZip.Compression.LZMA.Encoder coder = new SevenZip.Compression.LZMA.Encoder();
            FileStream input = new FileStream(inFile, FileMode.Open);
            FileStream output = new FileStream(outFile, FileMode.Create);
            // Write the encoder properties
            coder.WriteCoderProperties(output);

            // Write the decompressed file size.
            output.Write(BitConverter.GetBytes(input.Length), 0, 8);

            // Encode the file.
            coder.Code(input, output, input.Length, -1, null);
            output.Flush();
            output.Close();
        }

        private static void DecompressFileLZMA(string inFile, string outFile)
        {
            SevenZip.Compression.LZMA.Decoder coder = new SevenZip.Compression.LZMA.Decoder();
            FileStream input = new FileStream(inFile, FileMode.Open);
            FileStream output = new FileStream(outFile, FileMode.Create);

            // Read the decoder properties
            byte[] properties = new byte[5];
            input.Read(properties, 0, 5);

            // Read in the decompress file size.
            byte[] fileLengthBytes = new byte[8];
            input.Read(fileLengthBytes, 0, 8);
            long fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

            coder.SetDecoderProperties(properties);
            coder.Code(input, output, input.Length, fileLength, null);
            output.Flush();
            output.Close();
        }

        private static bool has7Zip() {
            string path = (string) Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\7-Zip", "Path", "NULL");
            if (path == "NULL") { return false;}
            return File.Exists(path + "7z.exe");
        }
    }
}
