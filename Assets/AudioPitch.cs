using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPitch : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject red;
    public GameObject white;

    public float distance;
    // Update is called once per frame
    void Update()
    {
        distance = (red.transform.position - white.transform.position).magnitude;

        if (distance < 4f)
        {
            float percent = 25f * distance;
            audioSource.pitch = 2f - (percent * 0.01f);
        }
        else audioSource.pitch = 1f;
    }
}
