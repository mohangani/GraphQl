using GraphQLPractice.Models;
using System.Collections.Generic;

namespace GraphQLPractice.Services
{
    public interface ISubMenuService
    {
        SubMenu AddMenu(SubMenu submenu);
        SubMenu GetSubMenu(int id);
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenusByMenuId(int menuId);
        int Remove(int id);
        SubMenu UpdateMenu(int id, SubMenu submenu);
    }
}