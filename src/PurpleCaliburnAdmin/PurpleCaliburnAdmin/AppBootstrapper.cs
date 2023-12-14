using Caliburn.Micro;
using MahApps.Metro.Controls.Dialogs;
using NLog;
using PurpleCaliburnAdmin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PurpleCaliburnAdmin
{
    public class AppBootstrapper : BootstrapperBase
    {
        private CompositionContainer container;

        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public AppBootstrapper()
        {
            this.Initialize();
        }

        protected override void BuildUp(object instance)
        {
            this.container?.SatisfyImportsOnce(instance);
        }

        /// <summary>
        ///     By default, we are configured to use MEF
        /// </summary>
        protected override void Configure()
        {
            var catalog =
                new AggregateCatalog(
                    AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>());

            this.container = new CompositionContainer(catalog);

            var batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue<IDialogCoordinator>(new DialogCoordinator());
            batch.AddExportedValue(this.container);
            batch.AddExportedValue(catalog);

            this.container.Compose(batch);
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return this.container?.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType)) ?? Enumerable.Empty<object>();
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            var contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var export = this.container?.GetExportedValues<object>(contract).FirstOrDefault();

            if (export != null)
            {
                return export;
            }
            logger.Error(new Exception($"Could not locate any instances of contract {contract}."));
            throw new Exception($"Could not locate any instances of contract {contract}.");
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            try
            {
                await this.DisplayRootViewForAsync<LoginViewModel>();
            }
            catch (Exception exception)
            {

                logger.Error(exception);
            }

        }
    }
}
