using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class ResultState : BasePageState<ResultPageView.ResultPageViewModel>
    {

        public ResultState(Transform parentTransform)
        {
            this.parentTransform = parentTransform;
        }

        public override async UniTask<IState> Start()
        {
            await StartAsync();
            return this;
        }

        private async UniTask StartAsync()
        {
            await CreateView("Result");

            // 5秒待つ
            await UniTask.Delay(5000);
            await ChangePage(new TitleState(parentTransform).Start());
        }
    }
}