using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Models
{
    public partial class Constants
    {
        //public const string DotNetNoteSiteUrl = "http://www.dotnetnote.com";
    }

    public partial class Constants
    {
        public static List<SelectListItem> YesOrNo = new List<SelectListItem>
        {
            //new SelectListItem() { Value = "", Text = "--Select--" },
            new SelectListItem() { Value = "Yes", Text = "Yes" },
            new SelectListItem() { Value = "No", Text = "No" }
        };
        public static List<SelectListItem> YesOrNoK = new List<SelectListItem>
        {
            //new SelectListItem() { Value = "", Text = "--Select--" },
            new SelectListItem() { Value = "Yes", Text = "예" },
            new SelectListItem() { Value = "No", Text = "아니오" }
        };

    }
}
