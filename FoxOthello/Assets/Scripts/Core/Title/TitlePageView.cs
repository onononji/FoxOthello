using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx.InternalUtil;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FoxOthello.PageSystem
{
    public class TitlePageView : BasePageView<TitlePageView.TitlePageViewModel>
    {
        public class TitlePageViewModel : BasePageViewModel
        {
            public event Action OnDescriptionButtonPressed;
            public event Action OnStartButtonPressed;

            public void PressDescriptionButton()
            {
                OnDescriptionButtonPressed?.Invoke();
            }

            public void PressStartButton()
            {
                OnStartButtonPressed?.Invoke();
            }
        }

        [SerializeField] private TMP_Text title;
        [SerializeField] private Button descriptionButton;
        [SerializeField] private Button startButton;

        protected override void OnBind()
        {
            descriptionButton.onClick.AddListener(viewModel.PressDescriptionButton);
            startButton.onClick.AddListener(viewModel.PressStartButton);
        }
        public override void RegisterView()
        {
            Debug.Log("TitlePageView.RegisterView");
        }

        public override void UnRegisterView()
        {
            Debug.Log("TitlePageView.UnRegisterView");
        }
    }
}
