using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour {

    [SerializeField]
    private InteractionEvent OnInteractEvent;

    public virtual void Interact()
    {
        OnInteractEvent.Invoke();
    }

}

[System.Serializable]
public class InteractionEvent : UnityEvent { }
