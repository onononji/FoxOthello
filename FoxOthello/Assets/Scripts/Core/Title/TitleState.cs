using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace FoxOthello.PageState
{
    public class TitleState : IState
    {
        public async UniTask<IState> Start()
        {
            await UniTask.Yield(); // なにかする
            return new StateTransition(new RuleExplanationState(0).Start());
        }
    }
}
