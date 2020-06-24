using UnityEngine;

namespace CM.Trigger
{
	/// <summary>
	/// Represents a Trigger that gets triggered every frame another object is inside this object.
	/// Only works on 3D colliders.
	/// </summary>
	public sealed class TriggerStay3D : TriggerBase
	{
		private void OnTriggerStay(Collider other)
		{
			// Return if the layerMask doesn't contain the layer of the collided object.
			if (layerMask != (layerMask | (1 << other.gameObject.layer)))
				return;

			Trigger();
		}
	}
}