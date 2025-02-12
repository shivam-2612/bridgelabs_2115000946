using System;

class User
{
    public int UserID;
    public string Name;
    public int Age;
    public string Friends;
    public User Next;
}

class FriendManager
{
    private User head;

    public void AddFriend(int userId, string name, int age, string friendIds)
    {
        User newUser = new User { UserID = userId, Name = name, Age = age, Friends = friendIds };
        newUser.Next = head;
        head = newUser;
    }

    public void RemoveFriend(int userId)
    {
        if (head == null) return;
        if (head.UserID == userId)
        {
            head = head.Next;
            return;
        }
        User temp = head;
        while (temp.Next != null && temp.Next.UserID != userId)
        {
            temp = temp.Next;
        }
        if (temp.Next != null) temp.Next = temp.Next.Next;
    }
}
