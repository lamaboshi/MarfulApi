namespace MarfulApi.Model
{
    public class UserCompany
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public User User { set; get; }
        public int CompanyId { set; get; }
        public Company Company { set; get; }
    }
}
