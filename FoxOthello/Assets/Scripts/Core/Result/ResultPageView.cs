using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class ResultPageView : BasePageView<ResultPageView.ResultPageViewModel>
    {
        public class ResultPageViewModel : BasePageViewModel
        {
        }

        public override void RegisterView()
        {
            Debug.Log("ResultPageView.RegisterView");
        }

        public override void UnRegisterView()
        {
            Debug.Log("ResultPageView.UnRegisterView");
        }

        protected override void OnBind()
        {
            Debug.Log("ResultPageView.OnBind");
        }
    }
}
