namespace MarfulApi.Model
{
    public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Phone { set; get; }
        public int Age { set; get; }
        public string Baybal { set; get; }
        public byte[] Image { set; get; }
        public ICollection<InfulonserUser> infulonserUser { set; get; }
        public ICollection<UserPost> UserPost { set; get; }
        public ICollection<UserCompany> UserCompany { set; get; }

    }
}
