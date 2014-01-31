using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Database.Enums;
using Mobamon.Database.Classes;

namespace AssemblyCSharp.Moves
{
	public class AttackCollider : MonoBehaviour {

		public ParticleSystem _particleSystem;
		public PolygonCollider2D _collider;
		public AttackShape _shape;

		public float _coneAngle;
		public int _coneEndPrecision;

		private bool _hasBeenStarted = false;

		private float _startTime;
		private float _stopPlayingTime = -1.0f;
		private Vector3 _startPosition;
		private float _particleMaxSpeed;
		private Vector3 _endPosition;

		// Use this for initialization
		void Start () {
			this._startTime = Time.time;

			this._startPosition = this._particleSystem.transform.position;
			this._particleMaxSpeed = this._particleSystem.startSpeed;
			this._endPosition = this._particleSystem.transform.forward * this._particleMaxSpeed;
		}

		void OnTriggerEnter(Collider other) {
			float  a = 0.0f;
			Debug.Log ("Trigger");
		}

		// Update is called once per frame
		void Update () {
			if (this._particleSystem != null && this._particleSystem.IsAlive ()) {
				if (this._particleSystem.isPlaying && !this._hasBeenStarted) {
					this._hasBeenStarted = true;
				}

				if (this._hasBeenStarted && this._particleSystem.isStopped && this._stopPlayingTime < float.Epsilon) {
					this._hasBeenStarted = false;
					this._stopPlayingTime = Time.time;
				}

				Vector2[] vertices = this.GenerateVertices();
				this._collider.SetPath(0, vertices);
			}
		}

		private Vector2[] GenerateVertices() {
			switch (this._shape) {
				case AttackShape.Cone:
				default:
					return this.GenerateConeVertices();
			}
		}

		private Vector2[] GenerateConeVertices() {
			List<Vector2> vertices = new List<Vector2>();

			float timeSinceStart = Time.time - this._startTime;
			float currentStartPercent = 0.0f;
			float currentEndPercent = Mathf.Clamp(timeSinceStart / this._particleMaxSpeed, 0, 1);

			// If the particle system is stopped, get the current collider base position
			if (this._stopPlayingTime > float.Epsilon) {
				float timeSinceStopPlaying = Time.time - this._stopPlayingTime;
				currentStartPercent = Mathf.Clamp(timeSinceStopPlaying / timeSinceStart, 0, 1);
			}
						
			float baseDistance = Vector3.Distance(this._startPosition, this._startPosition + (this._particleSystem.transform.forward * this._particleMaxSpeed * currentStartPercent));

			if (baseDistance <= float.Epsilon) {
				Vector3 position = this._startPosition;
				vertices.Add(position.ToVector2_XZ());
			}
			else {
				float[] angles = { -this._coneAngle, this._coneAngle };

				for (int i = 0; i < angles.Length; i++) {
					Vector3 direction = Quaternion.AngleAxis(-this._coneAngle, this._particleSystem.transform.up) * this._endPosition;
					Vector3 position = this._startPosition + direction * currentStartPercent;
					vertices.Add(position.ToVector2_XZ());
				}
			}

			for (int i = 0; i < this._coneEndPrecision; i++) {
				float angle = ((this._coneAngle / this._coneEndPrecision) * i) - this._coneAngle;

				Vector3 direction = Quaternion.AngleAxis(angle, this._particleSystem.transform.up) * this._endPosition;
				Vector3 vertexPosition = this._startPosition + direction * currentEndPercent;
				vertices.Add(vertexPosition.ToVector2_XZ());
			}

			return vertices.ToArray();
		}
	}
}