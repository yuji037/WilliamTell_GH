﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//能動的にStateが変わらない
public class G20_AIRunState : G20_AIState
{
    public G20_AIRunState(float end_time,G20_AI _owner) : base(end_time,_owner) { }
    public override void OnEnd()
    {
    }

    public override void OnStart()
    {

        owner.enemy.anim.Run();
    }

    protected override G20_AIState Update()
    {
        return null;
    }
}
