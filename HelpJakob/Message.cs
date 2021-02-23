namespace HelpJakob
{
    public class Message
    {
        public Message(string to, string from, string body, string subject, string cc)
        {
            To = to;
            From = from;
            Body = body;
            Subject = subject;
            Cc = cc;
        }

        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }
    }
}
