using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public GameObject people;
    // Start is called before the first frame update
    void Start()
    {
        people = GameObject.Find("Humans");
    }

    // Update is called once per frame
    void Update()
    {
        people.transform.position += new Vector3(0, 0, 0.01f);
    }
}
