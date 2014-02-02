using UnityEngine;
using Mobamon.Pokemon.Player;

namespace Mobamon.Database.Classes
{
	/// <summary>
	/// The target involves in a move
	/// </summary>
	public class MoveTarget
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Mobamon.Database.Classes.MoveTarget"/> class.
		/// </summary>
		/// <param name="gameObject">Game object.</param>
		/// <param name="startPosition">Start position.</param>
		public MoveTarget(GameObject gameObject, Vector3 startPosition)
		{
			this.GameObject = gameObject;
			this.StartPosition = startPosition;
		}

		/// <summary>
		/// Gets the game object.
		/// </summary>
		/// <value>The game object.</value>
		public GameObject GameObject { get; private set; }

		/// <summary>
		/// Gets the start position.
		/// </summary>
		/// <value>The start position.</value>
		public Vector3 StartPosition { get; private set; }

		/// <summary>
		/// Gets the current position.
		/// </summary>
		/// <value>The current position.</value>
		public Vector3 CurrentPosition
		{
			get { return this.GameObject != null && this.GameObject.transform != null ? this.GameObject.transform.position : Vector3.zero; }
		}

		/// <summary>
		/// Gets the controller.
		/// </summary>
		/// <value>The controller.</value>
		public PokemonController Controller
		{
			get
			{
				PokemonController result = null;
				
				if (this.GameObject != null)
				{
					result = this.GameObject.GetComponent<PokemonController>();
				}
				
				return result;
			}
		}
	}
}