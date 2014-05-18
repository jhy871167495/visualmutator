﻿namespace VisualMutator.Infrastructure.NinjectModules
{
    using Ninject.Modules;
    using Views;

    public class ViewsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMutationResultsView>().To<MutationResultsView>();
            Bind<IMutantsSavingView>().To<MutantsSavingView>();
            Bind<ISessionCreationView>().To<SessionCreationView>();
            Bind<IChooseTestingExtensionView>().To<ChooseTestingExtensionView>();
            Bind<IMutantDetailsView>().To<MutantDetailsView>();
            Bind<IResultsSavingView>().To<ResultsSavingView>();
            Bind<ITestsSelectableTree>().To<TestsSelectableTree>();
            Bind<IMutantsCreationOptionsView>().To<MutantsCreationOptionsView>();
            Bind<IMutantsTestingOptionsView>().To<MutantsTestingOptionsView>();
            Bind<IMutationsTreeView>().To<MutationsTree>();
            Bind<ITypesTreeView>().To<TypesTree>();
            Bind<IOptionsView>().To<OptionsView>();

        }
    }
}