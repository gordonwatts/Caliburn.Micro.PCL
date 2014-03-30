
namespace Caliburn.Micro.Portable.WS
{
    /// <summary>
    /// Implement the windows store version of the navigation service by
    /// wrapping Caliburn.Micro's WS implementation.
    /// </summary>
    public class NavService : INavService
    {
        /// <summary>
        /// Local cache for use when we have to move around.
        /// </summary>
        private readonly INavigationService _nav;

        /// <summary>
        /// Hold onto the navigation service
        /// </summary>
        public NavService(INavigationService nav)
        {
            _nav = nav;
        }

        /// <summary>
        /// Move to the proper spot.
        /// </summary>
        /// <typeparam name="T">Type of the view model to open</typeparam>
        public void NavigateToViewModel<T>()
        {
            _nav
                .UriFor<T>()
                .Navigate();
        }

        /// <summary>
        /// Return a new uri builder for this navigation service
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public INavUriBuilder<T> UriForViewModel<T>()
        {
            return new NavUriBuilder<T>(_nav.UriFor<T>());
        }

        /// <summary>
        /// Given a WinRT version of the navigation service, register this facade in the container
        /// so others can make easy use of it.
        /// </summary>
        /// <param name="service">The WinRT Navigation Service</param>
        /// <param name="container">The main container for CM</param>
        public static void RegisterINavService(INavigationService service, WinRTContainer container)
        {
            var mynav = new NavService(service);
            container.RegisterInstance(typeof(INavService), null, mynav);
        }

        /// <summary>
        /// True if we are allowed to go back by one.
        /// </summary>
        public bool CanGoBack
        {
            get { return _nav.CanGoBack; }
        }

        /// <summary>
        /// Go back one page
        /// </summary>
        public void GoBack()
        {
            _nav.GoBack();
        }
    }
}
