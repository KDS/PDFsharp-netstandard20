﻿using MigraDoc.GrammarByExample;
using Xunit;

namespace GdiGrammarByExample
{
    /// <summary>
    /// Grammar by example unit test class.
    /// </summary>
    // ReSharper disable InconsistentNaming
    [Collection("GBE")]
    public class DdlGBE_Attributes_Border : DdlGbeTestBase, IClassFixture<GbeFixture>
    {
        public DdlGBE_Attributes_Border(GbeFixture fixture)
        {
            _fixture = fixture;
        }

        public override void TestInitialize()
        {
            InitializeTest(_fixture, "Attributes-Border", 2, 0);
        }

        [Fact]
#if CORE
        public void DDL_Grammar_By_Example_Attributes_Border()
#elif GDI
        public void GDI_DDL_Grammar_By_Example_Attributes_Border()
#elif WPF
        public void WPF_DDL_Grammar_By_Example_Attributes_Border()
#endif
        {
            RunTest();
        }
        // ReSharper restore InconsistentNaming

        readonly GbeFixture _fixture;
    }
}
