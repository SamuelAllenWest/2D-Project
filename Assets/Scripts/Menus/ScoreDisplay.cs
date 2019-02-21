using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text lives;

    private void Update()
    {
        lives.text = GameMangaerScript.Instance.playerHealth.ToString();
    }

}
