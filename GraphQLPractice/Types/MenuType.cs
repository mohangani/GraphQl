using GraphQL.Types;
using GraphQLPractice.Models;
using GraphQLPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenuService subMenuService)
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Image);
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => subMenuService.GetSubMenusByMenuId(context.Source.Id));
     
        }
    }
}
