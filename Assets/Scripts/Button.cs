using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Button))]
public class Button : MonoBehaviour
{
    public void DisableForSeconds(int seconds)
    {
        GetComponent<UnityEngine.UI.Button>().interactable = false;
        StartCoroutine(EnableAfterSeconds(seconds));
    }

    IEnumerator EnableAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        GetComponent<UnityEngine.UI.Button>().interactable = true;
    }
}
