using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TMP_Text livesText;

    void Update()
    {
        livesText.text = PlayerStats.Lives.ToString() + " LIVES";
    }
}