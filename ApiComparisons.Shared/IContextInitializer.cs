﻿using ApiComparisons.Shared.DAL;

namespace ApiComparisons.Shared
{
    public interface IContextInitializer
    {
        void Seed(DummyContext context);
    }
}