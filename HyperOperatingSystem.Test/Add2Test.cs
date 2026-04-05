#if true
// ReSharper disable once CheckNamespace
namespace Global.HyperOperatingSystem.Test;
using Global;
using System.Collections.Generic;
using NUnit.Framework;
using static Global.EasyObject;
public class Add2Test {
    [SetUp]
    public void Setup() {
        Echo($"{FullName(this)}#Setup() called");
    }
    [Test]
    public void Test01() {
        AssertIdentical(expected: 333, actual: HyperOperatingSystem.Add2(111, 222));
        Echo("passed-0");
        AssertEquivalent(expected: new object[] { 11, 22, 33 }, actual: NewArray(11, 22, 33));
        Echo("passed-02");
        var data1 = new Dictionary<string, object?> {
            { "Apple", 1 },
            { "Banana", 2 },
            { "List", NewArray(11, 22, 33) },
        };
        var data2 = new { Apple = 1, Banana = 2, List = NewArray(11, 22, 33) };
        Echo(data1, "data2");
        AssertEquivalent(expected: data1, actual: data2);
        Echo("passed-03");
    }
}
#endif
