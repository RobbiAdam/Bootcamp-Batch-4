using zDump2;

class Program
{
    static void Main(string[] args)
    {
        Member member = new();
        Room room = new();
        Welcome welcome= new Welcome();

        member.NewMemberAdded += welcome.WelcomeMember;
        member.NewMemberAdded += room.AddBedRoom;

        member.AddMember("RYE");

    }
}