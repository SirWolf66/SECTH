using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp3
{
    class ServerCode
    {
        // https://codeabout.wordpress.com/2011/03/06/building-a-simple-server-client-application-using-c/

        IPAddress ipAdress = IPAddress.Parse("127.0.0.1");
        public void Test(string clientIpAdress)
        {
            IPAddress ipAdress = IPAddress.Parse(clientIpAdress);
            TcpListener myList = new TcpListener(ipAdress, 8000);
            myList.Start();

            Socket s = myList.AcceptSocket();

            // When accepted
            Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
            byte[] b = new byte[100];
            int k = s.Receive(b);
            Console.WriteLine("Recieved...");
            

            // convert moet per groep bytes voor elke string / item om het object weer op te bouwen
            for (int i = 0; i < k; i++)
            {
                Console.Write(Convert.ToChar(b[i]));
            }

            ASCIIEncoding asen = new ASCIIEncoding();
            s.Send(asen.GetBytes("Automatic message: String received by server!"));
            Console.WriteLine("\n Automatic message sent!");

            s.Close();
            myList.Stop();

        }

}
}
