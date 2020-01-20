using Traktor;

using System;
namespace Httpserver{
    public class Program{

        public static Tracer tracer = new Tracer();
        public static void Main(string[] args)
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                Console.WriteLine("This example runs on Unix");
                string registryaddress = Environment.GetEnvironmentVariable("REGISTRY_URL");
                //should be consistent ip-adress and port
                string agentaddress = Environment.GetEnvironmentVariable("AGENT_IP");
                int agentport = int.Parse(Environment.GetEnvironmentVariable("AGENT_PORT"));
                int reporterport = int.Parse(Environment.GetEnvironmentVariable("REPORTER_PORT"));
                tracer.Configure(registryaddress, agentaddress, agentport, reporterport);
                Console.WriteLine("Tracer connections:\n"
                    + "TraktorRegistry: " + registryaddress + "\n"
                    + "TraktorAgent: " + agentaddress + ":" + agentport + "\n"
                    + "Reporter Port: " + reporterport + "\n");
            }
            else
            {
                string registryaddress = "127.0.0.1:8080";
                string agentaddress = "127.0.0.1";
                int agentport = 13336;
                int reporterport = 13337;
                Console.WriteLine("This example runs on NON-Unix with Default Localhost Settings");
                tracer.Configure(registryaddress, "127.0.0.1", agentport, reporterport);
                Console.WriteLine("Tracer connections:\n"
                    + "TraktorRegistry: " + registryaddress +"\n"
                    + "TraktorAgent: " + agentaddress +":"+ agentport+"\n"
                    + "Reporter Port: " + reporterport +"\n");

            }

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