using NUnit.Framework;
using ReviewHook;

namespace ReviewHookTest
{
    [TestFixture]
    public class TortoiseSvnPatchGeneratorTest
    {
        [TestCase()]
        public void WorkingCopyWrongPath_GenerateEmptyPath()
        {
            TortoiseSvnPatchGenerator tortoiseSvnPatchGenerator = new TortoiseSvnPatchGenerator();

            tortoiseSvnPatchGenerator.GetPatchFromWorkingCopy(
                @"C:\Users\victor\Documents\Visual Studio 2015\Projects\Checkout");
        }
    }
}
