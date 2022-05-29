using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class JobRepo : IJob
    {
        private readonly MarfulDbContext _db;
        public JobRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Job> GetJobs => _db.Jobs;

        public void Delete(int id)
        {
            var result = _db.Jobs.First(p => p.Id == id);
            if (result != null)
            {
                _db.Jobs.Remove(result);
                _db.SaveChanges();
            }
        }

        public Job GetJob(int IdJob)
        {
            var result = _db.Jobs.First(p => p.Id == IdJob);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(Job job)
        {
            if (job.Id == 0)
            {
                _db.Jobs.Add(job);
                _db.SaveChanges();
            }
        }

        public void Update(Job job)
        {
            if (job.Id != 0)
            {
                var jobEntity = _db.Jobs.First(t => t.Id == job.Id);
                if (jobEntity != null)
                {
                    jobEntity.Salary = job.Salary;
                    jobEntity.BrandId = job.BrandId;
                    jobEntity.InfulonserId = job.InfulonserId;
                    jobEntity.Code = job.Code;
                    _db.SaveChanges();
                }
            }
        }
    }
}
