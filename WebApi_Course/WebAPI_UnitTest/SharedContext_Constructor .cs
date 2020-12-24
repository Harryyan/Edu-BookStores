using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace WebAPI_UnitTest
{
    public class SharedContextConstructor : IDisposable
    {
        ITestOutputHelper _output;

        public SharedContextConstructor(ITestOutputHelper output)
        {
            this._output = output;
            _output.WriteLine("Execute constructor!");
        }

        #region Test case
        [Fact(DisplayName = "SharedContext.Constructor.Case01")]
        public void TestCase01()
        {
            _output.WriteLine("Execute case 01!");
        }

        [Fact(DisplayName = "SharedContext.Constructor.Case02")]
        public void TestCase02()
        {
            _output.WriteLine("Execute case 02!");
        }

        [Fact(DisplayName = "SharedContext.Constructor.Case03")]
        public void TestCase03()
        {
            _output.WriteLine("Execute case 03!");
        }
        #endregion

        public void Dispose()
        {
            _output.WriteLine("Execute dispose!");
        }
    }
}
