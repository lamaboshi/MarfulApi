namespace MarfulApi.Model
{
    public class Infulonser
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string baybal { set; get; }
        public string Address { set; get; }
        public string Password { set; get; }
        public string UserName { set; get; }
        public byte[] Image { set; get; }
        public string Description { set; get; }
        ICollection<Job> Job { set; get; }
        ICollection<Conversation> Conversation { set; get; }
        ICollection<Post> Post { set; get; }
        ICollection<Brand> Brand { set; get; }
        ICollection<InfulonserContent> infulonserContent { set; get; }
        ICollection<InfulonserUser> infulonserUser { set; get; }
    }
}
