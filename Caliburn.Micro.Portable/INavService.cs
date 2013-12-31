
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
        void DisplayViewModelFor<T>();
    }
}
