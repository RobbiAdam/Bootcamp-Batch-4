namespace EventhandlerWDelegate;

public class FollowerOne
{
    public void OnTweetNotified(object sender, string tweetMessage)
    {
        
        string name = ((AccountOne)sender).Name;
        Console.WriteLine("Account one you get notif from " + name + " [" + tweetMessage + "] ");
    }
}
