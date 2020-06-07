using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterVehicleSystem : MonoBehaviour
{
    public GameObject boat;
    public GameObject boat2;
    public GameObject submarine;
    public GameObject submarine2;
    // Start is called before the first frame update
    void Start()
    {
        boat = GameObject.Find("boat");
        boat2 = GameObject.Find("boat2");
        submarine = GameObject.Find("submarine");
        submarine2 = GameObject.Find("submarine2");
    }

    // Update is called once per frame
    void Update()
    {
        boat.SetActive(false);
        boat2.SetActive(false);
        submarine.SetActive(false);
        submarine2.SetActive(false);
    }
}
