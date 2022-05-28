namespace MarfulApi.Model
{
    public class Job
    {
        public int Id { set; get; }
        public double Salary { set; get; }
        public string Code { set; get; }
        public int BrandId { set; get; }
        public virtual Brand Brand { set; get; }
        public int InfulonserId { set; get; }
        public virtual Infulonser Infulonser { set; get; }
        public virtual ICollection<Post> Post { set; get; }
        public virtual ICollection<Message>  Messages { set; get; }
    }
}
