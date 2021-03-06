﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRunAway : Leaf
{
    public Transform retreatPoint;

    private Agent agent;
    private Unit AStarUnit;
    private CatTree cat;
    public override void StartBehaviour(Agent _agent){
        agent = _agent;
        cat = agent.GetComponent<CatTree>();
        AStarUnit = agent.GetComponent<Unit>();

        AStarUnit.target = retreatPoint;
        AStarUnit.enabled = true;
        if(AStarUnit.routeFinished){
            Succeed();
        } else {
            Continue();
        }
    }

    public override void Succeed(){
        AStarUnit.enabled = false;
        agent.Succeed();
    }

    public override void Continue(){
        agent.Continue();
    }

    public override void Failed(){
        AStarUnit.enabled = false;
        agent.Failed();
    }
}
