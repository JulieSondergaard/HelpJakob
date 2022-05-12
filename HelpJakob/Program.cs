using System;

namespace HelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("jules", "james", "hello world", "some subject", "bill");

            MessageSender msgSender = new MessageSender();

            msgSender.sendMessage(MessageCarrier.Smtp, msg, true);
        }
    }


}
