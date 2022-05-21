namespace MarfulApi.Model
{
    public class Company
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string TelePhone { set; get; }
        public string Address{ set; get; }
        public string? Image { set; get; }
        public string Description { set; get; }
        public ICollection<Conversation> conversation { set; get; }
        public ICollection<UserCompany> UserCompanie { set; get; }
        public ICollection<CompanyContent> CompanyContent { set; get; }


    }
}
