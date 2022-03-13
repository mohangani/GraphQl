using GraphQL;
using GraphQL.Types;
using GraphQLPractice.Models;
using GraphQLPractice.Services;
using GraphQLPractice.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Mutation
{
    public class SubMenuMutation:ObjectGraphType
    {
        public SubMenuMutation(ISubMenuService subMenuService)
        {
            Field<SubMenuType>("addMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType>() { Name = "submenu" }),
               resolve: context => subMenuService.AddMenu(context.GetArgument<SubMenu>("submenu")));

            Field<SubMenuType>("updateMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType>() { Name = "menu" }, new QueryArgument<IntGraphType>() { Name = "id" }),
                resolve: context => subMenuService.UpdateMenu(context.GetArgument<int>("id"), context.GetArgument<SubMenu>("menu")));

            Field<IntGraphType>("deleteMenu", arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id" }),
                resolve: context => subMenuService.Remove(context.GetArgument<int>("id")));
        }

    }
}
