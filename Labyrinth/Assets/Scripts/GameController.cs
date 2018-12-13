using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    private GameObject player;
    private DayNightCicle timeController;
    // Start is called before the first frame update
    void Start()
    {
        controller = this;

        player = GameObject.FindGameObjectWithTag("Player");
        timeController = GameObject.FindGameObjectWithTag("TimeController").GetComponent<DayNightCicle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
