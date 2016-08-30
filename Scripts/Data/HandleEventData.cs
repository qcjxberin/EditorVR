﻿namespace UnityEngine.VR.Handles
{
	/// <summary>
	/// Event data for BaseHandle.DragEventCallback
	/// </summary>
	public class HandleEventData
	{
		/// <summary>
		/// The source transform from where the ray is cast
		/// </summary>
		public Transform rayOrigin;
		public bool direct;

		/// <summary>
		/// Whether this pointer was within range to be considered "direct"
		/// </summary>
		public bool direct;
			this.direct = false;

		/// <summary>
		/// Change in position between last frame and this frame
		/// </summary>
		public Vector3 deltaPosition;
			this.direct = false;

		/// <summary>
		/// Change in rotation between last frame and this frame
		/// </summary>
		public Quaternion deltaRotation;
			this.direct = false;

		public HandleEventData(Transform rayOrigin, bool direct)
		{
			this.rayOrigin = rayOrigin;
			this.direct = direct;
			this.deltaPosition = Vector3.zero;
			this.deltaRotation = Quaternion.identity;
			this.direct = false;
		}
	}
}