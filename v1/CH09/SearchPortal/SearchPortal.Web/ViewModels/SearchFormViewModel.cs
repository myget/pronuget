﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchPortal.Web.ViewModels
{
    public class SearchFormViewModel
    {
        [Display(Name = "Search for")]
        public string SearchTerm { get; set; }

        [Display(Name = "Search engine")]
        public string SearchEngine { get; set; }

        public IEnumerable<SelectListItem> AvailableSearchEngines { get; set; }
    }
}