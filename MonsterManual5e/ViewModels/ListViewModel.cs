using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterManual5e.Models;

namespace MonsterManual5e.ViewModels
{
    public class ListViewModel
    {
        public ICollection<Monster> Monsters { get; set; }
    }
}