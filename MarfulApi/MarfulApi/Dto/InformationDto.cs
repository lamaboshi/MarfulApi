using MarfulApi.Model;
namespace MarfulApi.Dto
{
    public class InformationDto
    {
        public int jobId { set; get; }
        public Company company { set; get; }
        public double salary { set; get; }
        public List< User>user { set; get; }
    }
}
