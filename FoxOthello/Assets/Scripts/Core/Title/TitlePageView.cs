using System.Collections;
using System.Collections.Generic;
using UniRx.InternalUtil;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class TitlePageView : BasePageView<TitlePageView.TitlePageViewModel>
    {
        public class TitlePageViewModel : BasePageViewModel
        {
            public readonly string title = null;
            public readonly bool pressedDescriptionButton = false;
            public readonly bool pressedStartButton = false;
        }

        [SerializeField] private string title;
        [SerializeField] private string description;
        [SerializeField] private bool startButton;

        public override void RegisterView()
        {
            Debug.Log("TitlePageView.RegisterView");
        }

        public override void UnRegisterView()
        {
            Debug.Log("TitlePageView.UnRegisterView");
        }

        protected override void OnBind()
        {
            Debug.Log("TitlePageView.OnBind");
        }
    }
}
