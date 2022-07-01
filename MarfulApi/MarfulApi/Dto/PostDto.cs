using MarfulApi.Model;
namespace MarfulApi.Dto
{
    public class PostDto
    {
        public Post post { get; set; }
        public bool Interaction { get; set; }
        public bool NoInteraction { get; set; }
    }
}
