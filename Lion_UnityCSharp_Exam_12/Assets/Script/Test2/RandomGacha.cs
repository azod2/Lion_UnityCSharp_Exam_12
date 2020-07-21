using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class RandomGacha : MonoBehaviour
{




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("Test3-Drawdiamond");
        }
        if (Input.GetKeyDown("o"))
        {
            SceneManager.LoadScene("Test1-MoveObject");
        }




    }

}
