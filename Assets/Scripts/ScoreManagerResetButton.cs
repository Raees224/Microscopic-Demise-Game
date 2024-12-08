using System.Collections;
using UnityEngine;

public class ScoreManagerResetButton : MonoBehaviour
{
    public GameObject scoreResetTxt;

    public void Reset()
    {
        PlayerPrefs.DeleteKey("currentScore");
        StartCoroutine(WaitBeforeShow());
    }

    IEnumerator WaitBeforeShow()
    {
        scoreResetTxt.SetActive(true);
        yield return new WaitForSeconds(3);
        scoreResetTxt.SetActive(false);
    }
}
