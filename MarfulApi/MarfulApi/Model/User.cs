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
        public string Paypal { set; get; }
        public byte[]? Image { set; get; }
        public virtual ICollection<InfulonserUser> infulonserUser { set; get; }
        public virtual ICollection<UserPost> UserPost { set; get; }
        public virtual ICollection<UserCompany> UserCompany { set; get; }

    }
}
