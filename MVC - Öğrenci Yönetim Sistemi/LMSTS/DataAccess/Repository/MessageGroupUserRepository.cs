﻿using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MessageGroupUserRepository : BaseRepository<MessageGroup_User>
    {
        internal MessageGroupUserRepository(LMSTSContext context) : base(context)
        {
        }
    }
}
