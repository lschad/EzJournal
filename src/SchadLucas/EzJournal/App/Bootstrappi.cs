using System.Windows;
using Autofac;
using SchadLucas.EzJournal.Modules.Root;
using SchadLucas.Wpf.EzMvvm.Context;
using SchadLucas.Wpf.EzMvvm.Core;

namespace SchadLucas.EzJournal.App
{
    public sealed class Bootstrappi : EzBootstrapper
    {
        public Bootstrappi()
        {
            Initialize();
        }

        protected override IViewModel GetRootDataContext() => Container.Resolve<IRootContext>();
        protected override Window GetRootWindow() => Container.Resolve<RootWindow>();
    }
}