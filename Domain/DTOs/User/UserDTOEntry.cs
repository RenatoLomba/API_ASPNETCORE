﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs.User
{
    public class UserDTOEntry
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
