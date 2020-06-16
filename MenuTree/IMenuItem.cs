using System.Collections.Generic;

namespace MenuTree
{
    public interface IMenuItem
    {
        string MenuText { get; set; }
        List<SubMenuItem> Children { get; set; }
    }
}