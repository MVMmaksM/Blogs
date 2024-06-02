using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITagRepository
    {
        Task<Tag> Create(Tag tag);
        Task<List<Tag>> GetTags();
        Task<Tag>GetById(int id);
    }
}
