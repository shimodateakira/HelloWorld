using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace HelloWorld.Test;

[TestClass]
public class HelloWorldTest
{
    [TestMethod]
    public void TestMain()
    {
        int c = Program.Add(1, 2);
        Assert.AreEqual(3, c);
        Debug.WriteLine($"c = {c}");
    }
}