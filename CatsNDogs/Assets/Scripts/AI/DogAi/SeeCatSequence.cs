﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeCatSequence : Leaf
{
    public Leaf RunTowardsCat;
    
    
    private Agent agent;
    private DogTree dog;
    public override void StartBehaviour(Agent _agent){
        agent = _agent;
        dog = agent.GetComponent<DogTree>();

        RunTowardsCat.StartBehaviour(agent);
    }

    public override void Succeed(){
        agent.Succeed();
    }

    public override void Continue(){
        agent.Continue();
    }

    public override void Failed(){
        agent.Failed();
    }
}
