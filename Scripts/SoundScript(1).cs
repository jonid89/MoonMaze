using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static SoundScript soundScript;

    private void Awake()
    {
        if (soundScript != null && soundScript != this)
        {
            Destroy(this.gameObject);
            return;
        }

        soundScript = this;
        DontDestroyOnLoad(this);
    }

}
