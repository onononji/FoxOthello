using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using FoxOthello.PageSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace FoxOthello.PageSystem
{
    /// <summary>
    /// PageのStateを表し、次のStateへ引き継ぐ
    /// Viewを生成し、ViewModelをバインドする
    /// LogicのViewModelのバインドも行う
    /// ViewModelからもらった情報により次のStateへ遷移する
    /// </summary>
    /// <typeparam name="TViewModel">ViewModelの具象クラス</typeparam>
    public abstract class BasePageState<TViewModel> : IState where TViewModel : BasePageView<TViewModel>.BasePageViewModel, new()
    {
        protected BasePageView<TViewModel> view { private set; get; }
        protected TViewModel viewModel { private set; get; }
        protected BasePageModel<TViewModel> model { private set; get; }

        protected GameObject InstantiateObject { private set; get; }

        protected Transform parentTransform { set; get; }

        public virtual async UniTask<IState> Start()
        {
            await UniTask.Yield();
            return null;
        }

        protected async UniTask CreateView(string addressableName)
        {
            // addressableからprefabを生成してviewを取得する
            GameObject viewObject = await Addressables.LoadAssetAsync<GameObject>(addressableName).Task;

            if(viewObject != null)
            {
                await UniTask.SwitchToMainThread();
                InstantiateView(viewObject);
                if(view != null)
                {
                    GeneratePage();
                }
            }
        }

        protected void InstantiateView(GameObject viewObject)
        {
            InstantiateObject = MonoBehaviour.Instantiate(viewObject, parentTransform);
            view = InstantiateObject.GetComponent<BasePageView<TViewModel>>();
        }

        protected void GeneratePage()
        {
            // viewmodelを生成してviewにバインドする
            viewModel = new TViewModel();
            view.BindViewModel(viewModel);
            model = new BasePageModel<TViewModel>();
            model.BindViewModel(viewModel);
        }

        protected async UniTask ChangePage(UniTask<IState> nextPageTask)
        {
            // InstantiateObjectを破棄する
            InstantiateObject.transform.SetParent(null);
            GameObject.Destroy(InstantiateObject);

            // viewmodelを破棄する
            viewModel.Dispose();

            await nextPageTask;
        }
    }
}
