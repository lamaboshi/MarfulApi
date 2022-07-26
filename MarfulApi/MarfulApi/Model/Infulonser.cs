namespace MarfulApi.Model
{
    public class Infulonser
    {
        
        public int Id { set; get; }
        public string Name { set; get; }
        public string? Phone { set; get; }
        public string Email { set; get; }
        public string Paypal { set; get; }
        public string? Address { set; get; }
        public string Password { set; get; }
        public string? UserName { set; get; }
        public byte[]? Image { set; get; }
        public string? Description { set; get; }
        public virtual ICollection<Job>? Jobs { set; get; }
        public virtual ICollection<Post>? Posts { set; get; }
        public virtual ICollection<Conversation>? Conversation { set; get; }
        public virtual ICollection<Brand>? Brand { set; get; }
        public virtual ICollection<InfulonserContent>? infulonserContent { set; get; }
        public virtual ICollection<InfulonserUser>? infulonserUser { set; get; }
        public virtual ICollection<InfulonserFollowInfulonser>? Follow { set; get; }
        public virtual ICollection<InfulonserFollowInfulonser>? Followed { set; get; }
        public virtual ICollection<InfulonserCompany>? InfulonserCompany { set; get; }
        public virtual ICollection<PostInfulonser>? PostInfulonser { set; get; }
    }
}
