using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class GameState : IState
    {
        private readonly int parameter;

        public GameState(int parameter)
        {
            this.parameter = parameter;
        }

        public async UniTask<IState> Start()
        {
            await UniTask.Yield(); // なにかする
            return new StateTransition(new ResultState(0).Start());
        }
    }
}
