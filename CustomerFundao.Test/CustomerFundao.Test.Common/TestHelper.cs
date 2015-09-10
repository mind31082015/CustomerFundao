using System.Dynamic;

namespace CustomerFundao.Test.Common
{
    public static class TestHelper
    {
        public static dynamic Bag { get; private set; }

        static TestHelper()
        {
            Bag = new ExpandoObject();
        }
    }
}
