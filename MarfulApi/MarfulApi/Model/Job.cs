namespace MarfulApi.Model
{
    public class Job
    {
        public int Id { set; get; }
        public double Salary { set; get; }
        public string Code { set; get; }
        public int BrandId { set; get; }
        public Brand Brand { set; get; }
    }
}
