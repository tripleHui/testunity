using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSet : MonoBehaviour
{
    GameObject marker = null;
    // Start is called before the first frame update
    bool isSet = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        marker = GameObject.Find("test");
        if (marker == null)
        {

            Debug.Log("cannot found the marker");

        }
        else
        {
            if (isSet == false)
            {
                //isSet = true;

                gameObject.transform.position = marker.transform.position + new Vector3(0, 1, 0);
            }

        }
    }
}
