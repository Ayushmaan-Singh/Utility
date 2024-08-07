using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
namespace AstekUtility.EventArchitecture
{
	[CreateAssetMenu(menuName = "Event Architecture/ GameEvent_SO")]
	public class GameEvent_SO : SerializedScriptableObject
	{
		private List<GameEventListener> _listeners = new List<GameEventListener>();

		public void Raise()
		{
			for (int i = _listeners.Count - 1; i >= 0; i--)
			{
				_listeners[i].OnEventRaised();
			}
		}

		public void RegisterListener(GameEventListener listener)
		{
			_listeners.Add(listener);
		}

		public void UnregisterListener(GameEventListener listener)
		{
			_listeners.Remove(listener);
		}
	}
}