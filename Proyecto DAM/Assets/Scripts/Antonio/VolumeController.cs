using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    void Start()
    {
        GetComponent<Slider>().onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        GameObject.FindWithTag("Game").GetComponent<GameController>().volume = GetComponent<Slider>().value;
        GameObject.FindWithTag("Game").GetComponent<AudioSource>().volume = GetComponent<Slider>().value;
    }

}
