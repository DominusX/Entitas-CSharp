//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class Test2Matcher {

    static IMatcher<Test2Entity> _matcherClassToGenerate;

    public static IMatcher<Test2Entity> ClassToGenerate {
        get {
            if(_matcherClassToGenerate == null) {
                var matcher = (Matcher<Test2Entity>)Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.ClassToGenerate);
                matcher.componentNames = Test2ComponentsLookup.componentNames;
                _matcherClassToGenerate = matcher;
            }

            return _matcherClassToGenerate;
        }
    }
}