﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHero.CleanArchitecture.Application.Requests.Catalog
{
    public class GetAllPagedProductsRequest : PagedRequest
    {
        public string SearchString { get; set; }
    }
}