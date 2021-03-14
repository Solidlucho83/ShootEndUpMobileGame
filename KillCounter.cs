using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public static int killed = 0;

    Text killedText;
    // Start is called before the first frame update
    void Start()
    {
        killedText = GetComponent<Text>();
    //    DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        killedText.text = "KILLED: " + killed;
        killedText.color = Color.red;
    }
}
