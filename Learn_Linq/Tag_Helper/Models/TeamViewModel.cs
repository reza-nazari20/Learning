﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tag_Helper.Models
{
    public class TeamViewModel
    {
        public string Team { get; set; }
        public List<SelectListItem> Teams { get; set; }
        public List<SelectListItem> TeamOptionGroup { get; set; }
        public TeamEnum TeamEnum { get; set; }
        public IEnumerable<string> TeamMltiple { get; set; }
        public List<SelectListItem> TeamMltipleItem { get; set; }
    }

    public enum TeamEnum
    {
        [Display(Name ="پرسپولیس")]
        persepolise,
        esteghlal,
        sepahan,
        teraktor,
    }
}
