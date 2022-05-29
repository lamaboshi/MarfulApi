namespace MarfulApi.Model
{
    public class UserCompany
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public virtual User? User { set; get; }
        public int CompanyId { set; get; }
        public virtual Company? Company { set; get; }
    }
}
