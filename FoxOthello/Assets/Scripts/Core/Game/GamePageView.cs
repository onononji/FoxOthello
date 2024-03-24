using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class GamePageView : BasePageView<GamePageView.GamePageViewModel>
    {
        public class GamePageViewModel : BasePageViewModel
        {
            public GamePageViewModel()
            {
            }
        }

        public GamePageView()
        {
        }


        protected override void OnBind()
        {
        }

        public override void RegisterView()
        {
        }

        public override void UnRegisterView()
        {
        }
    }
}
