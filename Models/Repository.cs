namespace MeetingApp.Models
{

    public static class Repository
    {
        private static List<UserInfo> _users = new();   


        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1 ,Name="ali",Email="abc@gmail.com", Phone="1111",WillAttend=true});
            _users.Add(new UserInfo() { Id = 2, Name ="ahmet",Email="abcd@gmail.com", Phone="2222",WillAttend=false});
            _users.Add(new UserInfo() { Id = 3, Name ="canan",Email="abce@gmail.com", Phone="33333",WillAttend=true});
        }



        public static List<UserInfo> Users { 
            get {
            return _users;
            }
        }

 



        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id) 
        {
            return _users.FirstOrDefault(i => i.Id == id);


        }


    }
}
