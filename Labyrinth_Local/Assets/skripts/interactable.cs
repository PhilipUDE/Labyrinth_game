using UnityEngine;

public class interactable : MonoBehaviour {

    private GameObject player;
    private float distance;
    
	void Start () {
        player = GameObject.Find("FPSController");
	}
	
	void Update () {
        
	}

    private void Distance()
    {
        distance = Mathf.Sqrt(Mathf.Pow(player.transform.position.x - transform.position.x, 2f)
                                + Mathf.Pow(player.transform.position.y - transform.position.y, 2f)
                                + Mathf.Pow(player.transform.position.z - transform.position.z, 2f));
    }

    public void OnMouseOver()
    {
        Distance();
        if(distance <= 5f) //distanz später als variable
        {

        }
    }
}
