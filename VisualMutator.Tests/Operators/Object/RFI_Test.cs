﻿namespace VisualMutator.Tests.Operators.Object
{
    #region

    using System;
    using System.Collections.Generic;
    using log4net.Appender;
    using log4net.Config;
    using log4net.Layout;
    using Model;
    using Model.Decompilation;
    using Model.Decompilation.CodeDifference;
    using Model.Mutations.MutantsTree;
    using NUnit.Framework;
    using OperatorsObject.Operators;
    using SoftwareApproach.TestingExtensions;

    #endregion

    [TestFixture]
    public class RFI_Test
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            BasicConfigurator.Configure(
                new ConsoleAppender
                    {
                        Layout = new SimpleLayout()
                    });
        }

        #endregion

     
        [Test]
        public void MutationSuccess()
        {
            const string code =
                @"using System;
namespace Ns
{
    public class Test
    {
        public void Method2(string s)
        {
            object obj = new object();
            string str = """";
            string str2 = null;
            object obj2 = null;
            str = null;
            str = """";
            obj = new object();
        }

    }
}";
       //     new Conditional().;
            MutationTestsHelper.DebugTraverse(code);
            
            List<Mutant> mutants;
            ModulesProvider original;
            CodeDifferenceCreator diff;
            MutationTestsHelper.RunMutations(code, new RFI_ReferencingFaultInsertion(), out mutants, out original, out diff);


            foreach (Mutant mutant in mutants)
            {
                CodeWithDifference codeWithDifference = diff.CreateDifferenceListing(CodeLanguage.CSharp, mutant,
                                                                                     original);
                Console.WriteLine(codeWithDifference.Code);
             //   Assert.AreEqual(codeWithDifference.LineChanges.Count, 2);
            }

            mutants.Count.ShouldEqual(4);
        }
    }
}