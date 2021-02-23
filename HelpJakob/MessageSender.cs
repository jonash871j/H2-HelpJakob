namespace HelpJakob
{
    public static class MessageSender
    {
        /// <summary>
        /// Used to send msg to recipient 
        /// </summary>
        public static void SendMessage(MessageCarrier msgCarrier, Message msg, bool isHTML)
        {
            // In this scope we send a email out to the reciver
            if (msgCarrier.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                {
                    msg.Body = HTMLConverter.BodyToHTML(msg.Body);
                }
                // Implements Smtp code
            }

            if (msgCarrier.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                {
                    msg.Body = HTMLConverter.BodyToHTML(msg.Body);
                }
                // Implements VMessage code
            }
        }
    }
}
