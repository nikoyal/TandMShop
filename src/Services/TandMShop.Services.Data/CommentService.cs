using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TandMShop.Data.Common.Repositories;
using TandMShop.Data.Models;
using TandMShop.Services.Mapping;

namespace TandMShop.Services.Data
{
    public class CommentService : ICommentService
    {
        private readonly IDeletableEntityRepository<Comment> comments;
        public CommentService(IDeletableEntityRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public async Task Create(int bedSetId, string userName, string content)
        {
            var comment = new Comment
            {
                BedSetId = bedSetId,
                UserName = userName,
                Content = content,
            };
            await this.comments.AddAsync(comment);
            await this.comments.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int bedSetId)
        {
            var allComments = this.comments.All().Where(x => x.BedSetId == bedSetId);
            return allComments.To<T>().ToList();
        }
    }
}
