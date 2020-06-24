using UnityEngine;

namespace CM.Trigger
{
	/// <summary>
	/// Represents a Trigger that gets triggered when another object exits this object.
	/// Only works on 3D colliders.
	/// </summary>
	public sealed class TriggerExit3D : TriggerBase
	{
		private void OnTriggerExit(Collider other)
		{
			// Return if the layerMask doesn't contain the layer of the collided object.
			if (layerMask != (layerMask | (1 << other.gameObject.layer)))
				return;

			Trigger();
		}
	}
}