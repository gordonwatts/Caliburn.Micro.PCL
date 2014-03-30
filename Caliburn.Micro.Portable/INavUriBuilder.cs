
using System;
using System.Linq.Expressions;
namespace Caliburn.Micro.Portable
{
    /// <summary>
    /// Represents a navigation Uri that is being built
    /// </summary>
    public interface INavUriBuilder<T>
    {
        /// <summary>
        /// Navagate to the Uri that has been built by this service.
        /// </summary>
        void Navigate();

        /// <summary>
        /// Add a new parameter onto the list and return a new navagation service (e.g. this tries to be
        /// really functional).
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="accessor"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        INavUriBuilder<T> WithParam<TValue>(Expression<Func<T, TValue>> accessor, TValue val);
    }
}
