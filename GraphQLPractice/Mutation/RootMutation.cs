using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Mutation
{
    public class RootMutation:ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutaion", resolve: context => new { });
            Field<SubMenuMutation>("SubmenuMutaion", resolve: context => new { });
        }
    }
}
