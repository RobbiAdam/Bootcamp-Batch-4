using EventhandlerWDelegate;

class Program
{
    static void Main(string[] args)
    {
        AccountOne biden = new();
        
        // AccountOne watsonBakery = new();
        FollowerOne ery = new();

        biden.tweetNotif += ery.OnTweetNotified;

        biden.SendNotification("Biden Blast");
    }
}