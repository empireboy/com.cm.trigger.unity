using UnityEngine;

namespace CM.Trigger
{
	/// <summary>
	/// Represents a Trigger that gets triggered every frame another object is inside this object.
	/// Only works on 2D colliders.
	/// </summary>
	public sealed class TriggerStay2D : TriggerBase
	{
		private void OnTriggerStay2D(Collider2D other)
		{
			// Return if the layerMask doesn't contain the layer of the collided object.
			if (layerMask != (layerMask | (1 << other.gameObject.layer)))
				return;

			Trigger();
		}
	}
}