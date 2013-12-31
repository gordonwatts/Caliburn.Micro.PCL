using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Caliburn.Micro.Portable
{
    /// <summary>
    /// Utility extension methods for help with propertychangedbase objects.
    /// </summary>
    public static class PropertyChangedBaseUtils
    {
        /// <summary>
        /// Condense the change and notify code into a single line. Much happier, than all
        /// the boiler-plate code that I've been writing for this.
        /// </summary>
        /// <typeparam name="T">The type of the property that is being set.</typeparam>
        /// <param name="propertyChangedBaseObj">The object that the property is attached to ("this")</param>
        /// <param name="propBackingField">Reference to the backing field for the property.</param>
        /// <param name="val">The new value of the property ("val")</param>
        /// <param name="propName">The name of the property, normally automatically provided by the compiler - just leave this blank.</param>
        /// <remarks>This uses EqualityCompare to see if the items are the same. If so, it will not raise an event.</remarks>
        public static void NotifyAndSetIfChanged<T>(this PropertyChangedBase propertyChangedBaseObj, ref T propBackingField, T val,
            [CallerMemberName] string propName = null)
        {
            var areequal = EqualityComparer<T>.Default.Equals(propBackingField, val);
            if (!areequal)
            {
                propBackingField = val;
                propertyChangedBaseObj.NotifyOfPropertyChange(propName);
            }
        }
    }
}
