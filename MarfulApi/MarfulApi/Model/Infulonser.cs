namespace MarfulApi.Model
{
    public class Infulonser
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Paypal { set; get; }
        public string Address { set; get; }
        public string Password { set; get; }
        public string UserName { set; get; }
        public string? Image { set; get; }
        public string Description { set; get; }
        public ICollection<Job> Jobs { set; get; }
        public ICollection<Post> Posts { set; get; }
        public ICollection<Conversation> Conversation { set; get; }
        public ICollection<Brand> Brand { set; get; }
        public ICollection<InfulonserContent> infulonserContent { set; get; }
        public ICollection<InfulonserUser> infulonserUser { set; get; }
    }
}
