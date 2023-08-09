namespace EventhandlerWDelegate;

class AccountOne
{
    
    public string Name { get; set; }

    public event EventHandler<string> tweetNotif;

    public void SendNotification(string tweetMessage)
    {
        tweetNotif?.Invoke(this, tweetMessage);
    }

}
