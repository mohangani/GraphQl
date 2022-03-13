using GraphQL;
using GraphQL.Types;
using GraphQLPractice.Services;
using GraphQLPractice.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Query
{
    public class SubMenuQuery:ObjectGraphType
    {
        public SubMenuQuery(ISubMenuService subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => subMenuService.GetSubMenus());

            Field<ListGraphType<SubMenuType>>("submenusbymenuid", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuid" }),
             resolve: context => subMenuService.GetSubMenusByMenuId(context.GetArgument<int>("menuid")));

            Field<SubMenuType>("submenu", arguments:new QueryArguments(new QueryArgument<IntGraphType> { Name="id"}), 
                resolve: context => subMenuService.GetSubMenu(context.GetArgument<int>("id")));

          
        }

    }
}
