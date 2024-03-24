using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FoxOthello.PageSystem
{
    public class RuleExplanationPageView : BasePageView<RuleExplanationPageView.RuleExplanationPageViewModel>
    {
        public class RuleExplanationPageViewModel : BasePageViewModel
        {
            public event Action OnBackButtonPressed;

            public void PressBackButton()
            {
                OnBackButtonPressed?.Invoke();
            }
        }

        [SerializeField] private Button backButton;
        [SerializeField] private TMP_Text ruleText;

        protected override void OnBind()
        {
            backButton.onClick.AddListener(viewModel.PressBackButton);
        }

        public override void RegisterView()
        {
        }

        public override void UnRegisterView()
        {
        }
    }
}
