namespace MarfulApi.Model
{
    public class Job
    {
        public int Id { set; get; }
        public double Salary { set; get; }
        public string Code { set; get; }
        public int IdBrand { set; get; }
        public Brand Brand { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        ICollection<Message> Message { set; get; }
    }
}
