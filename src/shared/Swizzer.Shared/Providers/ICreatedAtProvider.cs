﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Shared.Providers
{
    public interface ICreatedAtProvider
    {
        DateTime CreatedAt { get; set; }
    }
}
