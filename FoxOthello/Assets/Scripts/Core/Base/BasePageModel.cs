using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    /// <summary>
    /// PageにおけるModelの基底クラス
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    public class BasePageModel<TViewModel> : IPageLogic where TViewModel : BasePageView<TViewModel>.BasePageViewModel
    {
        protected TViewModel viewModel { private set; get; }

        public void BindViewModel(TViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
    }

    public interface IPageLogic
    {

    }
}
