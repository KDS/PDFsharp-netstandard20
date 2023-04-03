﻿using MigraDoc.GrammarByExample;
using Xunit;

namespace GdiGrammarByExample
{
    /// <summary>
    /// Grammar by example unit test class.
    /// </summary>
    // ReSharper disable InconsistentNaming
    [Collection("GBE")]
    public class DdlGBE_Image_Layout : DdlGbeTestBase, IClassFixture<GbeFixture>
    {
        public DdlGBE_Image_Layout(GbeFixture fixture)
        {
            _fixture = fixture;
        }

        public override void TestInitialize()
        {
            InitializeTest(_fixture, "Image-Layout", 2, 0);
        }

        [Fact]
#if CORE
        public void DDL_Grammar_By_Example_Image_Layout()
#elif GDI
        public void GDI_DDL_Grammar_By_Example_Image_Layout()
#elif WPF
        public void WPF_DDL_Grammar_By_Example_Image_Layout()
#endif
        {
            RunTest();
        }
        // ReSharper restore InconsistentNaming

        readonly GbeFixture _fixture;
    }
}
