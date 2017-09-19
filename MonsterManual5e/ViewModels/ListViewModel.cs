using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterManual5e.Models;

namespace MonsterManual5e.ViewModels
{
    public class ListViewModel
    {
        public ICollection<Monster> Monsters { get; set; }

        public ICollection<SelectListItem> Sizes { get; set; }

        public ICollection<SelectListItem> Types { get; set; }

        public ICollection<int> SelectedSizes { get; set; }
    }
}