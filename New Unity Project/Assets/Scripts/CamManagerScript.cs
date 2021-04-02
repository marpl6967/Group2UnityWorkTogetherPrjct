using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamManagerScript : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject picInPicture;
    public GameObject sideViewCam;
    public GameObject upperSplitScreen;
    public GameObject lowerSplitScreen;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSliderValueChanged(float value)
    {
        Debug.LogFormat("Slider:{0}", value);
        // Code will go here
    }

    public void SwitchViews(Dropdown change)
    {
        Debug.LogFormat("{0}:{1}", change.itemText.text,
            change.value);
        // Code will go here


    }
}
