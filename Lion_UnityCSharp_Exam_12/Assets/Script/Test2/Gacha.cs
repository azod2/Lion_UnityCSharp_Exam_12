using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Image image;
    public Animator ani;
    public Sprite[] item2;
    public bool result, play;
    public float temptime,count;
    public GameObject obj;

    private void Start()
    {
        //image.sprite = item2[0];
        temptime = 0;
        count = 0;
    }

    private void Update()
    {
        /*
        if (result)
        {
            temptime += Time.deltaTime;
        }
        */
        
    }

    public void RamdonItem()
    {
        obj.SetActive(false);
        if (temptime>0.6f || !result)
        {
            temptime = 0;
        }

        if (count==1)
        {
            count = 0;
        }

                    ani.enabled = true;
                    ani.SetTrigger("Play");
        if (count<1)
        {
            for (float i = 0; i < 0.58f; i+=Time.deltaTime)
            {
                Debug.Log("1");
                temptime = i;
                    play = true;
                if (temptime<0.1f && play)
                {
                    obj.SetActive(true);
                    ani.SetBool("play", true);
                    play = false;
                    result = true;
                Debug.LogWarning("2");
                }



                if (temptime>0.55f && result)
                {
                    Debug.LogError("3");
                    ani.enabled = false;
                    ani.SetBool("play", false);
                    obj.SetActive(false);
                    result = false;
                    count = 1;
                    Debug.LogError("4");
                }
            }
                    image.sprite = item2[Random.Range(0, item2.Length)];
        }

    }

}
