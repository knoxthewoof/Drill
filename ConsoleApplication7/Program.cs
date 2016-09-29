using System;
using System.IO;

namespace TCF
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Hello();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                string filePath = @"C:\Users\jj\Desktop\New folder (5)\error.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Message :" + ex.Message + "<br/>" + Environment.NewLine + "Date :" + DateTime.Now.ToString()+ Environment.NewLine + 
                        "StackTrace :" + ex.StackTrace + "");
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
                }
            }
        }

        public static void Hello()
        {
            try
            {
            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("This Line Will Be Executed");//This line executes because the exception hasn't happened yet
                int result = Convert.ToInt32("Ten");//This is where the exception occurs
                Console.WriteLine("This Line Will Not Be Executed");//This line doesn't execute because the program has stopped on the previous lines exception
            }
        }
    }
}
