using GraphQL.Types;
using GraphQLPractice.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery",resolve:context=>new { });
            Field<SubMenuQuery>("submenuQuery", resolve: context => new { });
        }

    }
}
