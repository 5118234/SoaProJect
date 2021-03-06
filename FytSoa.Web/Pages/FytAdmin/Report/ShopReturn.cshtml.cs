﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytSoa.Core.Model.Erp;
using FytSoa.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytSoa.Web.Pages.FytAdmin.Report
{
    public class ShopReturnModel : PageModel
    {
        private readonly IErpShopsService _shopsService;
        public ShopReturnModel(IErpShopsService shopsService)
        {
            _shopsService = shopsService;
        }

        public List<ErpShops> shopList { get; set; }
        public void OnGet(string guid)
        {
            shopList = _shopsService.GetPagesAsync(new Service.DtoModel.PageParm() { limit = 2000 }).Result.data.Items;
        }
    }
}