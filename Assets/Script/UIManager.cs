using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMPro.TMP_InputField TMP_InputField;
    public TMPro.TMP_InputField TMP_InputField2;
    public CameraController cameraController;

    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;

    public GameObject[] spheres;

    public int counter = 0 ;

    public Button leftButton;
    public Button rightButton;


    public void SensitivitySubmit()
    {
        cameraController.rotateSpeed = (float) Convert.ToDouble(TMP_InputField.text);
    }

    public void Start()
    {
        
    }


    public void SphereButtonFront()
    {
        if(counter< spheres.Length-1)
        {
            counter++;
        }

        for (int i = 0; i < spheres.Length; i++)
        {
            if(i == counter)
            {
                spheres[i].SetActive(true);
            }
            else
            {
                spheres[i].SetActive(false);
            }
        }

       
    }

    public void SphereButtonBack()
    {
        Debug.Log(counter);
        if (counter >0)
        {
            counter-- ;
        }
        Debug.Log(counter);

        for (int i = 0; i < spheres.Length; i++)
        {
            if (i == counter)
            {
                spheres[i].SetActive(true);
                Debug.Log(222);
            }
            else
            {
                spheres[i].SetActive(false);
            }
        }


    }

    public void Search360()
    {
        if (TMP_InputField2.text == "Outside University Entrance")
        {
            counter = 0;
            Debug.Log(counter);
        }

        else if (TMP_InputField2.text == "University Entrance")
        {
            counter = 1;
            Debug.Log(counter);
        }

        else if (TMP_InputField2.text == "Inside University Entrance")
        {
            counter = 2;
            Debug.Log(counter);
        }
       
        for (int i = 0; i < spheres.Length; i++)
        {
            if (i == counter)
            {
                spheres[i].SetActive(true);
                Debug.Log(222);
            }
            else
            {
                spheres[i].SetActive(false);
            }
        }
    }

}
