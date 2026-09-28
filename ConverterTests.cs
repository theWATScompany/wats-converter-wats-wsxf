using Virinco.WATS.Interface;
using Xunit;
using Xunit.Abstractions;
using WATS.Testing;

namespace Converter.Tests
{
    public class ConverterTests : ConverterTestBase
    {
        public ConverterTests(ITestOutputHelper output) : base(output) { }
        protected override IReportConverter_v2 CreateConverter() => new WSXFConverter();

        [Fact, Trait("TestMode", "ConvertOnly")]
        public void ConvertOnly_AllFiles() => RunAllFiles(TestMode.ConvertOnly);

        [Fact, Trait("TestMode", "ConvertAndValidate")]
        public void ConvertAndValidate_AllFiles() => RunAllFiles(TestMode.ConvertAndValidate);

        [Fact, Trait("TestMode", "ConvertAndSubmit"), Trait("RequiresServer", "true")]
        public void ConvertAndSubmit_AllFiles() => RunAllFiles(TestMode.ConvertAndSubmit);
    }
}
