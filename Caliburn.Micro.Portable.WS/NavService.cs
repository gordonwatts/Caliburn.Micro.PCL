using Caliburn.Micro.Portable;

namespace Caliburn.Micro.Portable.WS
{
    /// <summary>
    /// Implement the windows store version of the navigation service by
    /// wrapping Caliburn.Micro's WS implementation.
    /// </summary>
    public class NavService : INavService
    {
        /// <summary>
        /// Hold onto the navigation service
        /// </summary>
        private readonly INavigationService _nav;
        public NavService(INavigationService nav)
        {
            _nav = nav;
        }

        /// <summary>
        /// Move to the proper spot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void DisplayViewModelFor<T>()
        {
            _nav.NavigateToViewModel<T>();
        }
    }
}
