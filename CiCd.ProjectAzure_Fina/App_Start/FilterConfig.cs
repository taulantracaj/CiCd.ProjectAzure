﻿using System.Web;
using System.Web.Mvc;

namespace CiCd.ProjectAzure_Fina
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
