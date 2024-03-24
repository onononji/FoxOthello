using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    /// <summary>
    /// PageViewの基底クラス
    /// </summary>
    /// <typeparam name="ViewModelType"></typeparam>
    public abstract class BasePageView<ViewModelType> : MonoBehaviour, IPageView  where ViewModelType : BasePageView<ViewModelType>.BasePageViewModel
    {
        protected ViewModelType viewModel { private set; get; }
        protected readonly CompositeDisposable disposable = new();

        private void OnDestroy()
        {
            Dispose();
            if (!disposable.IsDisposed)
            {
                disposable.Dispose();
            }
        }

        public void Dispose()
        {
            disposable.Clear();
        }

        public abstract class BasePageViewModel
        {
            public virtual void Dispose()
            {

            }
        }

        public void BindViewModel(ViewModelType viewModel)
        {
            if (!disposable.IsDisposed)
            {
                disposable.Clear();
            }
            this.viewModel = viewModel;
            OnBind();
        }

        protected abstract void OnBind();

        public abstract void RegisterView();

        public abstract void UnRegisterView();
    }
    public interface IPageView
    {
        public void RegisterView();
        public void UnRegisterView();
    }
}
