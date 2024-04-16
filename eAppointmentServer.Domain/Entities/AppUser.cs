﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Domain.Entities
{
    public sealed class AppUser :IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty; // or string?
        public string LastName { get; set; }= string.Empty;

        public string? FullName => string.Join("", FirstName, LastName);

    }
}
