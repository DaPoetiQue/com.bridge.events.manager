using UnityEditor;

namespace Bridge.Core.Events
{
    public class EventsManagerEditor : Editor
    {
        
        [MenuItem("3ridge/Create/Events Manager")]
        private static void CreateEventsManager()
        {
            var eventsManager = new UnityEngine.GameObject("_3ridge Events Manager");
            eventsManager.AddComponent<EventsManager>();

            if(Selection.activeGameObject != null) eventsManager.transform.SetParent(Selection.activeGameObject.transform);

            UnityEngine.Debug.Log("<color=white>-->></color> <color=green> Success </color>:<color=white> An events manager has been created successfully.</color>");
        }

        [MenuItem("3ridge/Create/Events Manager", true)]
        private static bool CanCreateEventsManager()
        {
            return FindObjectOfType<EventsManager>() == null;
        }
    }
}
