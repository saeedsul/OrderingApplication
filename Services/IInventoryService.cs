﻿using OrderingApplication.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Services
{
    public interface IInventoryService
    {
        List<InventoryItem> GetInventoryLevels(int threshold);
    }
}
