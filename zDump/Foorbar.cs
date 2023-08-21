public delegate void NewMemberAddedDelegate(string memberName);
class NewMember
{
    public NewMemberAddedDelegate NewMemberAdded;

    public void AddMember(string memberName)
    {
        NewMemberAdded?.Invoke(memberName);
    }
}
class Room
{
    public void RoomPrepared(string memberName)
    {
        Console.WriteLine($"A room is prepared for {memberName}");
    }
}

class Welcome
{
    public void WelcomeMember(string memberName)
    {
        Console.WriteLine($"Welcome to Hotel {memberName}");
    }
}