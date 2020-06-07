using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleList : MonoBehaviour
{
    private GameObject[] vehicleList;
    private int index;

    private void Start()
    {
        vehicleList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            vehicleList[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in vehicleList)
            go.SetActive(false);

        if (vehicleList[0])
            vehicleList[0].SetActive(true);

    }

    public void SwitchVehicle()
    {
        vehicleList[index].SetActive(false);

        index--;
        if (index < 0)
            index = vehicleList.Length - 1;

        vehicleList[index].SetActive(true);
    }
}
