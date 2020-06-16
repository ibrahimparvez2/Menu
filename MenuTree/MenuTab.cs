using System.Collections.Generic;

namespace MenuTree
{
    public class MenuTab
    {
        public string MenuText { get; set; }
        public SubMenuItem SubMenuItems { get; set; }

        public MenuTab(string name)
        {
            this.MenuText = name;
            SubMenuItems = new SubMenuItem(name, null);
            SubMenuItems.Children = new List<SubMenuItem>();
        }
    }
    
}