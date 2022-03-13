using GraphQL;
using GraphQL.Types;
using GraphQLPractice.Models;
using GraphQLPractice.Services;
using GraphQLPractice.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: contect => menuService.GetMenus());
          
            Field<MenuType>("menubyid", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => menuService.GetMenu(context.GetArgument<int>("id")));
        }


    }
}
