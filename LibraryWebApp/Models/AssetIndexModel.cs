﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApp.Models
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetsIndexListingModel> Assets { get; set; }
    }
}
