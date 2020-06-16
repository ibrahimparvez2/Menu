using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuTab mtAdmin = new MenuTab("Administration");
         
           
            List<SubMenuItem> UserAdministrationSub = new List<SubMenuItem>()
            {
                new SubMenuItem("Create",null),
                new SubMenuItem("Edit",null),
            };
            
            mtAdmin.SubMenuItems.Children.Add(new SubMenuItem("USERADMIN",UserAdministrationSub));
           
            //////////////////////PRODUCTS////////////////////////////
            
            List<SubMenuItem> allProducts = new List<SubMenuItem>()
            {
                new SubMenuItem("AllProducts",null),
            };
            List<SubMenuItem> productsTab = new List<SubMenuItem>()
            {
                new SubMenuItem("All Products",allProducts),
                new SubMenuItem("Create Product", null)
                
            };
            
            mtAdmin.SubMenuItems.Children.Add(new SubMenuItem("PRODUCTS", productsTab  )); 
            
            ///////////////////// REPORTS/////////////////////////////
            List<SubMenuItem> orderAdmin = new List<SubMenuItem>()
            {
                new SubMenuItem("UpdatedOrder", null),
                new SubMenuItem("CreatedOrder", null)
            };
            List<SubMenuItem> auditReports = new List<SubMenuItem>()
            {
                new SubMenuItem("Audit Reports",orderAdmin),
                
            };
            List<SubMenuItem> OrderReports = new List<SubMenuItem>()
            {
                new SubMenuItem("AuditReports",auditReports),
                new SubMenuItem("Create Order",null),
                
            };
            mtAdmin.SubMenuItems.Children.Add( new SubMenuItem("ORDER ADMIN", OrderReports));
            
            
            ///REPORTS
            
            MenuTab mtReports = new MenuTab("Reports");

            
            List<SubMenuItem> reports = new List<SubMenuItem>()
            {
                new SubMenuItem("Win Tech Report",null),
                new SubMenuItem("Microsoft",null),
            };
            
            mtReports.SubMenuItems.Children.Add(new SubMenuItem("REPORTS", reports ));
        }
    }
}