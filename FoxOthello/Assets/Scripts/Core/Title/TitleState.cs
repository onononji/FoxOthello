using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace FoxOthello.PageSystem
{
    public class TitleState : BasePageState<TitlePageView.TitlePageViewModel>
    {
        public TitleState(Transform parentTransform)
        {
            this.parentTransform = parentTransform;
        }

        public override async UniTask<IState> Start()
        {
            await StartAsync();
            viewModel.OnDescriptionButtonPressed += OnDescriptionButtonPressed;
            viewModel.OnStartButtonPressed += OnStartButtonPressed;
            return this;
        }

        private async UniTask StartAsync()
        {
            await CreateView("Title");
        }

        private async void OnDescriptionButtonPressed()
        {
            await UniTask.Yield();
            await ChangePage(new RuleExplanationState(parentTransform).Start());
        }

        private async void OnStartButtonPressed()
        {
            await UniTask.Yield();
            await ChangePage(new GameState(parentTransform).Start());
        }
    }
}
