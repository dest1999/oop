using System;
using Xunit;
using Coder;


namespace CoderTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void ACoderTest()
        {
            ACoder coder = new();

            string str = "ALZ alz 90";

            string coded = coder.Encode(str);

            Assert.Equal(str, coder.Decode(coded));
        }

        [Fact]
        public void BCoderTest()
        {
            BCoder coder = new();

            string str = "ALZ alz 90";

            string coded = coder.Encode(str);

            Assert.Equal(str, coder.Decode(coded));
        }



    }
}
