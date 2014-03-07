using System;
using UnityEngine;

namespace Mobamon.Editor.Structs
{
    /// <summary>
    /// Collider scale.
    /// </summary>
    public struct ColliderScale
    {
        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <value>The radius.</value>
        public float Radius;
        
        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        /// <value>The center.</value>
        public Vector3 Center;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mobamon.Editor.ColliderScale"/> struct.
        /// </summary>
        /// <param name="radius">Radius.</param>
        /// <param name="center">Center.</param>
        public ColliderScale(float radius, Vector3 center)
        {
            Radius = radius;
            Center = center;
        }
    }
}

