using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class RuleExplanationState : BasePageState<RuleExplanationPageView.RuleExplanationPageViewModel>
    {

        public RuleExplanationState(Transform parentTransform)
        {
            this.parentTransform = parentTransform;
        }

        public async UniTask<IState> Start()
        {
            await StartAsync();
            viewModel.OnBackButtonPressed += OnBackButtonPressed;
            return this;
        }

        private async UniTask StartAsync()
        {
            await CreateView("RuleExplanation");
        }

        private async void OnBackButtonPressed()
        {
            await UniTask.Yield();
            await ChangePage(new TitleState(parentTransform).Start());
        }
    }
}
