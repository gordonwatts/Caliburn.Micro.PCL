﻿
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
        public void DisplayViewModelFor<T>()
        {
            _nav.NavigateToViewModel<T>();
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
    }
}
