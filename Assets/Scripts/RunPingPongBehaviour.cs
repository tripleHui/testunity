using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunPingPongBehaviour : MonoBehaviour
{
    private Vector3 _startPos;
    private Vector3 _endPos;
    private Vector3 _prevPos;

    public float speed = 10;
    public float speedJitter = 10;

    // Start is called before the first frame update
    void Start()
    {
        _prevPos = _startPos = transform.position;
        _endPos = new Vector3(-_startPos.x, _startPos.y, _startPos.z);

        iTween.MoveTo(gameObject, iTween.Hash("position", _endPos, "speed", speed + Random.Range(0, speedJitter), "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.pingPong, "islocal", true));
    }

    // Update is called once per frame
    void Update()
    {

        var movingVector = transform.position - _prevPos;
        Debug.Log(movingVector);
        this.transform.LookAt(transform.position + movingVector);
        _prevPos = transform.position;
    }
}
