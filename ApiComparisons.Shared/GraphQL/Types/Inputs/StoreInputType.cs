﻿using ApiComparisons.Shared.DAL;
using GraphQL.Types;

namespace ApiComparisons.Shared.GraphQL.Types.Inputs
{
    public class StoreInputType : InputObjectGraphType<Store>
    {
        public StoreInputType()
        {
            Name = "StoreInput";
            Field(o => o.ID).Name("id").Description("The store's ID.");
            Field(o => o.Country).Description("The store country.");
            Field(o => o.Name).Description("The name of the store.");
            Field(o => o.Address).Description("The store address.");
            Field(o => o.Created).Description("Store creation date.");
        }
    }
}
