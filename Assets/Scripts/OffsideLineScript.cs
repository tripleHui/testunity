using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class OffsideLineScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        var lineXPos = players.Min(e => e.transform.localPosition.x);

        transform.localPosition = new Vector3(lineXPos < 0 ? lineXPos : 0, transform.localPosition.y, transform.localPosition.z);
    }
}
