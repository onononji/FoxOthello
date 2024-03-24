using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace FoxOthello.PageSystem
{
    public class PageInitializer
    {
        private readonly StateMachine _stateMachine;

        public PageInitializer(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public async UniTask InitializeAndRun(Transform parentTransform)
        {
            // StateMachineの初期設定などがあればここで行う

            // StateMachineを実行
            await _stateMachine.Run(new TitleState(parentTransform));
        }
    }
}
