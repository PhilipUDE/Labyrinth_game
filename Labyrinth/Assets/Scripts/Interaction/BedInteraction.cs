using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedInteraction : Interaction
{
    public override void Interact()
    {
        base.Interact();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = transform.position;
        Vector3 positionInBed = new Vector3(90, 0, 90);
        player.transform.Rotate(positionInBed);
    }
}
