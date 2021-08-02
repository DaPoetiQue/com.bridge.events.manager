using System;
using UnityEngine.Events;

namespace Bridge.Core.App.Events
{
    public class AppEventsData
    {
        #region Options

        public enum AppViewState
        {
            MenuView,  LoadingView, SceneView, None
        }

        public enum SelectionType
        {
            About, Add, Cancel, Exit, Launch, None, Remove, Return, Clear
        }

        #endregion

        #region Events

        [Serializable]
        public class OnAppInitializedEvent : UnityEvent
        {
        }

        [Serializable]
        public class OnAppExitEvent : UnityEvent
        {
        }

        [Serializable]
        public class OnAppFocusedEvent : UnityEvent<bool>
        {
        }

        [Serializable]
        public class OnAppViewChangedEvent : UnityEvent<AppViewState>
        {
        }

        [Serializable]
        public class OnAppContentLoadedEvent : UnityEvent<int>
        {
        }

        [Serializable]
        public class OnSelectableUIEvent : UnityEvent<SelectionType, AppEventsData.AppViewState>
        {
        }

         [Serializable]
        public class OnShowLoadingScreenUIEvent : UnityEvent<bool>
        {
        }

        #endregion

        #region Call Backs

        public class CallBackResults
        {
            public bool success;
            public string successValue;

            public bool error;
            public string errorValue;
        }

        #endregion
    }
}
