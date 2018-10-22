using SchadLucas.Wpf.EzMvvm.Context;
using SchadLucas.Wpf.EzMvvm.Logging;

namespace SchadLucas.EzJournal.Modules.Root
{
    public interface IRootContext : IViewModel { }

    public class RootContext : ViewModel, IRootContext
    {
        private readonly IEzLogger _logger;

        public RootContext(IEzLogger logger)
        {
            _logger = logger;

            _logger.Info("RootContext resolved. Logger was injected properly. ");
        }
    }
}