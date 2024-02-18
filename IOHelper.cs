using System;
using System.IO;
using System.Text;
namespace Lecture8
{

    public class IOHelper
    {
        // Copied from StreamReaderWriterExample.cs
        public static void Test()
        {
            int maxLines = 1000;
            int actualLines = 0;
            string[] countryNames = new string[maxLines];
            double[] countrScores = new double[maxLines];
            // path where the input file is located
            string inputFilePath = "/tmp/2015.csv";

            // path where the output file will be stored
            string outputFilePath = "/tmp/2015_train.csv";

            StreamReader sr = null;

            String s = "";

            try
            {
                // Create an instance of StreamReader to read from a file.
                sr = new StreamReader(inputFilePath);

                string line;
                // Read and display lines from the file until the end of 
                // the file is reached (when line is null)
                while ((line = sr.ReadLine()) != null)
                { // '\n' 'a' 'B' '#'
                    actualLines++;
                    if (actualLines == 1)
                    {
                        // Skip the header
                        continue;
                    }
                    string[] splits = line.Split(',');
                    countryNames[actualLines - 2] = splits[0];
                    countrScores[actualLines - 2] = Convert.ToDouble(splits[3]);
                    Console.WriteLine(actualLines - 1 + "\t" + countryNames[actualLines - 2] + "\t" + countrScores[actualLines - 2]);
                }

            }
            catch (FileNotFoundException e) // try to change the path to a "wrong" path to throw an exception
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            Console.WriteLine(actualLines);

            StreamWriter sw = null;

            try
            {
                // Create an instance of StreamWriter to write to a file.
                sw = new StreamWriter(outputFilePath);
                sw.WriteLine("Country,Happiness Score");
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine(countryNames[i] + "," + countrScores[i]);
                }

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be written:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
        // copied from FileExample.cs
        public static void WriteAndAppendText(String path)
        {

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            string wText = "This is the first sentence of the text file" + Environment.NewLine;
            // add text to the file
            File.WriteAllText(path, wText);

            string aText = "This is the second sentence of the text file; the second sentence has been appended" + Environment.NewLine;
            //// append to existing text
            File.AppendAllText(path, aText);

            // read the text from the file
            string rText = File.ReadAllText(path);
            // print the read text
            Console.WriteLine(rText);

        }
    }
}