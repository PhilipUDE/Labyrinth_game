using UnityEngine;

public class DayNightCicle : MonoBehaviour {

    [SerializeField]
    private GameObject sun;
    [SerializeField]
    private GameObject moon;

    private float realTime = 0f;
    private float dayLength = 60f;
    public float gameTime;


    // Use this for initialization
    void Start ()
    {
        realTime = dayLength / 4; //Tag beginnt um 6 Uhr morgens
    }
	
	// Update is called once per frame
	void Update ()
    {
        Clock();
        SunAndMoon();        
    }

    private void Clock()
    {
        realTime += Time.deltaTime;
        gameTime = (realTime / dayLength) * 24;

        if (gameTime >= 24)
        {
            realTime = 0;
            gameTime = 0;
        }

    }

    private void SunAndMoon()
    {
        sun.transform.RotateAround(Vector3.zero, Vector3.right, (360 / dayLength) * Time.deltaTime);
        sun.transform.LookAt(Vector3.zero);
        moon.transform.RotateAround(Vector3.zero, Vector3.right, (360 / dayLength) * Time.deltaTime);
        moon.transform.LookAt(Vector3.zero);
    }

    public void NewDay()
    {
        realTime = dayLength / 4f; //Tag beginnt um 6
        sun.transform.position = new Vector3(0, 0, -500);
        moon.transform.position = new Vector3(0, 0, 500);
    }
}
