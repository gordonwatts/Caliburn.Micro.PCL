
using System;
namespace Caliburn.Micro.Portable.WS
{
    class NavUriBuilder<T> : INavUriBuilder<T>
    {
        /// <summary>
        /// The uri builder for this class
        /// </summary>
        private UriBuilder<T> _uriBuilder;

        /// <summary>
        /// Create with a new uri builder
        /// </summary>
        /// <param name="uriBuilder"></param>
        public NavUriBuilder(UriBuilder<T> uriBuilder)
        {
            // TODO: Complete member initialization
            this._uriBuilder = uriBuilder;
        }

        /// <summary>
        /// Cause the navigation to happen
        /// </summary>
        public void Navigate()
        {
            _uriBuilder.Navigate();
        }

        /// <summary>
        /// Add a parameter onto the service
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="accessor"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public INavUriBuilder<T> WithParam<TValue>(System.Linq.Expressions.Expression<Func<T, TValue>> accessor, TValue val)
        {
            return new NavUriBuilder<T>(_uriBuilder.WithParam(accessor, val));
        }
    }
}
