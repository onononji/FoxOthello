using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    /// <summary>
    /// PageViewの基底クラス
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    public abstract class BasePageView<TViewModel> : MonoBehaviour, IPageView  where TViewModel : BasePageView<TViewModel>.BasePageViewModel
    {
        protected TViewModel viewModel { private set; get; }
        protected readonly CompositeDisposable disposable = new CompositeDisposable();

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

        public void BindViewModel(TViewModel viewModel)
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
