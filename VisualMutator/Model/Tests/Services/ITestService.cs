﻿

namespace VisualMutator.Model.Tests.Services
{
    #region

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TestsTree;

    #endregion

    public interface ITestService
    {
        IEnumerable<TestNodeClass> LoadTests(IList<string> assemblies, MutantTestSession mutantTestSession);

        Task<List<TestNodeMethod>> RunTests(MutantTestSession mutantTestSession);

        void UnloadTests();

        void Cancel();
        void CreateTestFilter(ICollection<TestId> selectedTests);
    }

  
}
