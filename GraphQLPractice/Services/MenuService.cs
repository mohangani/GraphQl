using GraphQLPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Services
{
    public class MenuService : IMenuService
    {
        List<Menu> Menus = new List<Menu>() {
        new Menu{ Id=1,Name="Snack",Image="snack.jpg"},
        new Menu{ Id=2,Name="Soop",Image="soop.jpg"},
        new Menu{ Id=3,Name="Biryani",Image="biryani.jpg"}
        };

        public List<Menu> GetMenus()
        {
            return Menus;
        }
        public Menu GetMenu(int id)
        {
            //logic
            return Menus.Find(s => s.Id == id);
        }
        public Menu AddMenu(Menu menu)
        {
            Menus.Add(menu);
            return menu;
        }
        public Menu UpdateMenu(int id, Menu menu)
        {
            var menuobj = Menus.Find(s => s.Id == id);
            menu.Id = id;
            menuobj = menu;
            return menu;
        }
        public int Remove(int id)
        {
            Menus.RemoveAt(id);
            return id;
        }
    }
}
