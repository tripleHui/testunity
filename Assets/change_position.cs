using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class change_position : MonoBehaviour
{
#if UNITY_ANDROID || UNITY_IOS
    private ARRaycastManager arRaycastManager;
#endif

    // Start is called before the first frame update
    void Start()
    {

#if UNITY_ANDROID || UNITY_IOS
        arRaycastManager = FindObjectOfType<ARRaycastManager>();
        if (arRaycastManager == null)
        {
            Debug.Log("Missing ARRaycastManager in scene");
        }
#endif

    }

    // Update is called once per frame
    void Update()
    {


        Vector3 v3;

        if (Input.touchCount != 1)
        {

            return;
        }

        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;

        if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
        {


#if UNITY_ANDROID || UNITY_IOS
            List<ARRaycastHit> aRRaycastHits = new List<ARRaycastHit>();
            if (arRaycastManager.Raycast(touch.position, aRRaycastHits) && aRRaycastHits.Count > 0)
            {
                ARRaycastHit hit = aRRaycastHits[0];

                  Debug.Log("hit location:  " + hit.pose.position.ToString());
                Quaternion rotation = Quaternion.AngleAxis(0, Vector3.up);

                gameObject.transform.position = hit.pose.position;


                Debug.Log("hit location:  " + hit.pose.position.ToString());

            }

#endif


        }
    }

}


  
    