
namespace Caliburn.Micro.Portable.WP8
{
    public class NavService : INavService
    {
        /// <summary>
        /// Hold onto a copy of the Windows Phone nav service
        /// </summary>
        private readonly INavigationService _nav;

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
