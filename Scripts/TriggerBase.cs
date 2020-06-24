using CM.Patterns.Command;
using UnityEngine;
using UnityEngine.Events;

namespace CM.Trigger
{
	/// <summary>
	/// Represents the basic behaviour of a trigger.
	/// </summary>
	public abstract class TriggerBase : MonoBehaviour
	{
		/// <summary>
		/// The layer that can trigger this class.
		/// </summary>
		public LayerMask layerMask;

		/// <summary>
		/// Invokes when this class gets triggered.
		/// </summary>
		public UnityEvent onTrigger;

		[SerializeField]
		private CommandSO[] _commands = null;

		/// <summary>
		/// Triggers the OnTrigger UnityEvent and all assigned Commands.
		/// </summary>
		public void Trigger()
		{
			onTrigger.Invoke();

			foreach (CommandSO commandSO in _commands)
				commandSO.GetCommand().Execute();
		}
	}
}