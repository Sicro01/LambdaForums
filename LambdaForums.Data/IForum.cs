﻿using LambdaForums.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LambdaForums.Data
{
    public interface IForum
    {
        Forum GetById(int Id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UPdateForumDescription(int forumId, string newDescription);
    }
}
