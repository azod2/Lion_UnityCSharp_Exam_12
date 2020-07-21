using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("Test2-RendomGacha");
        }

        if (obj.transform.position.x<10)
        {
            obj.transform.Translate(new Vector3(2 * Time.deltaTime, 0, 0));
            
        }

    }
}
