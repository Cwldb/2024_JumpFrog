using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    [SerializeField] private Text gameTime;

    private float sec;
    private float min;

    private void Update()
    {
        sec += Time.deltaTime;
        if (sec >= 60f)
        {
            min += 1;
            sec = 0;
        }

        gameTime.text = string.Format("{0:D2}:{1:D2}",min ,(int)    sec);
    }
}
