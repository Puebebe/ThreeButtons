using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public void ShowForSeconds(int seconds)
    {
        gameObject.SetActive(true);
        StartCoroutine(HideAfterSeconds(seconds));
    }

    IEnumerator HideAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        gameObject.SetActive(false);
    }
}
