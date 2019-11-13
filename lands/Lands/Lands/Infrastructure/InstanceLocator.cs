namespace Lands.Infrastructure
{
    using ViewModels;
    class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Construtor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
