﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Infrastructure.Services
{
    public class TimeService : ITimeService
    {
        public DateTime Now
        {
            get => DateTime.UtcNow;
        }
    }
}
