using UnityEditor;

namespace Bridge.Core.Events
{
    public class EventsManagerEditor : Editor
    {
        
        [MenuItem("Bridge/Create/Events Manager")]
        private static void CreateEventsManager()
        {
            var eventsManager = new UnityEngine.GameObject("_Events Manager");
            eventsManager.AddComponent<EventsManager>();

            if(Selection.activeGameObject != null) eventsManager.transform.SetParent(Selection.activeGameObject.transform);

            UnityEngine.Debug.Log("<color=white>-->></color> <color=green> Success </color>:<color=white> An events manager has been created successfully.</color>");
        }

        [MenuItem("Bridge/Create/Events Manager", true)]
        private static bool CanCreateEventsManager()
        {
            return FindObjectOfType<EventsManager>() == null;
        }
    }
}
