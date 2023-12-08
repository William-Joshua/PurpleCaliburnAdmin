using MahApps.Metro.IconPacks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.Models
{
    public class NavigateMenusRootObject
    {
        public List<NavigateMenuItem> menus { get; set; } = new List<NavigateMenuItem>();
    }

    [JsonObject("menu")]
    public class NavigateMenuItem
    {
        public string name { get; set; }
        public string title { get; set; }
        public PackIconMaterialKind iconType { get; set; }
        public string url { get; set; }
        public bool master { get; set; }
        public Boolean subArrow { get; set; }

        public List<NavigateSubMenuItem> submenus { get; set; } = new List<NavigateSubMenuItem>();
    }

    public class NavigateSubMenuItem
    {
        public string name { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public bool master { get; set; }
    }
}
