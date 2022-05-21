namespace MarfulApi.Model
{
    public class Job
    {
        public int Id { set; get; }
        public double Salary { set; get; }
        public string Code { set; get; }
        public int BrandId { set; get; }
        public Brand Brand { set; get; }
        public int InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public ICollection<Post> Post { set; get; }
        public ICollection<Message>  Messages { set; get; }
    }
}
