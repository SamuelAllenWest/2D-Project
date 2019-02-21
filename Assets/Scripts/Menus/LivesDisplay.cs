using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public Text scoreText;

    private void Update()
    {
        scoreText.text = GameMangaerScript.Instance.score.ToString();
    }


}
    