using Bridge.Core.Debug;

namespace Bridge.Core.App.Events
{
    public class EventsManager : MonoDebug
    {
        #region Instances
        private static EventsManager instance;

        public static EventsManager Instance
        {
            get
            {
                if(instance == null) instance = FindObjectOfType<EventsManager>();

                return instance;
            }
        }

        #endregion

        #region Components

        private AppEventsData.OnAppInitializedEvent onAppInitializedEvent;
        private AppEventsData.OnAppContentLoadedEvent onAppContentLoadedEvent;
        private AppEventsData.OnAppViewChangedEvent onAppViewChangedEvent;
        private AppEventsData.OnSelectableUIEvent onSelectableUIEvent;
        private AppEventsData.OnShowLoadingScreenUIEvent onShowLoadingScreenUIEvent;

        #endregion

        #region Main

        public AppEventsData.OnAppInitializedEvent OnAppInitializedEvent
        {
            get
            {
                if(onAppInitializedEvent == null) onAppInitializedEvent = new AppEventsData.OnAppInitializedEvent();

                Log(LogLevel.Debug, this, "On app initialized event created successfully.");
                return onAppInitializedEvent;
            }

            set
            {
                onAppInitializedEvent = value;
                Log(LogLevel.Debug, this, "On app initialized event set.");
            }
        }

        public AppEventsData.OnAppContentLoadedEvent OnAppContentLoadedEvent
        {
            get
            {
                if(onAppContentLoadedEvent == null) onAppContentLoadedEvent = new AppEventsData.OnAppContentLoadedEvent();

                Log(LogLevel.Debug, this, "On app content loaded successfully.");
                return onAppContentLoadedEvent;
            }

            set
            {
                onAppContentLoadedEvent = value;
                Log(LogLevel.Debug, this, "On app content loaded event set.");
            }
        }

        public AppEventsData.OnAppViewChangedEvent OnAppViewChangedEvent
        {
            get
            {
                if(onAppViewChangedEvent == null) onAppViewChangedEvent = new AppEventsData.OnAppViewChangedEvent();

                Log(LogLevel.Debug, this, "On app view changed event created successfully.");
                return onAppViewChangedEvent;
            }

            set
            {
                onAppViewChangedEvent = value;
                Log(LogLevel.Debug, this, "On app view changed event set.");
            }
        }

        public AppEventsData.OnSelectableUIEvent OnSelectableUIEvent
        {
            get
            {
                if(onSelectableUIEvent == null) onSelectableUIEvent = new AppEventsData.OnSelectableUIEvent();

                Log(LogLevel.Debug, this, "Selectable UI selected.");
                return onSelectableUIEvent;
            }

            set
            {
                onSelectableUIEvent = value;
                Log(LogLevel.Debug, this, "On selectable UI event set.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AppEventsData.OnShowLoadingScreenUIEvent OnShowLoadingScreenUIEvent
        {
            get
            {
                if(onShowLoadingScreenUIEvent == null) onShowLoadingScreenUIEvent = new AppEventsData.OnShowLoadingScreenUIEvent();

                Log(LogLevel.Debug, this, "On show loading screen event.");
                return onShowLoadingScreenUIEvent;
            }

            set
            {
                onShowLoadingScreenUIEvent = value;
                Log(LogLevel.Debug, this, "On show loading screen event.");
            }
        }

        #endregion
    }
}
