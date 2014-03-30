using System;

namespace Caliburn.Micro.Portable.WP8
{
    /// <summary>
    /// Uri builder for the navigation service for Windows Phone
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class NavUriBuilder<T> : INavUriBuilder<T>
    {
        private UriBuilder<T> _uriBuilder;

        /// <summary>
        /// Construct a nav service builder
        /// </summary>
        /// <param name="uriBuilder"></param>
        public NavUriBuilder(UriBuilder<T> uriBuilder)
        {
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
