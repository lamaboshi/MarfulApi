using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class JobRepo : IJob
    {
        private readonly MarfulDbContext _db;
        public JobRepo(MarfulDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var result = _db.Jobs.First(p => p.Id == id);
            if (result != null)
            {
                var meesage = _db.Messages.Where(p => p.JobId == result.Id).ToList();
                if (meesage.Count != 0) _db.Messages.RemoveRange(meesage);
                var post = _db.Posts.Where(p => p.JobId == result.Id).ToList();
                if (post.Count != 0) _db.Posts.RemoveRange(post);
                _db.Jobs.Remove(result);
                _db.SaveChanges();
            }
        }

        public Company GetCompany(int idJob)
        {
            var data = _db.Jobs.Where(y => y.Id == idJob).Select(t => t.Messages.First().Conversation.Company).First();
            return data;
        }

        public List<Job> GetJobsCompany(int idbrand)
        {
            var result = _db.Jobs.Where(p => p.BrandId == idbrand).Include(t=>t.Brand).ThenInclude(r=>r.CompanyContent).ThenInclude(e=>e.Company).ToList();
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public List<Job> GetJobsInfo(int info)
        {
            var result = _db.Jobs.Where(p => p.InfulonserId == info).Include(t=>t.Infulonser).ToList();
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(Job job)
        {
            if (job.Id == 0)
            {
                var allMessage = job.Messages.ToList();
                job.Messages = null;
                _db.Jobs.Add(job);
                _db.SaveChanges();
                foreach (var item in allMessage)
                {
                    var messageEntity = _db.Messages.First(t => t.Id == item.Id);
                    if (messageEntity != null)
                    {
                        messageEntity.Id = item.Id;
                        messageEntity.SendTime = item.SendTime;
                        messageEntity.MessageStatus = item.MessageStatus;
                        messageEntity.ConversationId = item.ConversationId;
                        messageEntity.Text = item.Text;
                        messageEntity.JobId = job.Id;
                        _db.SaveChanges();
                    }
                }
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
