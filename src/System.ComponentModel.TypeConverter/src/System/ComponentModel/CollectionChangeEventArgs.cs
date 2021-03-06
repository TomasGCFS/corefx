// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel
{
    /// <summary>
    /// <para>Provides data for the <see langword='CollectionChange '/> event.</para>
    /// </summary>
    public class CollectionChangeEventArgs : EventArgs
    {
        private readonly CollectionChangeAction _action;
        private readonly object _element;

        /// <summary>
        /// <para>Initializes a new instance of the <see cref='System.ComponentModel.CollectionChangeEventArgs'/> class.</para>
        /// </summary>
        public CollectionChangeEventArgs(CollectionChangeAction action, object element)
        {
            _action = action;
            _element = element;
        }

        /// <summary>
        ///    <para>Gets an action that specifies how the collection changed.</para>
        /// </summary>
        public virtual CollectionChangeAction Action
        {
            get
            {
                return _action;
            }
        }

        /// <summary>
        ///    <para>Gets the instance of the collection with the change. </para>
        /// </summary>
        public virtual object Element
        {
            get
            {
                return _element;
            }
        }
    }
}
