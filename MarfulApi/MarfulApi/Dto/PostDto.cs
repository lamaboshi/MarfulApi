using MarfulApi.Model;
namespace MarfulApi.Dto
{
    public class PostDto
    {
        public Post post { get; set; }
        public bool Interaction { get; set; }
        public bool NoInteraction { get; set; } 
        public string Name { get; set; }
        public double NumberLike { get; set; }
        public double NumDislike { get; set; }
        public byte[]? Image { set; get; }
    }
}
