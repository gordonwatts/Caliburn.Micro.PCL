
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
        public void DisplayViewModelFor<T>()
        {
            _nav
                .UriFor<T>()
                .Navigate();
        }
    }
}
