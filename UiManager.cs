using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class UiManager : MonoBehaviour
{
    public Slider playerHealtBar;
    /* public Text playerHealtText;*/

    public HealtPlayer healtPlayer;


 

    // Update is called once per frame
    void Update()
    {
        playerHealtBar.maxValue = healtPlayer.maxHealth;
        playerHealtBar.value = healtPlayer.currentHealth;

       /* StringBuilder sb = new StringBuilder("HP: ");
        sb.Append(playerHealtManager.currentHealth);
        sb.Append("/");
        sb.Append(playerHealtManager.maxHealth);
        playerHealtText.text = sb.ToString();*/
    }


}
