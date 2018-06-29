using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpedometerScript : MonoBehaviour {

    public GameObject myText;
    private Text speedText;
    private float currentSpeed = 0;

    private CharacterController controller;

    void Start()
    {
        speedText = myText.GetComponent<Text>();
        GameObject getGObject = GameObject.FindGameObjectWithTag("Player");
        controller = getGObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        NewMethod();
        speedText.text = currentSpeed + "km/h";
    }

    private void NewMethod()
    {
        currentSpeed = controller.velocity.magnitude;
    }
}
