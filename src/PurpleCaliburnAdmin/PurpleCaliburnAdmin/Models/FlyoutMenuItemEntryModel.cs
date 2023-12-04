using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleCaliburnAdmin.Models
{
    public class FlyoutMenuItemEntryModel
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }

        public PackIconMaterialDesign IconImage{ get; set; }

        /// <summary>
        /// 权限禁用
        /// </summary>
        public bool AccessDenied { get; set; } = true;



    }
}
