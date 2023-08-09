void Main() {
	Publisher publisher = new();
	Subscriber sub1 = new();
	Subscriber sub2 = new();
	
	publisher.myEvent += sub1.Notification;
	publisher.myEvent += sub2.Notification;
	
	publisher.NotificationCaller("Hello World");
}

class Publisher
{
	public string name = "Publisher calling";
	public event EventHandler<string> myEvent;
	
	public void NotificationCaller(string notifMessage) {
		myEvent.Invoke(this, notifMessage);
	}
}

class Subscriber {
	public void Notification(object sender, string e) {
		//string name = ((Publisher)sender).name;
		//name.Dump();
		// e.Dump();
	}
}
