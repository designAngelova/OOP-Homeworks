﻿using System;

namespace CompanyApp.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
