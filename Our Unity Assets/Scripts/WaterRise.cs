using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Water;

public class WaterRise : MonoBehaviour
{
    public GameObject waterObj;
    public GameObject waterObj2;

    public GameObject trees1;

    public GameObject vehicles;
    public GameObject vehicles2;
    public GameObject vehicles3;

    public GameObject car;
    public GameObject car2;
    public GameObject car3;

    public GameObject truck;
    public GameObject truck2;
    public GameObject truck3;

    public GameObject motorbike;
    public GameObject motorbike2;
    public GameObject motorbike3;

    public GameObject bicycle;
    public GameObject bicycle2;
    public GameObject bicycle3;

    public GameObject bikes;
    public GameObject bikes2;
    public GameObject bikes3;

    public GameObject boat;
    public GameObject boat2;
    public GameObject submarine;
    public GameObject submarine2;

    public float speed;
    public Slider myclimateBar;
    public float maxClimate;
    public double i;

    // Start is called before the first frame update
    void Start()
    {
        waterObj = GameObject.Find("Water");
        waterObj2 = GameObject.Find("WaterGround");

        trees1 = GameObject.Find("TreeList");

        boat = GameObject.Find("boat");
        boat2 = GameObject.Find("boat2");
        submarine = GameObject.Find("submarine");
        submarine2 = GameObject.Find("submarine2");

        vehicles = GameObject.Find("VehicleList");
        car = vehicles.transform.GetChild(0).gameObject;
        truck = vehicles.transform.GetChild(1).gameObject;

        vehicles2 = GameObject.Find("VehicleList2");
        car2 = vehicles2.transform.GetChild(0).gameObject;
        truck2 = vehicles2.transform.GetChild(1).gameObject;

        vehicles3 = GameObject.Find("VehicleList2");
        car3 = vehicles3.transform.GetChild(0).gameObject;
        truck3 = vehicles3.transform.GetChild(1).gameObject;


        bikes = GameObject.Find("BikeList");
        motorbike = bikes.transform.GetChild(0).gameObject;
        bicycle = bikes.transform.GetChild(1).gameObject;

        bikes2 = GameObject.Find("BikeList2");
        motorbike2 = bikes2.transform.GetChild(0).gameObject;
        bicycle2 = bikes2.transform.GetChild(1).gameObject;

        bikes3 = GameObject.Find("BikeList3");
        motorbike3 = bikes3.transform.GetChild(0).gameObject;
        bicycle3 = bikes3.transform.GetChild(1).gameObject;

        waterObj.transform.position = new Vector3(0, 0f, 0f);
        waterObj2.transform.position = new Vector3(0, 0f, 0f);

        myclimateBar.maxValue = maxClimate;

        //float i = myclimateBar.value;
        i = myclimateBar.value;
    }

    // Update is called once per frame
    void Update()
    {
        /*
              if (car.activeSelf && motorbike.activeSelf) {

                for (i = 0; i <= 10; i += 0.05) {
                  waterObj.transform.position += new Vector3(0, 0.025f, 0f);
                  waterObj2.transform.position += new Vector3(0, 0.025f, 0f);
                  break;
                }

                if (waterObj.transform.position == new Vector3(0, 10f, 0f) || waterObj2.transform.position == new Vector3(0, 10f, 0f)) {
                  waterObj.transform.position += new Vector3(0, 0f, 0f);
                  waterObj2.transform.position += new Vector3(0, 0f, 0f);
                } else {
                  waterObj.transform.position += new Vector3(0, 0.025f, 0f);
                  waterObj2.transform.position += new Vector3(0, 0.025f, 0f);
                }
               myclimateBar.value += 0.05f;
               }

             }
        */

        //Active car and motorbike
        if (car.activeSelf && motorbike.activeSelf)
        {
            waterObj.transform.position += new Vector3(0, 0.015f, 0f);
            waterObj2.transform.position += new Vector3(0, 0.015f, 0f);
            boat.transform.position += new Vector3(0, 0.015f, 0f);
            boat2.transform.position += new Vector3(0, 0.015f, 0f);
            myclimateBar.value += 0.015f;
        }

        if ((truck.activeSelf || motorbike.activeSelf) || (car.activeSelf || bicycle.activeSelf))
        {
            waterObj.transform.position += new Vector3(0, 0.005f, 0f);
            waterObj2.transform.position += new Vector3(0, 0.005f, 0f);
            boat.transform.position += new Vector3(0, 0.005f, 0f);
            boat2.transform.position += new Vector3(0, 0.005f, 0f);

            myclimateBar.value += 0.005f;
        }


        if (truck.activeSelf && bicycle.activeSelf)
        {
            waterObj.transform.position += new Vector3(0, -0.015f, 0f);
            waterObj2.transform.position += new Vector3(0, -0.015f, 0f);
            boat.transform.position += new Vector3(0, -0.015f, 0f);
            boat2.transform.position += new Vector3(0, -0.015f, 0f);

            myclimateBar.value += -0.015f;
        }




        if (myclimateBar.value >= 1f)
        {
            if (waterObj.transform.position.y > 0f || waterObj2.transform.position.y > 0f)
            {
                boat.SetActive(true);
                boat2.SetActive(true);
            }
        }

        if (myclimateBar.value <= 1f)
        {
            if (waterObj.transform.position.y > 0f || waterObj2.transform.position.y > 0f)
            {
                boat.SetActive(false);
                boat2.SetActive(false);
            }
        }

        if (myclimateBar.value >= 6f)
        {
            if (waterObj.transform.position.y > 0f || waterObj2.transform.position.y > 0f)
            {
                submarine.SetActive(true);
                submarine2.SetActive(true);
                submarine.transform.position += new Vector3(transform.position.x, transform.position.y, 0.08f);
                submarine2.transform.position += new Vector3(transform.position.x, transform.position.y, 0.08f);
            }
        }

        if (myclimateBar.value <= 6f)
        {
            if (waterObj.transform.position.y > 0f || waterObj2.transform.position.y > 0f)
            {
                submarine.SetActive(false);
                submarine2.SetActive(false);
            }
        }

        if (myclimateBar.value <= 0f)
        {
            //fix snapping back to 0f
            if (waterObj.transform.position.y > 0f || waterObj2.transform.position.y > 0f)
            {
                waterObj.transform.position += new Vector3(0, -0.025f, 0f);
                waterObj2.transform.position += new Vector3(0, -0.025f, 0f);
                boat.transform.position += new Vector3(0, -0.025f, 0);
                boat2.transform.position += new Vector3(0, -0.025f, 0);
            }
            //fix water level going past 0f
            if (waterObj.transform.position.y <= 0f || waterObj2.transform.position.y <= 0f)
            {
                waterObj.transform.position = new Vector3(0, -0.002f, 0f);
                waterObj2.transform.position = new Vector3(0, -0.002f, 0f);
                boat.transform.position = new Vector3(-7.8f, -0.001f, 8.7f);
                boat2.transform.position = new Vector3(1f, -0.001f, 3.3f);
            }
        }

        if (myclimateBar.value >= 10f) {
            //set limit on max water height
            if (waterObj.transform.position.y > 10f || waterObj2.transform.position.y > 10f)
            {
                waterObj.transform.position = new Vector3(0, 10f, 0f);
                waterObj2.transform.position = new Vector3(0, 10f, 0f);
                boat.transform.position = new Vector3(-7.8f, 10f, 8.7f);
                boat2.transform.position = new Vector3(1f, 10f, 3.3f);
            }
        }


        /*
               if (myclimateBar.value > 10f) {
                 waterObj.transform.position = new Vector3(0, 5f, 0f);
                 waterObj2.transform.position = new Vector3(0, 5f, 0f);
               }
               if (myclimateBar.value <= 0f) {
                   waterObj.transform.position = new Vector3(0, 0f, 0f);
                   waterObj2.transform.position = new Vector3(0, 0f, 0f);
               }
        */
    }
}
