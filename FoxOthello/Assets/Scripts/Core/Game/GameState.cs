using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class GameState : BasePageState<GamePageView.GamePageViewModel>
    {

        public GameState(Transform parentTransform)
        {
            this.parentTransform = parentTransform;
        }

        public async UniTask<IState> Start()
        {
            await StartAsync();
            return this;
        }

        private async UniTask StartAsync()
        {
            await CreateView("Game");

            // 5秒待つ
            await UniTask.Delay(5000);
            await ChangePage(new ResultState(parentTransform).Start());
        }
    }
}
