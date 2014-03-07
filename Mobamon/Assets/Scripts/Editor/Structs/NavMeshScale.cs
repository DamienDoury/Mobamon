using System;

namespace Mobamon.Editor.Structs
{
    /// <summary>
    /// Nav mesh scale.
    /// </summary>
    public struct NavMeshScale
    {
        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <value>The radius.</value>
        public float Radius;
        
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public float Height;
        
        /// <summary>
        /// Gets or sets the acceleration.
        /// </summary>
        /// <value>The acceleration.</value>
        public float Acceleration;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mobamon.Editor.NavMeshScale"/> struct.
        /// </summary>
        /// <param name="radius">Radius.</param>
        /// <param name="height">Height.</param>
        /// <param name="acceleration">Acceleration.</param>
        public NavMeshScale(float radius, float height, float acceleration)
        {
            Radius = radius;
            Height = height;
            Acceleration = acceleration;
        }
    }
}

