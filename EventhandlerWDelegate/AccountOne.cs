namespace EventhandlerWDelegate;

class AccountOne
{
    
    public string name { get; set; }

    public event EventHandler<string> tweetNotif;

    public void SendNotification(string tweetMessage)
    {
        tweetNotif?.Invoke(this, tweetMessage);
    }

}
