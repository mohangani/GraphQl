using GraphQL.Types;
using GraphQLPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLPractice.Types
{
    public class SubMenuType:ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(c => c.Id);
            Field(c => c.MenuId);
            Field(c => c.Name);
            Field(c => c.Description);
            Field(c => c.Price);
        }
    }
}
