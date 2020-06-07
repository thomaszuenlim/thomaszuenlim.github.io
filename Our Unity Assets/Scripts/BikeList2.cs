using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeList2 : MonoBehaviour
{
    private GameObject[] bikeList;
    private int index;

    private void Start()
    {
        bikeList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            bikeList[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in bikeList)
            go.SetActive(false);

        if (bikeList[0])
            bikeList[0].SetActive(true);

    }

    public void SwitchBike()
    {
        bikeList[index].SetActive(false);

        index--;
        if (index < 0)
            index = bikeList.Length - 1;

        bikeList[index].SetActive(true);
    }
}
