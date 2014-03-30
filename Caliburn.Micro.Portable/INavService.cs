
namespace Caliburn.Micro.Portable
{
    /// <summary>
    /// Navigation service for changing views.
    /// </summary>
    public interface INavService
    {
        /// <summary>
        /// Switch to a new view model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void NavigateToViewModel<T>();

        /// <summary>
        /// Return a Uri builder for a more complex view model request
        /// (e.g. with parameters).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        INavUriBuilder<T> UriForViewModel<T>();

        /// <summary>
        /// Returns true if we can go back a page
        /// </summary>
        bool CanGoBack { get; }

        /// <summary>
        /// Goes back one page, if allowed.
        /// </summary>
        void GoBack();
    }
}
