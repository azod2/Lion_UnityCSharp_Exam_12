using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public GameObject obj;
    public int a, b, c;

    // Start is called before the first frame update
    void Start()
    {
        Draw();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("Test2-RendomGacha");
        }
        if (Input.GetKeyDown("o"))
        {
            SceneManager.LoadScene("Test4-RunEvent");
        }
    }


    public void Draw()
    {
        
        for ( int i = 0; i < 5; i++) 
        {
            a = i;


            for (int j = 0; j < i; j++)
            {
                b = j;
                    Instantiate(obj, new Vector3(j, i, 0), Quaternion.identity);
                for (int k = -1; Mathf.Abs(k) < i; k--)
                {
                    c = k;
                    Instantiate(obj, new Vector3(k, i, 0), Quaternion.identity);

                }   
            }
            


        }
            /*
            for (int n = 10; n > 5; n--)
            {

                for (int l = 3; l < n; l--)
                {
                    Instantiate(obj, new Vector3(l, n, 0), Quaternion.identity);
                    for (int m = -3; Mathf.Abs(m) < n; m++)
                    {
                        Instantiate(obj, new Vector3(m,n, 0), Quaternion.identity);
                    }
                }
            }
            */




        


    }


}
