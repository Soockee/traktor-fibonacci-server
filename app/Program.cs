using Traktor;

using System;
namespace Httpserver{
    public class Program{

        public static Tracer tracer = new Tracer();
        public static void Main(string[] args)
        {
            tracer.Configure("127.0.0.1:8080","127.0.0.1", 13336,13337);


                string htmlfolder = @"C:\workspace\staticfiles";
                SimpleHTTPServer server = new SimpleHTTPServer(htmlfolder,8084);
                bool running = true;
                //Now it is running:
                Console.WriteLine("Server is running on this port: " + server.Port.ToString());

                while(running)
                {

                    string input = Console.ReadLine();
                    Console.WriteLine("You entered '{0}'", input);
                    if(input.Equals("exit"))
                    {
                        running = false;
                    }
                }
        }
    }
}