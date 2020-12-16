using System;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input your Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Input your Filename: ");
                string filename = Console.ReadLine();
                Console.WriteLine("Type in your blog content: ");
                string content = Console.ReadLine();

                string filePath = "C:\\New folder\\" + filename + ".html";
         
                //using (FileStream fs = File.Create(filePath))
                //{
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.AppendAllText(filePath, "<h1 style='text-align:center;'>Welcome to " + username + "'s blog!</h1>");
                File.AppendAllText(filePath, "<p style='text-align:center;'>" + content + "</p>");

                //}
                //using (StreamWriter str = File.CreateText(filePath))
                //{
                //    //str.WriteLine("This is from me");
                //    //str.WriteLine("This is amazing");
                //    str.WriteLine("<h1>Welcome to {0}'s blog!</h1>",username);
                //    str.WriteLine("<p>{0}</p>",content);
                //    str.Close();
                //}
                ////ile.AppendAllText(path, "This is an appended line");
                ////File.WriteAllLines(path, "");
                //File.ReadAllText(filePath);

                //LowLevelWrite(filePath);
                var innerText = File.ReadAllText(filePath);

                //Console.WriteLine(innerText);
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
        }
        static void LowLevelWrite(string path)
        {
            //var str = new StreamWriter(path);
            //str.WriteLine("This is from me");
            //str.WriteLine("This is amazing");
            using (var str = new StreamWriter(path))
            {
                //str.WriteLine("This is from me");
                //str.WriteLine("This is amazing");
                str.WriteLine("<h1>Hello Daniel!</h1>");
                str.Close();
            }
            //ile.AppendAllText(path, "This is an appended line");
            //File.WriteAllLines(path, "");
            File.ReadAllText(path);
        }
    }
}
