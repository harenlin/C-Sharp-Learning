using System;

public class MessageEventArgs : EventArgs {
    public string Message { get; }

    public MessageEventArgs(string message) {
        Message = message;
    }
}

public class Publisher {
	// 1. Define a delegate for the EventHandler (let the subscriber follow this signature).
    public delegate void MessageEventHandler(object sender, MessageEventArgs e);

	// 2. Define a event based on the delegate you just created.
    public event MessageEventHandler MessageEvent;

	// 3. Raise the event
    public void PublishMessage(string message) {
        OnMessagePublished(new MessageEventArgs(message));
    }

	// To raise the event, we need a method that is responsible for that.
	// .NET convention: your event publisher methods should be "protected", "virtual", and "void."
	// For the naming, they should start with the word "On" and then the name of that event.
    protected virtual void OnMessagePublished(MessageEventArgs e) {
        if (MessageEvent != null) {
            MessageEvent(this, e);
        }
    }
}

public class MailSubscriber {
    private readonly string _name;

    public MailSubscriber(string name, Publisher publisher) {
        _name = name;
        publisher.MessageEvent += HandleMessageEvent;
    }

    private void HandleMessageEvent(object sender, MessageEventArgs e) {
        Console.WriteLine($"MailSubscriber {_name} received message: {e.Message}");
    }
}

public class SMSSubscriber {
    private readonly string _name;

    public SMSSubscriber(string name, Publisher publisher) {
        _name = name;
        publisher.MessageEvent += HandleMessageEvent;
    }

    private void HandleMessageEvent(object sender, MessageEventArgs e) {
        Console.WriteLine($"SMSSubscriber {_name} received message: {e.Message}");
    }
}

class PubSubEvents {
    static void Main()
    {
        Publisher publisher = new Publisher();

        MailSubscriber mailSub = new MailSubscriber("mail no-reply@irvine.com", publisher);
        SMSSubscriber smsSub = new SMSSubscriber("sms 92620", publisher);

        publisher.PublishMessage("Hello, World!");
        publisher.PublishMessage("Another message");
    }
}
