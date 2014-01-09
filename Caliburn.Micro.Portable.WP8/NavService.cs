
using System;
namespace Caliburn.Micro.Portable.WP8
{
    /// <summary>
    /// The Windows Phone 8 version of the navigation wrapper. Create this to hold onto
    /// Calibrun.Micro's INavigationService so it can be used in a PCL.
    /// </summary>
    public class NavService : INavService
    {
        /// <summary>
        /// Hold onto a copy of the Windows Phone nav service
        /// </summary>
        private readonly INavigationService _nav;

        /// <summary>
        /// Create a new portable navigation service wrapping the provided navigation service.
        /// </summary>
        /// <param name="nav">The navigation service from the WP8 Calibrun.Micro run.</param>
        public NavService(INavigationService nav)
        {
            _nav = nav;
        }

        /// <summary>
        /// Move to a new model view
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void NavigateToViewModel<T>()
        {
            _nav
                .UriFor<T>()
                .Navigate();
        }

        /// <summary>
        /// Given a WP8 version of the navigation service, register this facade in the container
        /// so others can make easy use of it.
        /// </summary>
        /// <param name="service">The WinRT Navigation Service</param>
        /// <param name="container">The main container for CM</param>
        public static void RegisterINavService(INavigationService service, PhoneContainer container)
        {
            var mynav = new NavService(service);
            container.RegisterInstance(typeof(INavService), null, mynav);
        }

        /// <summary>
        /// Register a WP8 version of the INavigateService as one of our portable INavService
        /// objects. We fetch the INavigateService object from the container. Normally in a WP8
        /// Caliburn.Micro app, it is already stored in there.
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterINavService(PhoneContainer container)
        {
            var nav = container.GetInstance<INavigationService>();
            if (nav == null)
                throw new ArgumentNullException("Unable to find an INavigationService");
            RegisterINavService(nav, container);
        }
    }
}
