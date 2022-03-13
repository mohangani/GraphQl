using GraphQLPractice.Models;
using System.Collections.Generic;

namespace GraphQLPractice.Services
{
    public interface IMenuService
    {
        Menu AddMenu(Menu menu);
        Menu GetMenu(int id);
        List<Menu> GetMenus();
        int Remove(int id);
        Menu UpdateMenu(int id, Menu menu);
    }
}