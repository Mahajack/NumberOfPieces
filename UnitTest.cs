using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using maximumsteps;

namespace MyUnitTest
{
[TestClass]   
public class UnitTest
{
    [TestMethod]
    public void TestGetInputValues()
    {
        Numberofpieces number = new Numberofpieces(); 
        int expectedresult = 1;
        int actualresult = number.GetInputValues(1);
        Assert.AreEqual(expectedresult,actualresult);

        int expectedresult = 2;
        int actualresult = number.GetInputValues(2);
        Assert.AreEqual(expectedresult,actualresult);

        int expectedresult = 3;
        int actualresult = number.GetInputValues(4);
        Assert.AreEqual(expectedresult,actualresult);

        int expectedresult = 4;
        int actualresult = number.GetInputValues(8);
        Assert.AreEqual(expectedresult,actualresult);

    }
    
   
}
}