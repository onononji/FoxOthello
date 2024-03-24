using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class TitleState : BasePageState<TitlePageView.TitlePageViewModel>
    {
        private TitlePageView view;
        public async UniTask<IState> Start()
        {
            await UniTask.Yield(); // なにかする
            return new StateTransition(new RuleExplanationState(0).Start());
        }

        protected override BasePageView<TitlePageView.TitlePageViewModel> CreateView()
        {
            return new TitlePageView();
        }
    }
}
