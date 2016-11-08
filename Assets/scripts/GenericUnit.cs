using System.Collections;
using UnityEngine;

public class GenericUnit : Unit
{
    public string UnitName;

    public override void Initialize()
    {
        base.Initialize();
        transform.position += new Vector3(0, 0, -1);
    }

    public override void OnUnitDeselected()
    {
        base.OnUnitDeselected();
        transform.localScale = new Vector3(1, 1, 1);
    }

    public override void MarkAsAttacking(Unit other)
    {

    }

    public override void MarkAsDefending(Unit other)
    {

    }

    public override void MarkAsDestroyed()
    {
    }

    public override void MarkAsFinished()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }

    public override void MarkAsFriendly()
    {
        GetComponent<Renderer>().material.color = new Color(0.8f, 1, 0.8f);
    }

    public override void MarkAsReachableEnemy()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public override void MarkAsSelected()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public override void UnMark()
    {
    }
}

