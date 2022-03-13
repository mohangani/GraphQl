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
    public class MenuMutation : ObjectGraphType
    {

        public MenuMutation(IMenuService menuservice)
        {
            Field<MenuType>("addMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                resolve: context => menuservice.AddMenu(context.GetArgument<Menu>("menu")));

            Field<MenuType>("updateMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }, new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => menuservice.UpdateMenu(context.GetArgument<int>("id"), context.GetArgument<Menu>("menu")));

            Field<IntGraphType>("deleteMenu", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => menuservice.Remove(context.GetArgument<int>("id")));

        }
    }
}
