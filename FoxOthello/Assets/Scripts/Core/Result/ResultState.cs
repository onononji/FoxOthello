using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class ResultState : IState
    {
        private readonly int _parameter;

        public ResultState(int parameter)
        {
            _parameter = parameter;
        }

        public async UniTask<IState> Start()
        {
            await UniTask.Yield(); // なにかする
            return new StateTransition(new TitleState().Start());
        }
    }
}