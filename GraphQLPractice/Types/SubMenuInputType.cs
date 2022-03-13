using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Types
{
    public class SubMenuInputType :InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>("id");
            Field<IntGraphType>("menuId");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<IntGraphType>("price");
        }
    }
}
