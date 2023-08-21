namespace zDump2;

public class Member
{
    protected string _memberName;

    public event Action<string> NewMemberAdded;

    public void AddMember(string memberName)
    {
        // _memberName = memberName;
        NewMemberAdded?.Invoke(memberName);
    }
}
