using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.Lives.ToString() + " LIVES";
    }
}
