using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageState
{
    public class StateMachine
    {
        public async UniTask Run(IState firstState)
        {
            var currentState = firstState;

            while (currentState != null)
            {
                currentState = await currentState.Start();
            }
        }
    }
}
