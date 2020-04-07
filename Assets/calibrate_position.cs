using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calibrate_position : MonoBehaviour
{

    [SerializeField]public float x;

    [SerializeField] public float y = 1;

    [SerializeField] public float z = 1;

    [SerializeField] public GameObject marker =  null;
    //public InputField input_field;

    // Start is called before the first frame update
    void Start()
    {

    
}

    // Update is called once per frame
    void Update()
    {
        if (marker != null)
        {
            Debug.Log("position varibable received:  " + new Vector3(x, y, z).ToString());
            gameObject.transform.position = marker.transform.position + new Vector3(x, y, z);
        }
    }

    public void update_position(string position_text)
    {
      
        string[] postion_list = position_text.Split(',');

        Debug.Log("position received [list] : " + postion_list.ToString());
        List<float> p =  new List<float>(3);

        for (int i = 0;  i < postion_list.Length; i++)
        {
           
            float position = float.Parse(postion_list[i]);
            Debug.Log("position received: [float] " + position.ToString());
            if (i == 0)
            {
                this.x = position;
            }
            else if (i == 1){
                this.y = position;
            }
            else
            {
                this.z = position;
            }
        }

        }
       
      
    }

