﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Endjin.Assembly.ChangeDetection.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Difference Detection")]
    public partial class DifferenceDetectionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DifferenceDetection.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Difference Detection", "In order to establish what the semantic version of the build should be\r\nAs the bu" +
                    "ild process\r\nI want to decide if the current assembly has breaking changes from " +
                    "the previous version", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("New Assembly has a non breaking additive change")]
        public virtual void NewAssemblyHasANonBreakingAdditiveChange()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("New Assembly has a non breaking additive change", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("the previous assembly is called \"TestData\\Original\\Original.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.Given("the new assembly is called \"TestData\\NonBreakingAdditiveChange\\Original.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.When("I compare the two assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
testRunner.Then("I should be told there is 1 change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
testRunner.And("I should be told that the change is 1 method has been added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("I should be told that the change is 0 method has been removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("New Assembly has a breaking change due to a public api being modified")]
        public virtual void NewAssemblyHasABreakingChangeDueToAPublicApiBeingModified()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("New Assembly has a breaking change due to a public api being modified", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
testRunner.Given("the previous assembly is called \"TestData\\Original\\Original.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
testRunner.Given("the new assembly is called \"TestData\\BreakingChange\\Original.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
testRunner.When("I compare the two assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
testRunner.Then("I should be told there is 1 change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
testRunner.And("I should be told that the change is 1 method has been added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.And("I should be told that the change is 1 method has been removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Two new assemblies have non breaking additive changes")]
        public virtual void TwoNewAssembliesHaveNonBreakingAdditiveChanges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Two new assemblies have non breaking additive changes", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
testRunner.Given("the previous assemblies are \"TestData\\Original\\Original.dll;TestData\\Original2\\Or" +
                    "iginal2.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.Given("the new assemblies are \"TestData\\NonBreakingAdditiveChange\\Original.dll;TestData\\" +
                    "NonBreakingAdditiveChange2\\Original2.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
testRunner.When("I compare the two sets of assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("I should be told there are 2 changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
testRunner.And("I should be told that the changes include 2 methods have been added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.And("I should be told that the changes include 0 methods have been removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Two new assemblies both have a breaking change due to a public api being modified" +
            "")]
        public virtual void TwoNewAssembliesBothHaveABreakingChangeDueToAPublicApiBeingModified()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Two new assemblies both have a breaking change due to a public api being modified" +
                    "", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given("the previous assemblies are \"TestData\\Original\\Original.dll;TestData\\Original2\\Or" +
                    "iginal2.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
testRunner.Given("the new assemblies are \"TestData\\BreakingChange\\Original.dll;TestData\\BreakingCha" +
                    "nge2\\Original2.dll\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
testRunner.When("I compare the two sets of assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
testRunner.Then("I should be told there are 2 changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
testRunner.And("I should be told that the changes include 2 methods have been added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
testRunner.And("I should be told that the changes include 2 methods have been removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
