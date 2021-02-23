namespace HelpJakob
{
    public static class MessageSender
    {
        /// <summary>
        /// Used to send msg to recipient 
        /// </summary>
        public static void SendMessage(string recipient, MessageCarrier msgCarrier, Message msg, bool isHTML)
        {
            // In this scope we send a email out to the reciver
            if (msgCarrier.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                {
                    msg.Body = HTMLConverter.BodyToHTML(msg.Body);
                }
                // her implementeres alt koden til at sende via Smtp
            }

            if (msgCarrier.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                {
                    msg.Body = HTMLConverter.BodyToHTML(msg.Body);
                }
                // her implementeres alt koden til at sende via VMessage
            }
        }

        /// <summary>
        /// Used to sends message to all 
        /// </summary>
        public static void SendMessageToAll(string[] recipients, MessageCarrier msgCarrier, Message msg, bool isHTML)
        {
            foreach (string recipient in recipients)
            {
                SendMessage(recipient, msgCarrier, msg, isHTML);
            }
        }
    }
}
