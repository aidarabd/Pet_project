namespace AspInAction.Interfaces
{
    public interface IEmailSender
    {
        public void sendMessage();
    }

    public class SmtpClient
    {
        public string _host { get; set; }
        public int _port { get; set; }

        public SmtpClient(string host, int port)
        {
            _host = host;
            _port = port;
        }
    }
}