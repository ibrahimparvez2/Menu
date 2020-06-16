using System.Collections.Generic;

namespace MenuTree
{
    public class SubMenuItem: IMenuItem
    {
        public string MenuText { get; set; }
        public List<SubMenuItem> Children { get; set; }

        public SubMenuItem(string menuText, List<SubMenuItem>? subMenuItems)
        {
            this.MenuText = menuText;
            Children = subMenuItems;
        }
    }
    
}