using GraphQLPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Services
{
    public class SubMenuService : ISubMenuService
    {
        List<SubMenu> Menus = new List<SubMenu>() {
        new SubMenu{ Id=1,MenuId=1,Name="chicken Lollypop",Description="chicken lollypop",Price=250},
        new SubMenu{ Id=2,MenuId=1,Name="Prawns Fry",Description="Prawns fry dry item",Price=250},
        new SubMenu{ Id=3,MenuId=1,Name="Mutton Rolls",Description="Bone Less mutton rolls Dry item",Price=250},

        new SubMenu{ Id=4,MenuId=2,Name="veg Soop",Description="Veg Mancho",Price=110},
        new SubMenu{ Id=5,MenuId=2,Name="Chicken Soop",Description="Chicken Mancho",Price=120},
        new SubMenu{ Id=6,MenuId=2,Name="Mutton Soop",Description="Mutton Bone Soop",Price=140},

        new SubMenu{ Id=7,MenuId=3,Name="Chicken Biryani",Description="Chicken Fry Piece Biryani",Price=280},
        new SubMenu{ Id=8,MenuId=3,Name="Mutton Biryani",Description="Mutton Fry Piece Biryani",Price=380}
        };

        public List<SubMenu> GetSubMenus()
        {
            return Menus;
        }
        public List<SubMenu> GetSubMenusByMenuId(int menuId)
        {
            return Menus.Where(s => s.MenuId == menuId).ToList();
        }
        public SubMenu GetSubMenu(int id)
        {
            return Menus.Find(s => s.Id == id);
        }

        public SubMenu AddMenu(SubMenu submenu)
        {
            Menus.Add(submenu);
            return submenu;
        }
        public SubMenu UpdateMenu(int id, SubMenu submenu)
        {
            var menuobj = Menus.Find(s => s.Id == id);
            submenu.Id = id;
            menuobj = submenu;
            return submenu;
        }
        public int Remove(int id)
        {
            Menus.RemoveAt(id);
            return id;
        }
    }
}
