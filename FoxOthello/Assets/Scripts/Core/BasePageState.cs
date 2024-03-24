using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using FoxOthello.PageSystem;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    /// <summary>
    /// PageのStateを表し、次のStateへ引き継ぐ
    /// Viewを生成し、ViewModelをバインドする
    /// LogicのViewModelのバインドも行う
    /// ViewModelからもらった情報により次のStateへ遷移する
    /// </summary>
    /// <typeparam name="ViewModelType"></typeparam>
    public abstract class BasePageState<ViewModelType> : IState where ViewModelType : BasePageView<ViewModelType>.BasePageViewModel, new()
    {
        protected BasePageView<ViewModelType> view { private set; get; }
        protected ViewModelType viewModel { private set; get; }
        protected BasePageModel<ViewModelType> model { private set; get; }

        public async UniTask<IState> Start()
        {
            return null;
        }

        protected abstract BasePageView<ViewModelType> CreateView();

        protected void GeneratePage()
        {
            // あとでprefabを生成してviewを取得するように変更する
            view = CreateView();
            // viewmodelを生成してviewにバインドする
            viewModel = new ViewModelType();
            view.BindViewModel(viewModel);
            model = new BasePageModel<ViewModelType>();
            model.BindViewModel(viewModel);
        }

        protected void BindViewModel(ViewModelType viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}
