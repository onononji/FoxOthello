using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class BasePageModel<ViewModelType> : IPageLogic where ViewModelType : BasePageView<ViewModelType>.BasePageViewModel
    {
        protected ViewModelType viewModel { private set; get; }

        public void BindViewModel(ViewModelType viewModel)
        {
            this.viewModel = viewModel;
        }
    }

    public interface IPageLogic
    {

    }
}
