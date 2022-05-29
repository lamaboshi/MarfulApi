using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IJob
    {
        public void Update(Job job);
        public void Save(Job job);
        public IQueryable<Job> GetJobs { get; }
        public void Delete(int id);
        public Job GetJob(int IdJob);
    }
}
