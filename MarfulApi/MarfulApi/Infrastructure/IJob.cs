using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IJob
    {
        public void Update(Job job);
        public void Save(Job job);
        public List<Job> GetJobsInfo(int info);
        public void Delete(int id);
        public List<Job> GetJobsCompany(int idbrand);
    }
}
