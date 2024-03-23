using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace FoxOthello.PageState{
    public interface IState
    {
        UniTask<IState> Start();
    }

    public class StateTransition : IState
    {
        public UniTask<IState> NextState { get; }

        public StateTransition(UniTask<IState> nextState)
        {
            NextState = nextState;
        }

        public async UniTask<IState> Start()
        {
            await UniTask.Yield(); // なにかする
            return await NextState;
        }
    }
}

