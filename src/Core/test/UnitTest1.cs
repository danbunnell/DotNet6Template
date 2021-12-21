using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet6Template.Core;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Class1 test = new Class1();
        Assert.IsNotNull(test);
    }
}