﻿using System;
using Xunit;

namespace dotenv.net.Tests.TestFixtures
{
    public class VariousValueTypesFixture : IDisposable
    {
        public VariousValueTypesFixture()
        {
            DotEnv.Config()
                .WithEnvFiles("various-value-types.env")
                .Load();
        }

        public void Dispose()
        {
            // do nothing
        }
    }
}